using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74091051_W6_practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = -1;
        int H, W;
        Button[] newButton = new Button[150];
        Button[] newButton2 = new Button[150];

        private void enter_Click(object sender, EventArgs e)
        {
            count++;
            
            try
            {
                int h = int.Parse(height.Text);
                int w = int.Parse(width.Text);
                if (h < 7 || h > 15 || w > 10 || w < 5)
                {
                    MessageBox.Show("請輸入範圍內的數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (h % 2 != 1)
                {
                    MessageBox.Show("高不能為偶數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (count > 0)
                    {
                        for (int i = 0; i < H * W; i++)
                        {
                            Controls.Remove(newButton[i]);
                            Controls.Remove(newButton2[i]);
                        }
                    }
                    for (int i = 0,j=0; i < h*w; i++)
                    {
                        if (i % w == 0&&i!=0)
                            j++;
                        newButton[i] = new Button();
                        newButton[i].Location = new Point(190 + (200 / w) * (i % w), 14 + (280 / h) * j);
                        newButton[i].Size = new Size(200 / w, 280 / h);
                        Controls.Add(newButton[i]);
                    }
                    for (int i = 0, j = 0; i < h * w; i++)
                    {
                        if (i % w == 0&&i!=0)
                            j++;
                        newButton2[i] = new Button();
                        newButton2[i].Location = new Point(450 + (200 / w) * (i % w), 14 + (280 / h) * j);
                        newButton2[i].Size = new Size(200 / w, 280 / h);
                        Controls.Add(newButton2[i]);
                    }
                    H = h;
                    W = w;
                    number.Enabled = true;
                    number_TextChanged(sender,e);
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void number_TextChanged(object sender, EventArgs e)
        {
            if (number.Text.Length==1)
            {
                clear();
                zero();
                if (number.Text == "1")
                {
                    one2();
                }
                else if (number.Text == "2")
                {
                    two2();
                }
                else if (number.Text == "3")
                {
                    three2();
                }
                else if (number.Text == "4")
                {
                    four2();
                }
                else if (number.Text == "5")
                {
                    five2();
                }
                else if (number.Text == "6")
                {
                    six2();
                }
                else if (number.Text == "7")
                {
                    seven2();
                }
                else if (number.Text == "8")
                {
                    eight2();
                }
                else if (number.Text == "9")
                {
                    nine2();
                }
                else if (number.Text == "0")
                {
                    zero2();
                }
                else
                {
                    clear();
                }
            }
            else if(number.Text.Length == 2)
            {
                clear();
                string a = number.Text.Substring(0, 1);
                string b = number.Text.Substring(1, 1);
                if (a == "0")
                {
                    zero();
                }
                else if (a == "1")
                {
                    one();
                }
                else if (a == "2")
                {
                    two();
                }
                else if (a == "3")
                {
                    three();
                }
                else if (a == "4")
                {
                    four();
                }
                else if (a == "5")
                {
                    five();
                }
                else if (a == "6")
                {
                    six();
                }
                else if (a == "7")
                {
                    seven();
                }
                else if (a == "8")
                {
                    eight();
                }
                else if (a == "9")
                {
                    nine();
                }
                else if (a == "-")
                {
                    minus();
                }
                else if (a == "-" && b == "0")
                {
                    zero();
                    zero2();
                }
                else
                {
                    clear();
                }
                if (b == "0")
                {
                    zero2();
                }
                else if (b == "1")
                {
                    one2();
                }
                else if (b == "2")
                {
                    two2();
                }
                else if (b == "3")
                {
                    three2();
                }
                else if (b == "4")
                {
                    four2();
                }
                else if (b == "5")
                {
                    five2();
                }
                else if (b == "6")
                {
                    six2();
                }
                else if (b == "7")
                {
                    seven2();
                }
                else if (b == "8")
                {
                    eight2();
                }
                else if (b == "9")
                {
                    nine2();
                }
                else
                {
                    clear();
                }
            }
            else
            {
                clear();
            }
        }
        public void draw_top()
        {
            for(int i = 1; i < W - 1; i++)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_mid()
        {
            int a = W * ((H - 1) / 2) + 1;
            int b = W * (((H - 1) / 2) + 1)-1;
            for (int i = a; i < b; i++)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_bottom()
        {
            int a = W * (H-1) + 1;
            int b = W * H - 1;
            for(int i = a; i < b; i++)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_right_up()
        {
            int a = W * 2 - 1;
            int b = W * (((H - 1) / 2) + 1)-1;
            for (int i = a; i < b; i+=W)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_right_down()
        {
            int a = W * ((H + 1) / 2 + 1) - 1;
            int b = W * H -1;
            for (int i = a; i < b; i+=W)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_left_up()
        {
            int a = W ;
            int b = W * ((H - 1)/2);
            for (int i = a; i < b; i+=W)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_left_down()
        {
            int a = W * ((H - 1) / 2)+W;
            int b = W * (H - 1);
            for (int i = a; i < b; i+=W)
            {
                newButton[i].BackColor = Color.Blue;
            }
        }
        public void draw_top2()
        {
            for (int i = 1; i < W - 1; i++)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void draw_mid2()
        {
            int a = W * ((H - 1) / 2) + 1;
            int b = W * (((H - 1) / 2) + 1) - 1;
            for (int i = a; i < b; i++)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void draw_bottom2()
        {
            int a = W * (H - 1) + 1;
            int b = W * H - 1;
            for (int i = a; i < b; i++)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void draw_right_up2()
        {
            int a = W * 2 - 1;
            int b = W * (((H - 1) / 2) + 1) - 1;
            for (int i = a; i < b; i += W)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void draw_right_down2()
        {
            int a = W * ((H + 1) / 2 + 1) - 1;
            int b = W * H - 1;
            for (int i = a; i < b; i += W)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void draw_left_up2()
        {
            int a = W;
            int b = W * ((H - 1) / 2);
            for (int i = a; i < b; i += W)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void draw_left_down2()
        {
            int a = W * ((H - 1) / 2) + W;
            int b = W * (H - 1);
            for (int i = a; i < b; i += W)
            {
                newButton2[i].BackColor = Color.Blue;
            }
        }
        public void zero()
        {
            draw_top();
            draw_bottom();
            draw_right_up();
            draw_right_down();
            draw_left_up();
            draw_left_down();
        }
        public void zero2()
        {
            draw_top2();
            draw_bottom2();
            draw_right_up2();
            draw_right_down2();
            draw_left_up2();
            draw_left_down2();
        }
        public void one()
        {
            draw_right_up();
            draw_right_down();
        }
        public void one2()
        {
            draw_right_up2();
            draw_right_down2();
        }
        public void two()
        {
            draw_top();
            draw_bottom();
            draw_mid();
            draw_right_up();
            draw_left_down();
        }
        public void two2()
        {
            draw_top2();
            draw_bottom2();
            draw_mid2();
            draw_right_up2();
            draw_left_down2();
        }
        public void three()
        {
            draw_top();
            draw_bottom();
            draw_mid();
            draw_right_up();
            draw_right_down();
        }
        public void three2()
        {
            draw_top2();
            draw_bottom2();
            draw_mid2();
            draw_right_up2();
            draw_right_down2();
        }
        public void four()
        {
            draw_mid();
            draw_right_up();
            draw_right_down();
            draw_left_up();
        }
        public void four2()
        {
            draw_mid2();
            draw_right_up2();
            draw_right_down2();
            draw_left_up2();
        }
        public void five()
        {
            draw_top();
            draw_bottom();
            draw_mid();
            draw_right_down();
            draw_left_up();
        }
        public void five2()
        {
            draw_top2();
            draw_bottom2();
            draw_mid2();
            draw_right_down2();
            draw_left_up2();
        }
        public void six()
        {
            draw_top();
            draw_bottom();
            draw_mid();
            draw_right_down();
            draw_left_up();
            draw_left_down();
        }
        public void six2()
        {
            draw_top2();
            draw_bottom2();
            draw_mid2();
            draw_right_down2();
            draw_left_up2();
            draw_left_down2();
        }
        public void seven()
        {
            draw_top();
            draw_right_up();
            draw_right_down();
        }
        public void seven2()
        {
            draw_top2();
            draw_right_up2();
            draw_right_down2();
        }
        public void eight()
        {
            draw_top();
            draw_bottom();
            draw_mid();
            draw_right_up();
            draw_right_down();
            draw_left_up();
            draw_left_down();
        }
        public void eight2()
        {
            draw_top2();
            draw_bottom2();
            draw_mid2();
            draw_right_up2();
            draw_right_down2();
            draw_left_up2();
            draw_left_down2();
        }
        public void nine()
        {
            draw_top();
            draw_bottom();
            draw_mid();
            draw_right_up();
            draw_right_down();
            draw_left_up();
        }
        public void nine2()
        {
            draw_top2();
            draw_bottom2();
            draw_mid2();
            draw_right_up2();
            draw_right_down2();
            draw_left_up2();
        }
        public void minus()
        {
            draw_mid();
        }
        public void minus2()
        {
            draw_mid2();
        }
        public void clear()
        {
            for(int i = 0; i < H * W; i++)
            {
                newButton[i].BackColor = Color.Transparent;
                newButton2[i].BackColor = Color.Transparent;
            }
        }
    }
}
