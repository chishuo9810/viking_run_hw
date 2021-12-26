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

namespace F74091051_W9_practice1
{
    public partial class Form1 : Form
    {
        //RadioButton[] rb = new RadioButton[4];
        rabi[] rb = new rabi[4];
        int i = 0,c=0;
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
                }
            }
            string[] k = new string[4];
            k=m.select_files(openFileDialog1);
            /*String stFilter = "WAV(*.wav)|*.wav";
            openFileDialog1.Filter = stFilter;
            this.openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                    try
                    {
                        rb[i] = new RadioButton();
                        rb[i].Text = openFileDialog1.FileNames[i];
                        rb[i].Font = new Font("Arial", 9, FontStyle.Bold);
                        rb[i].AutoSize = true;
                        groupBox1.Controls.Add(rb[i]);
                        rb[i].Location = new Point(66, 95+20*i);
                        i++;                      
                    }
                    catch { };
            }*/
            for(int j = 0; j < 4; j++)
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
                        rb[j].Font = new Font("Arial", 9, FontStyle.Bold);
                        rb[j].AutoSize = true;
                        rb[j].CheckedChanged += rb_checkedchanged;
                        groupBox1.Controls.Add(rb[i]);
                        rb[i].Location = new Point(66, 95 + 20 * i);
                        i++;
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


        private void play_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb[0].Checked)
                {
                    m.play(rb[0].Text,loop_ckb);
                }
                else if (rb[1].Checked)
                {
                    m.play(rb[1].Text,loop_ckb);
                }
                else if (rb[2].Checked)
                {
                    m.play(rb[2].Text,loop_ckb);
                }
                else if (rb[3].Checked)
                {
                    m.play(rb[3].Text,loop_ckb);
                }
            }
            catch { };
        }
        /*private void loop_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (loop_ckb.Checked)
            {
                try
                {
                    if (rb[0].Checked)
                    {
                        m.loop(rb[0].Text);
                    }
                    else if (rb[1].Checked)
                    {
                        m.loop(rb[1].Text);
                    }
                    else if (rb[2].Checked)
                    {
                        m.loop(rb[2].Text);
                    }
                    else if (rb[3].Checked)
                    {
                        m.loop(rb[3].Text);
                    }
                }
                catch { };
            }
        }*/
    }
}
