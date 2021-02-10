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
        int bolly = 8;
        int EnemyScore = 0;
        int PlayerScore = 0;
        bool game = false;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                startText.Visible = false;
                game = true;
            }
        }

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
        }

        private void npc_move(int bolly, int bollx)
        {
            if (bolly > 0 && ((platta2.Top + platta.Size.Width) >= boll.Top))
            {
                platta2.Top -= Math.Abs(bollx / 2 - (bollx / 4));
            }
            if (bolly < 0 && ((platta2.Top + platta.Size.Width) < boll.Top))
            {
                platta2.Top += Math.Abs(bollx / 2 - (bollx / 4));
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //int x = platta.Location.X;
            //int y = platta.Location.Y;


            //if (e.KeyCode == Keys.Up) y -= 20;
            //if (e.KeyCode == Keys.Down) y += 20;

            //platta.Location = new Point(x, y);
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

        }

        private void timerTick(object sender, EventArgs e)
        {
            if (game == true)
            {
                Spelare.Text = "" + PlayerScore;
                Motståndare.Text = "" + EnemyScore;
                t.Start();

                boll.Top -= bolly;
                boll.Left -= bollx;

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

                if (PlayerScore > 10)
                {
                    pongtimer.Stop();
                    t.Stop();
                    youWin.Visible = true;
                }

                if (EnemyScore == 10)
                {
                    pongtimer.Stop();
                    t.Stop();
                    youLose.Visible = true;
                }

                npc_move(bolly, bollx);    // Call the move function for the npc with the ballposition
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