using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agiltpong
{
    public partial class Form1 : Form
    {
        int bollx = 5;
        int bolly = 5;
        int EnemyScore = 0;
        int PlayerScore = 0;
        int speed = 5;
        bool goup;
        bool godown;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Spelare.Text = "" + PlayerScore;
            Motståndare.Text = "" + EnemyScore;

            boll.Top -= bolly;
            boll.Left -= bollx;

            platta2.Top += speed;

            if (PlayerScore < 5)
            {
                if (platta2.Top < 0 || platta2.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                platta2.Top = boll.Top + 30;
            }

            if (boll.Left < 0)
            {
                boll.Left = 434;
                bollx = -bollx;
                bollx -= 2;
                EnemyScore++;
            }

            if (boll.Left + boll.Width > ClientSize.Width)
            {
                boll.Left = 434;
                bollx = -bollx;
                bollx += 2;
                PlayerScore++;
            }

            if (boll.Top < 0 || boll.Top + boll.Height > ClientSize.Height)
            {
                bolly = -bolly;
            }

            if (boll.Bounds.IntersectsWith(platta.Bounds) || boll.Bounds.IntersectsWith(platta2.Bounds))
            {
                bollx = -bollx;
            }

            if (goup == true && platta.Top > 0)
            {
                platta.Top -= 8;

            }

            if (godown == true && platta.Top < 455)
            {
                platta.Top += 8;
            }

            if (PlayerScore > 10)
            {
                pongtimer.Stop();
                MessageBox.Show("You win this game");
            }

        }
    }
}
