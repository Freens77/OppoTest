using System.Drawing;

namespace OppoCraft
{
    partial class Game
    {
        private System.Windows.Forms.Panel GamePanel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.White;
            this.GamePanel.Location = new System.Drawing.Point(141, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(960, 576);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseDown);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.GamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OppoCraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);            
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}

