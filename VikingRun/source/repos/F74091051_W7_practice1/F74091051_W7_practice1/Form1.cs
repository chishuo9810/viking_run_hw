using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74091051_W7_practice1
{
    public partial class Form1 : Form
    {
        Label[,] grids = new Label[6, 4];
        int tool = 0;
        double sec;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;  
            this.FormBorderStyle = FormBorderStyle.Fixed3D;  
        }


        private void easy_button_Click(object sender, EventArgs e)
        {
            point_label.Visible = true;
            number_label.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            easy_button.Visible = false;
            normal_button.Visible = false;
            //Random rnd = new Random();
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 4; j++)
                {
                    grids[i, j] = new Label();
                    grids[i, j].Width = 30;
                    grids[i, j].Height = 30;
                    grids[i, j].BorderStyle = BorderStyle.FixedSingle;
                    grids[i, j].BackColor = Color.Pink;
                    grids[i, j].Left = 100 + 30 * j;
                    grids[i, j].Top = 250 - i * 30;
                    grids[i, j].Visible = false;
                    grids[i, j].Text = "0";
                    grids[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(grids[i, j]);
                }
            int n;
            n = rnd.Next(3);
            switch (n)
            {
                case 0:
                    number_label.Text = "2";
                    break;
                case 1:
                    number_label.Text = "4";
                    break;
                case 2:
                    number_label.Text = "8";
                    break;
            }
        }
        public void put(int j)
        {
            for (int i = 5; i > -1; i--)
            {
                if (grids[i, j].Text == "0" && i != 0)
                {
                    ;
                }
                else if (grids[i, j].Text == number_label.Text)
                {
                    //grids[i, j].Text = (int.Parse(grids[i, j].Text) * 2).ToString();
                    number_label.Text= (int.Parse(grids[i, j].Text) * 2).ToString();
                    grids[i, j].Text = "0";
                    put(j);
                    break;
                }
                else if (i == 0 && grids[i, j].Text == "0")
                {
                    grids[i, j].Text = number_label.Text;
                    break;
                }
                else if (grids[i, j].Text != number_label.Text)
                {
                    if (i == 5)
                    {
                        timer1.Enabled = false;
                        //MessageBox.Show("遊戲結束!!!\n\r你的分數:"+point_label.Text, "", MessageBoxButtons.OK);
                        DialogResult re=MessageBox.Show("遊戲結束!!!\n\r你的分數:" + point_label.Text, "", MessageBoxButtons.OK);
                        
                        if (re == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        grids[i + 1, j].Text = number_label.Text;
                    }
                    break;
                }

            }
        }
        public void visible()
        {
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (grids[i, j].Text == "0")
                        grids[i, j].Visible = false;
                    else
                        grids[i, j].Visible = true;
                }
            }
        }
        public void check()
        {
            for(int i = 0; i < 6; i++)
            {
               
                if (grids[i,0].Text==grids[i,1].Text&& grids[i, 0].Text == grids[i, 2].Text&& grids[i, 0].Text== grids[i, 3].Text && grids[i, 0].Text != "0")
                {
                    point_label.Text = (int.Parse(point_label.Text) + int.Parse(grids[i, 0].Text)* int.Parse(grids[i, 0].Text)).ToString();
                    for(int j = i; j < 5; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            grids[j, k].Text = grids[j + 1, k].Text;
                        }
                    }
                    for(int l = 0; l < 4; l++)
                    {
                        grids[5, l].Text = "0";
                    }
                    if (i != 0) {
                        for (int j = 0; j < 4; j++)
                        {
                            if (grids[i, j].Text == grids[i - 1, j].Text)
                            {
                                for(int o = i; o > 0; o--)
                                {
                                    if (grids[o, j].Text == grids[o - 1, j].Text)
                                    {
                                        grids[o - 1, j].Text = (int.Parse(grids[o - 1, j].Text) * 2).ToString();
                                        for(int p = o; p <= 5; p++)
                                        {
                                            if (p == 5)
                                            {
                                                grids[p, j].Text = "0";
                                            }
                                            else
                                            {
                                                grids[p, j].Text = grids[p + 1, j].Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    i = -1;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string a = number_label.Text;
            if (tool == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        number_label.Text = "2";
                        break;
                    case Keys.S:
                        number_label.Text = "4";
                        break;
                    case Keys.D:
                        number_label.Text = "8";
                        //grids[1, 0].Text = "f";

                        break;
                    case Keys.Q:
                        put(0);
                        check();
                        number_label.Text = a;
                        visible();
                        break;
                    case Keys.W:
                        put(1);
                        check();
                        number_label.Text = a;
                        visible();
                        break;
                    case Keys.E:
                        put(2);
                        check();
                        number_label.Text = a;
                        visible();
                        break;
                    case Keys.R:
                        put(3);
                        check();
                        number_label.Text = a;
                        visible();
                        break;
                }
            }
            else if (tool == 1)
            {
                
                switch (e.KeyCode)
                {
                    case Keys.Q:
                        put(0);
                        check();
                        number_label.Text = a;
                        visible();
                        sec = 3;
                        break;
                    case Keys.W:
                        put(1);
                        check();
                        number_label.Text = a;
                        visible();
                        sec = 3;
                        break;
                    case Keys.E:
                        put(2);
                        check();
                        number_label.Text = a;
                        visible();
                        sec = 3;
                        break;
                    case Keys.R:
                        put(3);
                        check();
                        number_label.Text = a;
                        visible();
                        sec = 3;
                        break;
                }
                int c;
                c = rnd.Next(3);
                switch (c)
                {
                    case 0:
                        number_label.Text = "2";
                        break;
                    case 1:
                        number_label.Text = "4";
                        break;
                    case 2:
                        number_label.Text = "8";
                        break;
                }
            }
        }

        private void normal_button_Click(object sender, EventArgs e)
        {
            
            tool = 1;
            point_label.Visible = true;
            number_label.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            easy_button.Visible = false;
            normal_button.Visible = false;
            
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 4; j++)
                {
                    grids[i, j] = new Label();
                    grids[i, j].Width = 30;
                    grids[i, j].Height = 30;
                    grids[i, j].BorderStyle = BorderStyle.FixedSingle;
                    grids[i, j].BackColor = Color.Pink;
                    grids[i, j].Left = 100 + 30 * j;
                    grids[i, j].Top = 250 - i * 30;
                    grids[i, j].Visible = false;
                    grids[i, j].Text = "0";
                    grids[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(grids[i, j]);
                }
            int n;
            n = rnd.Next(3);
            switch (n)
            {
                case 0:
                    number_label.Text = "2";
                    break;
                case 1:
                    number_label.Text = "4";
                    break;
                case 2:
                    number_label.Text = "8";
                    break;
            }
            sec = 3;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (sec -= 0.1).ToString("#0.0");
            if (sec <= 0)
            {
                put(1);
                check();
                visible();
                int c;
                c = rnd.Next(3);
                switch (c)
                {
                    case 0:
                        number_label.Text = "2";
                        break;
                    case 1:
                        number_label.Text = "4";
                        break;
                    case 2:
                        number_label.Text = "8";
                        break;
                }
                sec = 3;
            }
        }
    }
}
