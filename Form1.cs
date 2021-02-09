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

        System.Timers.Timer t;
        int h, m, s;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 10;//1s
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        void keyisdown(object sender, KeyEventArgs e)
        {
            int x = platta.Location.X;
            int y = platta.Location.Y;


            if (e.KeyCode == Keys.Up) y -= 20;
            if (e.KeyCode == Keys.Down) y += 20;

            platta.Location = new Point(x, y);
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

            if (PlayerScore == 10)
            {
                pongtimer.Stop();
                t.Stop();
                MessageBox.Show("You win this game");
            }
            if (EnemyScore == 10)
            {
                pongtimer.Stop();
                t.Stop();
                MessageBox.Show("You lose this game");
            }
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e) 
            { 
            Invoke(new Action(() =>
                {
                    s += 1;
                    if (s == 60)
                    {
                        s = 0;
                        m += 1;
                    }
                    if (m == 60)
                    {
                        m = 0;
                        h += 1;
                    }
                    txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

                }));
        }
    }
}