using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OppoCraft
{
    public class Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /*
         * Class Methods
         */

        public double Distance(Coordinates b)
        {
            return Math.Sqrt(Math.Pow(b.X - this.X, 2) + Math.Pow(b.Y - this.Y, 2));            
        }

        public Coordinates MidPoint(Coordinates pointB)
        {
            int midX = (int)Math.Round((double)((this.X + pointB.X) / 2), 0);
            int midY = (int)Math.Round((double)((this.Y + pointB.Y) / 2), 0);

            return new Coordinates(midX, midY);
        }

        #region Properties 

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        #endregion

    }
}
