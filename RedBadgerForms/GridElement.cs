namespace RedBadgerForms
{
    public class GridElement : PictureBox
    {
        private bool hasScent = false;
        private Point coodinates;
        Robot robotInElement;
        public GridElement(Point coodinates, Size size)
        {
            this.coodinates = coodinates;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.Fixed3D;
            Size = size;
        }
        
        public void SetHasScent(bool hasScent)
        {
            this.hasScent = hasScent;
        }

        public bool GetHasScent()
        {
            return hasScent;
        }

        public void SetRobotInElement(Robot robot)
        {
            robotInElement = robot;

            switch (robotInElement.GetOrientation().ToString().ToUpper())
            {
                case "N":
                    BackgroundImage = Resource1.arrowN;
                    break;
                case "E":
                    BackgroundImage = Resource1.arrowE;
                    break;
                case "S":
                    BackgroundImage = Resource1.arrowS;
                    break;
                case "W":
                    BackgroundImage = Resource1.arrowW;
                    break;
            }
        } 

        public Robot GetRobotInElement()
        {
            return robotInElement;
        }
    }
}
