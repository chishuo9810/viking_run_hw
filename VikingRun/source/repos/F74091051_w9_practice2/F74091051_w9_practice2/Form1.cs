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
using System.Media;

namespace F74091051_w9_practice2
{
    public partial class Form1 : Form
    {
        //RadioButton[] rb = new RadioButton[4];
        rabi[] rb = new rabi[4];
        int i = 0, c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_checkedchanged(object sender, EventArgs e)
        {
            rabi r = (rabi)sender;
            r.stop();
        }

        private void select_files_btn_Click(object sender, EventArgs e)
        {
            i = 0;
            if (c != 0)
            {
                for (int j = 0; j < 4; j++)
                {
                    groupBox1.Controls.Remove(rb[j]);
                    rb[0].Text = " ";
                }
            }
            string[] k = new string[4];
            k = m.select_files(openFileDialog1);
            m.Playlist = k;
            for (int j = 0; j < 4; j++)
            {
                try
                {
                    if (k[j] == null)
                    {
                        ;
                    }
                    else
                    {
                        rb[j] = new rabi();
                        rb[j].Text = k[j];
                        rb[j].AutoSize = true;
                        rb[j].CheckedChanged += rb_checkedchanged;
                        groupBox1.Controls.Add(rb[i]);
                        rb[i].Location = new Point(50, 80 + 30 * i);
                        change_color();
                        change_font();
                        i++;
                        if (c != 0)
                        {
                            change_color();
                            change_font();
                        }
                    }
                }
                catch { };
            }
            c++;
        }
        MusicPlayer m = new MusicPlayer();

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb[0].Checked)
                {
                    m.stop(rb[0].Text);
                }
                else if (rb[1].Checked)
                {
                    m.stop(rb[1].Text);
                }
                else if (rb[2].Checked)
                {
                    m.stop(rb[2].Text);
                }
                else if (rb[3].Checked)
                {
                    m.stop(rb[3].Text);
                }
            }
            catch { };
        }
        System.Drawing.Color tempcolor;
        System.Drawing.Font tempfont;
        public void change_color()
        {
            try
            {
                for(int j = 0; j < 4; j++)
                {
                    rb[j].ForeColor = tempcolor;
                }
            }
            catch { };
        }
        public void change_font()
        {
            try
            {
                for (int j = 0; j < 4; j++)
                {
                    rb[j].Font=myFontDialog.Font;
                }
            }
            catch { };
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)                  //COLOR
        {
            if (myColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                tempcolor = myColorDialog.Color;
            }
            change_color();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)                 //FONT  
        {
            if (myFontDialog.ShowDialog() != DialogResult.Cancel)
            {
                tempfont = myFontDialog.Font;
            }
            change_font();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)              //load
        {
            i = 0;
            m.Playlist = m.LoadPlaylist();
            for (int j = 0; j < 4; j++)
            {
                groupBox1.Controls.Remove(rb[j]);
            }
            for (int j = 0; j < 4; j++)
            {
                try
                {
                    if (m.Playlist[j] == null)
                    {
                        ;
                    }
                    else if(m.Playlist[j].Substring(0,1)==" "){
                        ;
                    }
                    else
                    {
                        rb[j] = new rabi();
                        rb[j].Text = m.Playlist[j];
                        rb[j].AutoSize = true;
                        rb[j].CheckedChanged += rb_checkedchanged;
                        groupBox1.Controls.Add(rb[i]);
                        rb[i].Location = new Point(50, 80 + 30 * i);
                        i++;
                        change_color();
                        change_font();
                    }
                }
                catch { };
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)             //save
        {
            try
            {
                if (rb[0].Text.Substring(0,1) == " ")
                {
                    MessageBox.Show("請先建立撥放清單\n"); ;
                }
                else
                    m.SavePlayist();
            }
            catch {
                MessageBox.Show("請先建立撥放清單\n");
            };
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb[0].Checked)
                {
                    m.play(rb[0].Text, loop_ckb);
                }
                else if (rb[1].Checked)
                {
                    m.play(rb[1].Text, loop_ckb);
                }
                else if (rb[2].Checked)
                {
                    m.play(rb[2].Text, loop_ckb);
                }
                else if (rb[3].Checked)
                {
                    m.play(rb[3].Text, loop_ckb);
                }
            }
            catch { };
        }
    }
}
