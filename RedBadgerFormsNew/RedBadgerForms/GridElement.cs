namespace RedBadgerForms
{
    internal class GridElement : PictureBox
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
            BackgroundImage = Image.FromFile(@"C:\Users\Jamie\Desktop\RedBadgerForms\RedBadgerForms\bin\Debug\net8.0-windows\arrow"
                + robotInElement.GetOrientation().ToString().ToUpper() + ".png");
        } 

        public Robot getRobotInElement()
        {
            return robotInElement;
        }
        public Point GetCoordinates()
        {
            return coodinates;
        }

        public void SetCoordinates(Point coodinates)
        {
            this.coodinates = coodinates;
        }   
    }
}
