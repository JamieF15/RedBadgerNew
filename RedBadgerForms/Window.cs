namespace RedBadgerForms
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
        }

        private void GenerateGridButton_Click(object sender, EventArgs e)
        {
            int minCoordinate = 0;
            int maxCoordinate = 50;
            int minTextBoxLength = 0;
            if (maxYCoordinateTextBox.Text.Length > minTextBoxLength && 
                maxXCoordinateTextBox.Text.Length > minTextBoxLength)
            {

                bool xIsNumber = int.TryParse(maxXCoordinateTextBox.Text, out _);
                bool yIsNumber = int.TryParse(maxYCoordinateTextBox.Text, out _);

                if (xIsNumber && yIsNumber)
                {
                    int y = int.Parse(maxYCoordinateTextBox.Text);
                    int x = int.Parse(maxXCoordinateTextBox.Text);


                    if (x >= minCoordinate &&
                        y >= minCoordinate &&
                        x <= maxCoordinate &&
                        y <= maxCoordinate)
                    {
                        Grid.Initiate(x, y, this);
                    }
                }
            }

        }
        private static bool GridExists()
        {
            return Grid.GetGridElements() != null;
        }

        private void GenerateRobotButton_Click(object sender, EventArgs e)
        {
            if (!GridExists())
            {
                return;
            }

            bool xIsNumber = int.TryParse(RobotXCoordinateTextBox.Text, out _);
            bool yIsNumber = int.TryParse(RobotYCoordinateTextBox.Text, out _);

            if (xIsNumber && yIsNumber)
            {
                int x = int.Parse(RobotXCoordinateTextBox.Text);
                int y = int.Parse(RobotYCoordinateTextBox.Text);

                char robotOrientation = Char.Parse(RobotOrientationTextBox.Text);
                Robot robot = new Robot(robotOrientation, new Point(x, y));
                if (x > int.Parse(maxXCoordinateTextBox.Text) - 1 ||
                    y > int.Parse(maxYCoordinateTextBox.Text) - 1)

                {
                    FinalCoordinatesTextBox.Text = robot.GetCoordinates().X + ", " + robot.GetCoordinates().Y + " LOST";
                    FinalOrientationTextBox.Text = robot.GetOrientation().ToString().ToUpper();
                    return;
                }
                Grid.GetGridElements()[x, y].SetRobotInElement(robot);
            }
        }
        private void SendCommandButton_Click(object sender, EventArgs e)
        {
            if (!GridExists())
            {
                return;
            }

            int x = int.Parse(RobotXCoordinateTextBox.Text);
            int y = int.Parse(RobotYCoordinateTextBox.Text);
           
            string command = sendCommandTextBox.Text;
            CommandProcessor.ProcessCommand(command, Grid.GetGridElements()[x, y].GetRobotInElement(), 
                    FinalCoordinatesTextBox, FinalOrientationTextBox);
        }
    }
}