﻿namespace RedBadgerForms
{
    public class Robot
    {
        char orientation;
        private Point coordinates;
        private bool isLost;
        public Robot(char orientation, Point coordinates)
        {
            this.orientation = orientation;
            this.coordinates = coordinates;
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
            Grid.GetGridElements()[GetCoordinates().X, GetCoordinates().Y].SetRobotInElement(this);
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

        void UpdateRobotOnGrid(Point nextCoordinate)
        {
            Grid.GetGridElements()[nextCoordinate.X, nextCoordinate.Y].SetRobotInElement(this);
            Grid.GetGridElements()[coordinates.X, coordinates.Y].BackgroundImage = null;
            this.SetCoordinates(nextCoordinate);
        }

        bool GridElementHasScent()
        {
            return Grid.GetGridElements()[coordinates.X, coordinates.Y].GetHasScent();
        }

        public void MoveForward()
        {
            Point nextCoordinate;

            switch (orientation.ToString().ToUpper())
            {
                case "N":
                    nextCoordinate = new Point(coordinates.X + 1, coordinates.Y);
                    if (nextCoordinate.X > Grid.GetGridElements().GetLength(0) - 1)
                    {
                        if (!GridElementHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    UpdateRobotOnGrid(nextCoordinate);
                    break;

                case "E":
                    nextCoordinate = new Point(coordinates.X, coordinates.Y + 1);
                    if (nextCoordinate.Y > Grid.GetGridElements().GetLength(1) - 1)
                    {
                        if (!GridElementHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    UpdateRobotOnGrid(nextCoordinate);
                    break;

                case "S":
                    nextCoordinate = new Point(coordinates.X - 1, coordinates.Y);
                    if (nextCoordinate.X < 0)
                    {
                        if (!GridElementHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    UpdateRobotOnGrid(nextCoordinate);
                    break;

                case "W":
                    nextCoordinate = new Point(coordinates.X, coordinates.Y - 1);
                    if (nextCoordinate.Y < 0)
                    {
                        if (!GridElementHasScent())
                        {
                            ProcessLostRobot(coordinates.X, coordinates.Y);
                            break;
                        }
                        break;
                    }
                    UpdateRobotOnGrid(nextCoordinate);
                    break;
            }
        }
        private void ProcessLostRobot(int x, int y)
        {
            Grid.GetGridElements()[x, y].BackgroundImage = null;
            Grid.GetGridElements()[x, y].BackColor = Color.Green;
            Grid.GetGridElements()[x, y].SetHasScent(true);
            this.SetisLost(true);
        }
    }
}