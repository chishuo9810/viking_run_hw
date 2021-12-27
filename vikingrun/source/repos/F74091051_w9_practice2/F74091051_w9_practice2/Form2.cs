using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74091051_w9_practice2
{
    public partial class Form2 : Form
    {
        Label[,] l = new Label[10, 4];
        public Form2()
        {
            InitializeComponent();
        
        }
        int h = 0,count=0,rnd;

        private void Form2_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    l[i, j] = new Label();
                    l[i, j].BackColor = Color.Blue;
                    l[i, j].Width = 80;
                    l[i, j].Height = 20;
                    l[i, j].Location = new Point(440 - j * 85,270 - i*25);
                    l[i, j].Visible = false;
                    Controls.Add(l[i, j]);
                }
            }
        }
        public void change_invisible()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {                   
                    l[i, j].Visible = false;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            h = trackBar1.Value;
        }
       
        Random r = new Random();
        public void change(int a,int b,int c,int d)
        {
            try
            {
                for (int i = a - 1; i >= 0; i--)
                {
                    l[i, 0].Visible = true;
                }
                for (int i = b - 1; i >= 0; i--)
                {
                    l[i, 1].Visible = true;
                }
                for (int i = c - 1; i >= 0; i--)
                {
                    l[i, 2].Visible = true;
                }
                for (int i = d - 1; i >= 0; i--)
                {
                    l[i, 3].Visible = true;
                }
            }
            catch { };
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                change_invisible();
                change(r.Next(h+2), r.Next(h+2), r.Next(h+2), r.Next(h+2));
                count = 0;
                //rnd = r.Next(h + 2);
            }
        }
    }
}