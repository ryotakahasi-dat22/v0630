using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10, 11);
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(0, ClientSize.Width- label1.Width);
            label1.Top = rand.Next(0, ClientSize.Height-label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;
            {
                label4.Left += vx;
                label4.Top += vy;
                if (label4.Left < 0)
                {
                    vx = -vx;
                }
                if (label4.Top < 0)
                {
                    vy = -vy;
                }
                if (label4.Right > ClientSize.Width)
                {
                    vx = -vx;
                }
                if (label4.Bottom > ClientSize.Height)
                {
                    vy = -vy;
                    if ((fpos.X >= label4.Left)
                        && (fpos.X < label4.Right)
                        && (fpos.Y >= label4.Top)
                        && (fpos.Y < label4.Bottom)
                        )
                    {
                        timer1.Enabled = false;
                    }
                }
            }
            {
                label3.Left += vx;
                label3.Top += vy;
                if (label3.Left < 0)
                {
                    vx = -vx;
                }
                if (label3.Top < 0)
                {
                    vy = -vy;
                }
                if (label3.Right > ClientSize.Width)
                {
                    vx = -vx;
                }
                if (label3.Bottom > ClientSize.Height)
                {
                    vy = -vy;
                    if ((fpos.X >= label3.Left)
                        && (fpos.X < label3.Right)
                        && (fpos.Y >= label3.Top)
                        && (fpos.Y < label3.Bottom)
                        )
                    {
                        timer1.Enabled = false;
                    }
                }
            }
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                vx = -vx;
            }
            if (label1.Top < 0)
            {
                vy = -vy;
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -vx;
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -vy;
                if ((fpos.X >= label1.Left)
                    && (fpos.X < label1.Right)
                    && (fpos.Y >= label1.Top)
                    && (fpos.Y < label1.Bottom)
                    )
                {
                    timer1.Enabled = false;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
