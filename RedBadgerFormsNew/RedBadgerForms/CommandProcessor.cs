namespace RedBadgerForms
{
    internal class CommandProcessor
    {
        public static void ProcessCommand(string command, Robot robot)
        {
            for (int i = 0; i < command.Length; i++)
            {
                switch(command[i].ToString().ToUpper()) {
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
        }
    }
}
