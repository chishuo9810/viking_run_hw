using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74091051_W8_practice2
{
    public partial class Form1 : Form
    {
        Character P1 = new Character();
        Character P2 = new Character();
        public Form1()
        {
            InitializeComponent();
        }
        chess[,] ch = new chess[19, 19];
        int who = 0;
        //Button[,] Go_board = new Button[19, 19];
        private void chess_click(object sender, EventArgs e)
        {
            who++;
            chess chref = (chess)sender;
            btn_nenable();
            if (who % 2 == 1)
            {
                switch (P1_lb.Text)
                {
                    case "戰士":                                          
                        chref.deep_sky_blue();
                        btn_nenable();
                        // ch[chref.row + 1, chref.col ].BackColor = Color.DeepSkyBlue;
                        break;
                    case "法師":
                        chref.dark_blue();
                        break;
                    case "弓箭手":
                        chref.blue_violet();
                        break;
                }            
            }
            if (who % 2 == 0)
            {
                switch (P2_lb.Text)
                {
                    case "戰士":
                        chref.orange();
                        break;
                    case "法師":
                        chref.dark_orange();
                        break;
                    case "弓箭手":
                        chref.orange_red();
                        break;
                }
            }
        }
        public void btn_enable()
        {
            for(int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    ch[i, j].Enabled = true;
                }
            }
        }
        public void btn_nenable()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (ch[i, j].BackColor != Color.Gray)                   
                        ch[i, j].Enabled = false;
                    
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            P1 = new Warrior();
            P2 = new Warrior();
            P2.numD += 1;
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            p1_row_lb.Visible = true;
            p1_col_lb.Visible = true;
            p1_cover_lb.Visible = true;
            p2_row_lb.Visible = true;
            p2_col_lb.Visible = true;
            p2_cover_lb.Visible = true;
            p1_warrior_btn.Visible = false;
            p1_witcher_btn.Visible = false;
            p1_archer_btn.Visible = false;
            p2_archer_btn.Visible = false;
            p2_warrior_btn.Visible = false;
            p2_witcher_btn.Visible = false;
            start_btn.Visible = false;
            p1_normal_btn.Visible = true;
            p1_row_btn.Visible = true;
            p1_col_btn.Visible = true;
            p1_cover_btn.Visible = true;
            p2_normal_btn.Visible = true;
            p2_row_btn.Visible = true;
            p2_col_btn.Visible = true;
            p2_cover_btn.Visible = true;
            if (P2_lb.Text == "戰士")
            {
                P2 = new Warrior();
                P2.numD += 1;
                p2_cover_lb.Text = "6";
            }
            if (P2_lb.Text == "法師")
            {
                P2 = new Witcher();
                P2.numD += 1;
                p2_row_lb.Text = "1";
                p2_col_lb.Text = "2";
                p2_cover_lb.Text = "3";
            }
            if (P2_lb.Text == "弓箭手")
            {
                P2 = new Archer();
                P2.numD += 1;
                p2_row_lb.Text = "1";
                p2_col_lb.Text = "1";
                p2_cover_lb.Text = "4";
            }
            if (P1_lb.Text == "戰士")
            {
                P1 = new Warrior();
                p1_cover_lb.Text = "5";
            }
            if (P1_lb.Text == "法師")
            {
                P1 = new Witcher();
                p1_row_lb.Text = "1";
                p1_col_lb.Text = "2";
                p1_cover_lb.Text = "2";
            }
            if (P1_lb.Text == "弓箭手")
            {
                P1 = new Archer();
                p1_row_lb.Text = "1";
                p1_col_lb.Text = "1";
                p1_cover_lb.Text = "3";
            }
            check_the_chess();
            for (int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    ch[i, j] = new chess();
                    ch[i, j].col = j;
                    ch[i, j].row = i;
                    ch[i, j].Width = 21;
                    ch[i, j].Height = 21;
                    ch[i, j].BackColor = Color.Gray;
                    ch[i, j].Click += chess_click;
                    ch[i, j].Location = new Point(200+21*j, 100+21*i);
                    Controls.Add(ch[i, j]);
                }
            }
            
        }

        private void p1_warrior_btn_Click(object sender, EventArgs e)
        {
            P1_lb.Text = "戰士";
        }

        private void p1_witcher_btn_Click(object sender, EventArgs e)
        {
            P1_lb.Text = "法師";
        }

        private void p1_archer_btn_Click(object sender, EventArgs e)
        {
            P1_lb.Text = "弓箭手";
        }

        private void p2_warrior_btn_Click(object sender, EventArgs e)
        {
            P2_lb.Text = "戰士";
        }

        private void p2_witcher_btn_Click(object sender, EventArgs e)
        {
            P2_lb.Text = "法師";
        }

        private void p2_archer_btn_Click(object sender, EventArgs e)
        {
            P2_lb.Text = "弓箭手";
        }
        public void check_the_chess()
        {
            if (p2_row_lb.Text == "0")
            {
                p2_row_btn.Enabled = false;
            }
            if (p2_col_lb.Text == "0")
            {
                p2_col_btn.Enabled = false;
            }
            if (p2_cover_lb.Text == "0")
            {
                p2_cover_btn.Enabled = false;
            }
            if (p1_row_lb.Text == "0")
            {
                p1_row_btn.Enabled = false;
            }
            if (p1_col_lb.Text == "0")
            {
                p1_col_btn.Enabled = false;
            }
            if (p1_cover_lb.Text == "0")
            {
                p1_cover_btn.Enabled = false;
            }
        }

        private void p2_normal_btn_Click(object sender, EventArgs e)
        {
            p2_re.Text = "a";
            btn_nenable();
        }

        private void p2_row_lb_Click(object sender, EventArgs e)
        {
            p2_re.Text = "b";
            btn_nenable();
        }

        private void p2_col_btn_Click(object sender, EventArgs e)
        {
            p2_re.Text = "c";
            btn_nenable();
        }

        private void p2_cover_btn_Click(object sender, EventArgs e)
        {
            p2_re.Text = "d";
            btn_enable();
        }

        private void p1_normal_btn_Click(object sender, EventArgs e)
        {
            p1_re.Text = "a";
            btn_nenable();
        }

        private void p1_row_btn_Click(object sender, EventArgs e)
        {
            p1_re.Text = "b";
            btn_nenable();
        }

        private void p1_col_btn_Click(object sender, EventArgs e)
        {
            p1_re.Text = "c";
            btn_nenable();
        }

        private void p1_cover_btn_Click(object sender, EventArgs e)
        {
            p1_re.Text = "d";
            btn_enable();
        }
    }
}
