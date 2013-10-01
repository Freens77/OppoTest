using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace OppoCraft
{
    public class Grid
    {
        private Game theGame;

        private Coordinates gridSize;
        public Coordinates cellSize;        
        private int[,] gridValues;

        
     //Constructor
        public Grid(Game g)
        {


            this.theGame = g;

            this.cellSize = new Coordinates(40, 24);
            this.gridSize = new Coordinates(24, 24);

            this.setGridValues();
        }
        
        //Converts logical (Grid) coordinates into actual (pixels) coordinates
        public Coordinates getActCoords(Coordinates lc)
        {
            Coordinates actCoords = new Coordinates(lc.X * this.cellSize.X, lc.Y * this.cellSize.Y);            
            return actCoords;
        }

        //Converts actual (pixels) coordinates into logical (Grid) coordinates
        public Coordinates getLogicalCoords(Coordinates ac)
        {
            Coordinates logCoords = new Coordinates(ac.X / this.cellSize.X, ac.Y / this.cellSize.Y);
            return logCoords;
        }

        //Set Grid Values **Currently all are zero
        public void setGridValues()
        {
            this.gridValues = new int[this.gridSize.X, this.gridSize.Y];

            for (int x = 0; x < this.gridSize.X; x++)
            {
                for (int y = 0; y < this.gridSize.Y; y++)
                {
                    this.gridValues[x, y] = 0;
                }
            }
        }

        //Draw the Grid to the Panel (GamePanel) graphics
        public void RenderGrid(Graphics g)
        {            
            Pen p = new Pen(Color.Black);

            for (int x = 0; x < this.gridSize.X; x++)
            {
                for (int y = 0; y < this.gridSize.Y; y++)
                {
                    g.DrawRectangle(p, x * this.cellSize.X, y * this.cellSize.Y, this.cellSize.X, this.cellSize.Y);
                }
            }
        }

    }
}
