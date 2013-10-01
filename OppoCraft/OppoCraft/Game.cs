using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace OppoCraft
{
    public partial class Game : Form
    {
        Graphics g;
        Graphics g2;
        Bitmap bmp;
        Boolean isRendering = false;

        public Grid theGrid;       

        private System.Timers.Timer theTimer;

        UnitCollection theUnits;

        //Constructor
        public Game()
        {
            this.InitializeComponent();
            
            this.g = this.GamePanel.CreateGraphics();
            this.g.Clear(Color.Black);
            this.bmp = new Bitmap(this.GamePanel.Width, this.GamePanel.Height);
            this.g2 = Graphics.FromImage(this.bmp);

            this.theGrid = new Grid(this);
            this.setTimerObj();
            this.theUnits = new UnitCollection(this);
        }

        //MouseDown Handler for Panel
        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {            
           Coordinates logCoords = this.theGrid.getLogicalCoords(new Coordinates(e.X, e.Y));

           MessageBox.Show("actCoords: X: " + e.X + ", Y: " + e.Y + "\n" + "logCoords: X: " + logCoords.X + ", Y: " + logCoords.Y);

            this.theUnits.Add(new Unit(this, logCoords, 2, Brushes.Red));
        }

        private void setTimerObj()
        {
            this.theTimer = new System.Timers.Timer(16);
            this.theTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            this.theTimer.Enabled = true;
        }
        
        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            this.Tick();
            this.Render();
        }

        public void Render()
        {
            if (this.isRendering)
            { return; }
            else
            {                
                this.isRendering = true;
                this.g2.Clear(Color.White);
                this.theGrid.RenderGrid(this.g2);
                this.theUnits.Render(this.g2);
                this.g.DrawImage(this.bmp, 0, 0);
            }
            
            this.isRendering = false;
        }

        public void Tick()
        {           
            this.theUnits.Tick();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.theTimer.Enabled = false;            
        }
           

    }
}
