using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OppoCraft
{
    class UnitCollection : List<Unit>
    {
        Game theGame;
        private Object renderLock = new Object();
        private Object tickLock = new Object();


        public UnitCollection(Game g)
        {
            this.theGame = g;
        }

        public void Tick()
        {            
            foreach (Unit unit in this.ToList())
            {
                unit.Tick();
            }
        }

        public void Render(Graphics g)
        {           
            foreach (Unit unit in this.ToList())
            {
                unit.Render(g);              
            }
        }

    }
}
