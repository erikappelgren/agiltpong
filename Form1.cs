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

        public Form1()
        {
            InitializeComponent();
            

        }

        void keyisdown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            
             if (e.KeyCode == Keys.Up) y -= 7;
             if (e.KeyCode == Keys.Down) y += 7;

            pictureBox1.Location = new Point(x, y);
        }


    }
}
