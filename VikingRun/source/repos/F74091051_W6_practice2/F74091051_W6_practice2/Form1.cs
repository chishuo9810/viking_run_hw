using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;

namespace F74091051_W6_practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        font p = new font();
        int click = 1;
        private void last_Click(object sender, EventArgs e)
        {
            if (click == 1)
            {
                pictureBox1.Image =Properties.Resources.pic_05_1_;
                click = 5;
            }
            else
            {
                switch (click)
                {
                    case 2:
                        pictureBox1.Image = Properties.Resources.pic_01_1_;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.pic_02_1_;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.pic_03_1_;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.pic_04_1_;
                        break;
                }
                click--;
            }
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (click == 5)
            {
                pictureBox1.Image = Properties.Resources.pic_01_1_;
                click = 1;
            }
            else
            {
                switch (click)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.pic_02_1_;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.pic_03_1_;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.pic_04_1_;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.pic_05_1_;
                        break;
                    
                }
                click++;
            }
        }
        private void upleft_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.ChangeLabel(up,1);
            down.Visible = false;
            up.Visible = true;
        }

        private void upmid_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.ChangeLabel(up,2);
            down.Visible = false;
            up.Visible = true;
        }

        private void upright_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.ChangeLabel(up, 3);
            down.Visible = false;
            up.Visible = true;
        }

        private void downleft_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.ChangeLabel(down, 1);
            down.Visible = true;
            up.Visible = false;
        }

        private void downmid_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.ChangeLabel(down, 2);
            down.Visible = true;
            up.Visible =false;
        }

        private void downright_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.ChangeLabel(down, 3);
            down.Visible = true;
            up.Visible = false;
        }

        private void word_TextChanged(object sender, EventArgs e)
        {
            up.Text = word.Text;
            down.Text = word.Text;
        }

        private void wordsize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(wordsize.Text) < 33 && int.Parse(wordsize.Text) > 0)
                {
                    p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
                    p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
                }
                else
                {
                    p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, 12);
                    p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, 12);
                }
            }
            catch
            {
                p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, 12);
                p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, 12);
            }
        }

        private void first_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.Font(up,first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
            p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
        }
        private void second_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
            p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
        }
        private void third_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
            p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
        }

        private void bold_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
            p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
        }

        private void italic_rb_CheckedChanged(object sender, EventArgs e)
        {
            p.Font(up, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
            p.Font(down, first_rb, second_rb, third_rb, bold_rb, italic_rb, int.Parse(wordsize.Text));
        }


    }
}
