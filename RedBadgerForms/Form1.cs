using System.Windows.Forms;

namespace RedBadgerForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void GenerateGridButton_Click(object sender, EventArgs e)
        {
            int minCoordinate = 0;
            int maxCoordinate = 50;
            if (maxYCoordinateTextBox.Text.Length > 0 && maxXCoordinateTextBox.Text.Length > 0)
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

        bool GridExists()
        {
            return Grid.GetGridElements() != null;
        }

        private void GenerateRobotButton_Click(object sender, EventArgs e)
        {
            if (!GridExists())
            {
                return;
            }

            int x = int.Parse(RobotXCoordinateTextBox.Text);
            int y = int.Parse(RobotYCoordinateTextBox.Text);

         
            char robotOrientation = Char.Parse(RobotOrientationTextBox.Text);
            Robot robot = new Robot(robotOrientation, new Point(x, y));
            if (x > int.Parse(maxXCoordinateTextBox.Text) -1 ||
                y > int.Parse(maxYCoordinateTextBox.Text) -1)
               
            {
                FinalCoordinatesTextBox.Text = robot.GetCoordinates().X + ", " + robot.GetCoordinates().Y + " LOST";
                FinalOrientationTextBox.Text = robot.GetOrientation().ToString().ToUpper();
                return;
            }
            Grid.GetGridElements()[x, y].SetRobotInElement(robot);
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