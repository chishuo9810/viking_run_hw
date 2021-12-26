using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace F74091051_W8_practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int row, col;
        int count_tm=0;
        int click=0;
        int num1, num2;
        int half,rmc=0;
        Card [,]cards;

        private void card_Click(object sender, EventArgs e)
        {
            click++;
            Card cardRef = (Card)sender;
            cardRef.showNumber();
            if (click == 1)
            {
                num1=cardRef.number;
            }
            else if (click == 2)
            {
                num2 = cardRef.number;
                click = 0;
                if (num2 <= num1)
                {
                    see_card_tm.Enabled = true;
                }
                else if (num2 > num1)
                {
                    see_card_tm.Enabled = true;
                }               
            }
        }
        private void remember_card_tm_Tick(object sender, EventArgs e)
        {
            count_tm++;
            if (count_tm == 2&&num2<=num1)
            {
                for(int i = 0; i < row; i++)
                {
                    for (int j=0; j < col; j++)
                    {
                        cards[i, j].Enabled = true;
                        cards[i, j].Text = null;
                        cards[i, j].BackColor = Color.Gray;
                    }
                }
                count_tm = 0;
                remember_card_tm.Enabled = false;
            }
        }
        public void cards_enable_true()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    cards[i, j].Enabled = true;
                }
            }
        }
        public void cards_enable_false()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    cards[i, j].Enabled = false;
                }
            }
        }

        private void see_card_tm_Tick(object sender, EventArgs e)
        {
            cards_enable_false();
            count_tm++;
            if (count_tm == 20 && num2 <= num1)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        cards[i, j].Enabled = true;
                        cards[i, j].Text = null;
                        cards[i, j].BackColor = Color.Gray;
                    }
                }
                count_tm = 0;
                round_lb.Text = (int.Parse(round_lb.Text) + 1).ToString();
                if (int.Parse(round_lb.Text) % 2 == 0)
                {
                    person_lb.Text = "2";
                }
                else if (int.Parse(round_lb.Text) % 2 == 1)
                {
                    person_lb.Text = "1";
                }
                see_card_tm.Enabled = false;
            }
            else if (count_tm == 20 && num2 > num1)
            {
                rmc += 2;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (cards[i, j].Text !="")
                        {
                            Controls.Remove(cards[i, j]);                        
                        }
                        cards[i, j].Enabled = true;
                    }
                }
                count_tm = 0;
                round_lb.Text = (int.Parse(round_lb.Text) + 1).ToString();
                if (int.Parse(round_lb.Text) % 2 == 0)
                {
                    person_lb.Text = "2";
                }
                else if (int.Parse(round_lb.Text) % 2 == 1)
                {
                    person_lb.Text = "1";
                }
                if (int.Parse(person_lb.Text) % 2 == 1)
                {
                    P2_point_lb.Text = (int.Parse(P2_point_lb.Text) + num2 - num1).ToString();
                }
                else if (int.Parse(person_lb.Text) % 2 == 0)
                {
                    P1_point_lb.Text = (int.Parse(P1_point_lb.Text) + num2 - num1).ToString();
                }
                see_card_tm.Enabled = false;
            }
            if (rmc >= half)
            {
                if (int.Parse(P1_point_lb.Text) > int.Parse(P2_point_lb.Text))
                {
                    MessageBox.Show("P1獲勝", "", MessageBoxButtons.OK);
                }
                else if (int.Parse(P1_point_lb.Text) < int.Parse(P2_point_lb.Text))
                {
                    MessageBox.Show("P2獲勝", "", MessageBoxButtons.OK);
                }
                else if (int.Parse(P1_point_lb.Text) == int.Parse(P2_point_lb.Text))
                {
                    MessageBox.Show("平手", "", MessageBoxButtons.OK);
                }
                Environment.Exit(0);
            }



        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            start_btn.Visible = false;
            label1.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label9.Visible = true;
            person_lb.Visible = true;
            P1_point_lb.Visible = true;
            P2_point_lb.Visible = true;
            round_lb.Visible = true;
            string str = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            StreamReader reader = new StreamReader(str+"card.map");
            string[] input = reader.ReadLine().Split(' ');
            row = int.Parse(input[0]);
            col = int.Parse(input[1]);
            half = (row * col) / 2;
            string[,] playing_card = new string[row, col];
            cards = new Card[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] input_card = reader.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    cards[i, j] = new Card();
                    cards[i, j].number = int.Parse(input_card[j]);
                    cards[i, j].Text = input_card[j];
                    cards[i, j].Width = 40;
                    cards[i, j].Height = 40;
                    cards[i, j].Location = new Point(150+40*j, 200+40*i);
                    cards[i, j].Enabled = false;
                    cards[i, j].BackColor = Color.LightBlue;
                    cards[i, j].Click += card_Click;
                    Controls.Add(cards[i,j]);
                }
            }
            remember_card_tm.Enabled = true;
        }
    }
}
