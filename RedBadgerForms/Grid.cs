﻿namespace RedBadgerForms
{
    public static class Grid
    {
        private static GridElement[,] gridElements = default!;

        public static void Initiate(int x, int y, Form form)
        {
            gridElements = new GridElement[x, y];
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
                    GridElement gridElement = new GridElement(new Size(gridElementSize, gridElementSize));
                    gridElement.Location = new Point(currentXLocaiton, currentYLocaiton);

                    form.Controls.Add(gridElement);

                    gridElements[i, j] = gridElement;
                    currentXLocaiton += gridElementSize;

                }
            }
        }

        public static GridElement[,] GetGridElements() { 

            return gridElements;
        }

        public static void SetGridElements(GridElement[,] gridElementsNew)
        {
            gridElements = gridElementsNew;
        }
    }
}
