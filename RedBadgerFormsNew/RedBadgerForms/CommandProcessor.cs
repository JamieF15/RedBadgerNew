namespace RedBadgerForms
{
    internal class CommandProcessor
    {
        public static void ProcessCommand(string command, Robot robot, TextBox finalCoordinates, TextBox finalOrientation)
        {
            if (robot.GetIsLost())
            {
                return;
            }

                for (int i = 0; i < command.Length; i++)
            {
                switch (command[i].ToString().ToUpper()) {
                    case "N":
                        robot.SetOrientation(command[i]);
                        continue;
                    case "E":
                        robot.SetOrientation(command[i]);
                        continue;
                    case "S":
                        robot.SetOrientation(command[i]);
                        continue;
                    case "W":
                        robot.SetOrientation(command[i]);
                        continue;
                    case "L":
                        robot.MoveLeft();
                        continue;
                    case "R":
                        robot.MoveRight();
                        continue;
                    case "F":
                        robot.MoveForward();
                        continue;
                }
            }

            if (robot.GetIsLost())
            {
                finalCoordinates.Text = robot.GetCoordinates().X + ", " + robot.GetCoordinates().Y + " LOST";
                finalOrientation.Text = robot.GetOrientation().ToString().ToUpper();

                return;
            }

            finalCoordinates.Text = robot.GetCoordinates().X + ", " + robot.GetCoordinates().Y;
            finalOrientation.Text = robot.GetOrientation().ToString().ToUpper();
        }
    }
}
