This program follows these requirements: [Coding_Challenge_2018.pdf](https://github.com/user-attachments/files/17903900/Coding_Challenge_2018.pdf)

This project was written in C#, with unit testing done in MSTest, as both frameworks integrate well with the IDE I am using, Visual Studio 2022.

In this interpretation of the challenge, the robot is denoted with an arrow, showing which direction it is oriented in. When a grid space has a 'scent', it is shown by the tile becoming green.

To start, create a grid using the text boxes to specify its size. The bottom left has the coordinates 0,0, so the top right would be 1 less than what is inputted into the text boxes to generate the grid.

when creating the grid, create a robot by choosing the coordinates and initial orientation to place it in.

When the robot is created, send a command to it. When the command is completed or when the robot is lost due to the command, its last coordinates and orientation will be shown on the furthest right text boxes.

There may be more room to add more unit testing, and potentially fix some linting issues, as well. 
