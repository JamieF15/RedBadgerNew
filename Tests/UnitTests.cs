using RedBadgerForms;
using System.Drawing;
using System.Windows.Forms;
namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        void CreateTestGrid(GridElement[,] gridElements, int x, int y)
        {
            int gridElementSize = 70;
            int startingXLocation = 0;
            int startingYLocation = 800;
            int currentXLocaiton;
            int currentYLocaiton = startingYLocation;

            for (int i = 0; i < x; i++)
            {
                currentYLocaiton -= gridElementSize;
                currentXLocaiton = startingXLocation;

                for (int j = 0; j < y; j++)
                {
                    GridElement gridElement = new GridElement(new Point(i, j), new Size(gridElementSize, gridElementSize));
                    gridElement.Location = new Point(currentXLocaiton, currentYLocaiton);

                    gridElements[i, j] = gridElement;
                    currentXLocaiton += gridElementSize;
                }
            }
        }

        [TestMethod]
        public void GridElementExists()
        {
            int x = 10; int y = 10;

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);
        }

        [TestMethod]
        public void RobotOrientationIsCorrect()
        {
            Robot robot = new Robot('N',new Point(0, 0));
            Assert.AreEqual(robot.GetOrientation(), 'N');

            robot = new Robot('E', new Point(0, 0));
            Assert.AreEqual(robot.GetOrientation(), 'E');

            robot = new Robot('S', new Point(0, 0));
            Assert.AreEqual(robot.GetOrientation(), 'S');

            robot = new Robot('W', new Point(0, 0));
            Assert.AreEqual(robot.GetOrientation(), 'W');
        }

        [TestMethod]
        public void RobotCanMoveRight()
        {
            int x = 10; int y = 10;
            Point robotCoordinates = new Point(1, 1);

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Robot robot = new Robot('N', robotCoordinates);

            Grid.SetGridElements(gridElements);

            Assert.AreEqual(robot.GetOrientation(), 'N');
            robot.MoveRight();

            Assert.AreEqual(robot.GetOrientation(), 'E');

            robot.MoveRight();
            Assert.AreEqual(robot.GetOrientation(), 'S');

            robot.MoveRight();
            Assert.AreEqual(robot.GetOrientation(), 'W');
        }

        [TestMethod]
        public void RobotCanMoveForward()
        {
            int x = 10; int y = 10;
            Point startingRobotCoordinates = new Point(1, 1);

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Robot robot = new Robot('N', startingRobotCoordinates);

            Grid.SetGridElements(gridElements);

            gridElements[1, 1].SetRobotInElement(robot);

            Assert.AreEqual(startingRobotCoordinates.Y,
                Grid.GetGridElements()[1, 1].GetRobotInElement().GetCoordinates().X);

            Grid.GetGridElements()[1, 1].GetRobotInElement().MoveForward();

            Assert.AreNotEqual(startingRobotCoordinates.Y, 
                Grid.GetGridElements()[1, 1].GetRobotInElement().GetCoordinates().X);
        }

        [TestMethod]
        public void RobotIsInGridElement()
        {
            int x = 10; int y = 10;
            Point robotCoordinates = new Point(1, 1);

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Robot robot = new Robot('N', robotCoordinates);

            gridElements[1, 1].SetRobotInElement(robot);

            Assert.IsNotNull(gridElements[1, 1].GetRobotInElement());
        }

        [TestMethod]
        public void RobotCanBeSetAsLost()
        {
            int x = 10; int y = 10;

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Robot robot = new Robot('N', new Point(1, 1));
            
            gridElements[1, 1].SetRobotInElement(robot);
            Assert.IsFalse(gridElements[1, 1].GetRobotInElement().GetIsLost());

            gridElements[1, 1].GetRobotInElement().SetisLost(true);

            Assert.IsTrue(gridElements[1, 1].GetRobotInElement().GetIsLost());
        }

        [TestMethod]
        public void RobotCoordinatesAreCorrectWhenInGrid()
        {
            int x = 10; int y = 10;
            Point robotCoordinates = new Point(5, 5);
            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Robot robot = new Robot('N', robotCoordinates);

            gridElements[1, 1].SetRobotInElement(robot);
            
            Assert.AreEqual( gridElements[1, 1].GetRobotInElement().GetCoordinates(), robotCoordinates);

        }

        [TestMethod]
        public void BackgroundImageCanBeSet()
        {        
            int x = 10; int y = 10;

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Robot robot = new Robot('N', new Point(1, 1));

            Assert.IsNull(gridElements[1, 1].BackgroundImage);

            gridElements[1, 1].SetRobotInElement(robot);

            Assert.IsNotNull(gridElements[1, 1].BackgroundImage);
        }

        [TestMethod]
        public void GridElementHasScentCanBeSet()
        {
            int x = 10; int y = 10;

            GridElement[,] gridElements = new GridElement[x, y];
            CreateTestGrid(gridElements, x, y);

            gridElements[1, 1] = new GridElement(new Point(0, 0), new Size(new Point(50, 50)));

            Assert.IsNotNull(gridElements[1, 1]);

            Assert.IsFalse(gridElements[1, 1].GetHasScent());

            gridElements[1, 1].SetHasScent(true);

            Assert.IsTrue(gridElements[1, 1].GetHasScent());
        }
    }
}