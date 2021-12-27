using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f74091051_w5_practice__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            up.Visible = false;
            down.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            enter.Visible = false;
            enter2.Visible = false;
            historybox.Visible = false;
        }
        static List<string> historyform = new List<string>();
        private void rndgenerate_Click(object sender, EventArgs e)
        {
            alphabet alph = new alphabet();
            generatenum.Text = alph.rnd_genertate();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int count = 0;
            char[] substi = generatenum.Text.ToCharArray();
            char[] letter = { 'A','B','C','D','E','F','G','H','I','J','K','L','M',
                             'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                             'a','b','c','d','e','f','g','h','i','j','k','l','m',
                             'n','o','p','q','r','s','t','u','v','w','x','y','z'};
            if (generatenum.Text.Length != 52)
            {
                check.Text = "替換表不合法";
            }
            else
            {
                for (int i = 0; i < 52; i++)
                {
                    if (!generatenum.Text.Contains(letter[i]))
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    check.Text = "替換表合法";
                    historyform.Add("新的替換表");
                    historyform.Add(generatenum.Text);
                    historyform.Add("");
                }
                else
                {
                    check.Text = "替換表不合法";
                }
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            generatenum.Visible = false;
            name.Text = "加密";
            rndgenerate.Visible = false;
            save.Visible = false;
            up.Visible = true;
            down.Visible = true;
            up.Text = "輸入字串";
            down.Text = "加密結果";
            textBox1.Visible = true;
            textBox2.Visible = true;
            enter.Visible = true;
            enter2.Visible = false;
            check.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            historybox.Visible = false;        
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            generatenum.Visible = false;
            name.Text = "解密";
            rndgenerate.Visible = false;
            save.Visible = false;
            up.Visible = true;
            down.Visible = true;
            up.Text = "輸入密文";
            down.Text = "解密結果";
            textBox1.Visible = true;
            textBox2.Visible = true;
            enter.Visible = false;
            enter2.Visible = true;
            check.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            historybox.Visible = false;
        }

        private void substitudechart_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            generatenum.Visible = true;
            name.Text = "替換表";
            rndgenerate.Visible = true;
            save.Visible = true;
            up.Visible = false;
            down.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            enter.Visible = false;
            enter2.Visible = false;
            check.Visible = true;
            historybox.Visible = false;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Encrypt enc = new Encrypt();
            textBox2.Text = enc.change(generatenum.Text, textBox1.Text);
            historyform.Add("加密");
            historyform.Add("明文:"+textBox1.Text);
            historyform.Add("密文:" + textBox2.Text);
            historyform.Add("");
        }

        private void enter2_Click(object sender, EventArgs e)
        {
            Decrypt dec = new Decrypt();
            textBox2.Text = dec.change(generatenum.Text, textBox1.Text);
            historyform.Add("解密");
            historyform.Add("密文:" + textBox1.Text);
            historyform.Add("明文:" + textBox2.Text);
            historyform.Add("");
        }

        private void history_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            generatenum.Visible = true;
            name.Text = "歷史紀錄";
            rndgenerate.Visible = false;
            save.Visible = false;
            up.Visible = false;
            down.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            enter.Visible = false;
            enter2.Visible = false;
            check.Visible = false;
            historybox.Visible = true;
            foreach (string mydata in historyform)
            {
                historybox.AppendText(mydata);
                historybox.AppendText("\r\n");
            }
            historyform.Clear();
                
        }
    }
}
