using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace folowthemousexy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int px = 500;
        int py = 500;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            timer1.Start();
        }

        public float distantaintredouapuncte2dxy(float x1, float y1, float x2, float y2)
        {
            float c;
            c = (float)Math.Sqrt(Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2));
            return c;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left < px)
            {
                button1.Left -= (button1.Left - px)/10;
                // button1.Top -= (button1.Top - py)/10;
            }
            if (button1.Left > px)
            {
                button1.Left -= (button1.Left - px) / 10;
                // button1.Top -= (button1.Top - py) / 10;
            }
            if (button1.Top < py)
            {
                // button1.Left -= (button1.Left - px) / 10;
                button1.Top -= (button1.Top - py) / 10;
            }
            if (button1.Top > py)
            {
                // button1.Left -= (button1.Left - px) / 10;
                button1.Top -= (button1.Top - py) / 10;
            }

            Text = distantaintredouapuncte2dxy((float)px, (float)py, (float)button1.Left, (float)button1.Top).ToString();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            timer1.Start();
        }
    }
}
