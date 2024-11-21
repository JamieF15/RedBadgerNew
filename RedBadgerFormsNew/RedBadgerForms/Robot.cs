namespace RedBadgerForms
{
    internal class Robot
    {
        char orientation;
        private Point coordinates;
        private Point lastCoordinate;
        private bool isLost;
        public Robot(char orientation, Point coordinates)
        {
            this.orientation = orientation;
            this.coordinates = coordinates;
            lastCoordinate = coordinates;
            isLost = false;
        }

        public void SetisLost(bool isLost)
        {
            this.isLost = isLost;
        }

        public bool GetIsLost()
        {
            return isLost;
        }
        public char GetOrientation()
        {
            return orientation;
        }

        public void SetOrientation(char orientation)
        {
            this.orientation = orientation;
            Grid.gridElements[GetCoordinates().X, GetCoordinates().Y].BackgroundImage =
                                Image.FromFile(@"C:\Users\Jamie\Desktop\RedBadgerForms\RedBadgerForms\bin\Debug\net8.0-windows\arrow" + orientation + ".png");
        }

        public Point GetCoordinates()
        {
            return coordinates;
        }

        public void SetCoordinates(Point coordinates)
        {
            this.coordinates = coordinates;
        }

        public void MoveLeft()
        {
            switch (orientation.ToString().ToUpper())
            {
                case "N":
                    SetOrientation('W');
                    break;

                case "E":
                    SetOrientation('N');

                    break;
                case "S":
                    SetOrientation('E');

                    break;
                case "W":
                    SetOrientation('S');

                    break;
            }
        }

        public void MoveRight()
        {
            switch (orientation.ToString().ToUpper())
            {
                case "N":
                    SetOrientation('E');
                    break;

                case "E":
                    SetOrientation('S');

                    break;
                case "S":
                    SetOrientation('W');

                    break;
                case "W":
                    SetOrientation('N');

                    break;
            }
        }

        public void MoveForward()
        {
            Point nextCoordinate;

            this.lastCoordinate = coordinates;
            switch (orientation.ToString().ToUpper())
            {
                case "N":
                    nextCoordinate = new Point(coordinates.X + 1, coordinates.Y);
                    if (nextCoordinate.X > Grid.gridElements.GetLength(0) - 1)
                    {
                        if (!Grid.gridElements[coordinates.X, coordinates.Y].GetHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    Grid.gridElements[nextCoordinate.X, nextCoordinate.Y].SetRobotInElement(this);
                    Grid.gridElements[coordinates.X, coordinates.Y].BackgroundImage = null;
                    this.SetCoordinates(nextCoordinate);
                    break;

                case "E":
                    nextCoordinate = new Point(coordinates.X, coordinates.Y + 1);
                    if (nextCoordinate.Y > Grid.gridElements.GetLength(1) - 1)
                    {
                        if (!Grid.gridElements[coordinates.X, coordinates.Y].GetHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    Grid.gridElements[nextCoordinate.X, nextCoordinate.Y].SetRobotInElement(this);
                    Grid.gridElements[coordinates.X, coordinates.Y].BackgroundImage = null;
                    this.SetCoordinates(nextCoordinate);
                    break;

                case "S":
                    nextCoordinate = new Point(coordinates.X - 1, coordinates.Y);
                    if (nextCoordinate.X < 0)
                    {
                        if (!Grid.gridElements[coordinates.X, coordinates.Y].GetHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    Grid.gridElements[nextCoordinate.X, nextCoordinate.Y].SetRobotInElement(this);
                    Grid.gridElements[coordinates.X, coordinates.Y].BackgroundImage = null;
                    this.SetCoordinates(nextCoordinate);
                    break;

                case "W":
                    nextCoordinate = new Point(coordinates.X, coordinates.Y - 1);
                    if (nextCoordinate.Y < 0)
                    {
                        if (!Grid.gridElements[coordinates.X, coordinates.Y].GetHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    Grid.gridElements[nextCoordinate.X, nextCoordinate.Y].SetRobotInElement(this);
                    Grid.gridElements[coordinates.X, coordinates.Y].BackgroundImage = null;
                    this.SetCoordinates(nextCoordinate);
                    break;
            }
        }
        private void ProcessLostRobot(int x, int y)
        {
            Grid.gridElements[x, y].BackgroundImage = null;
            Grid.gridElements[x, y].BackColor = Color.Green;
            Grid.gridElements[x, y].SetHasScent(true);
            this.SetisLost(true);
        }
    }
}