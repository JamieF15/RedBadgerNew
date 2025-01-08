This is a program that follow the following requirements: Coding_Challenge_2018.pdf.

This project was written in C# with unit testing done in MSTest as both the frameworks integrate well together and with the IDE I am using, Visual Studeo 2022.

In this interpreation of the problem, the robot is denoted with an arrow, showing which direction it is oriented in. When a grid space has a 'scent', it is shown by the tile becoming green.

To start, create a grid using the text boxes to specify its size. The bottom-left has the coordinates 0,0 so the top-right would be 1 less than what is inputted into the text boxes to generate the grid.

when the grid is created, create a robot by choosing the coordinates and inital orientation to place it in.

When the robot is created, send a command to it. When the command is completed or when the robot is lost due to the command, its last coordiantes and origentation will be shown on the furthest right text boxes.
