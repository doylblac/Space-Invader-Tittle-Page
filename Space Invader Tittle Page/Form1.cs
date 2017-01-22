using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invader_Tittle_Page
{
    public partial class Form1 : Form
    {
        int page = 0;

        List<int> highScores = new List<int>();

        int score = 20001;

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(500, 480);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            highScores.Add(240);
            highScores.Add(6310);
            highScores.Add(5710);
            highScores.Add(9750);
            highScores.Add(4540);
            highScores.Add(50975);
            highScores.Add(45240);
            highScores.Add(205);
            highScores.Add(60);
            highScores.Add(5870);
            highScores.Add(6520);
            highScores.Add(40);
            highScores.Add(30);
            highScores.Add(20);
            highScores.Add(10);
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            playGameButton.Visible = false;
            highScoreButton.Visible = false;

        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font bigFont = new Font("Consolas", 20, FontStyle.Bold); //create a font for graphics
            Font smallFont = new Font("Consolas", 13, FontStyle.Bold); //create a font for graphics
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen); //create a brush for graphics
            SolidBrush whiteBrush = new SolidBrush(Color.White); //create a brush for graphics

            highScoreButton.Visible = false;

            g.Clear(Color.Black);

            highScores.Add(score);
            highScores.Sort();
            highScores.Reverse();

            int y = 80;

            for (int i = 0; i < 10; i++)
            {
                g.DrawString("HIGH SCORES", bigFont, greenBrush, 150, 50);
                g.DrawString("" + highScores[i], smallFont, whiteBrush, 150, y);
                y = y + 20;
            }
        }

    }
}