using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace OppoCraft
{
    class Unit
    {
        private Game theGame;

        private Coordinates size;
        private Coordinates logCoords; // to refactor
        private Coordinates actCoords;
        private int speed;
        
        private Brush color;
        

        public Unit(Game g, Coordinates coords, int spd, Brush color)
        {
            this.theGame = g;

            this.LogCoords = coords;
            this.ActCoords = this.theGame.theGrid.getActCoords(LogCoords);

            this.Size = new Coordinates(40, 24);
            this.Speed = spd;
            this.color = color;
        }

        public void Tick()
        {
            if (this.ActCoords.X >= 777)
            {
                return;
            }

            //this.ActCoords.X += this.Speed;         
        }

        public void Render(Graphics g)
        {            
            g.FillEllipse(this.color, this.ActCoords.X, this.ActCoords.Y, this.Size.X, this.Size.Y);
        }


        #region Class Properties

        public Coordinates Size
        {   
            get{ return this.size; }
            set{ this.size = value; }
        }

        public Coordinates LogCoords
        {
            get { return this.logCoords; }
            set { this.logCoords = value; }
        }

        public Coordinates ActCoords
        {
            get { return this.actCoords; }
            set { this.actCoords = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public Brush Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        #endregion

    }
}
