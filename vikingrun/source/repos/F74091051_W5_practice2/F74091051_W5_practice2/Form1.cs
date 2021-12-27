using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74091051_W5_practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            feed.Enabled = false;
            play.Enabled = false;
            sweep.Enabled = false;
            see_doctor.Enabled = false;
            finish_the_day.Enabled = false;
            record_textbox.ReadOnly = true;
        }

        static string chickname;
        int pp,si;
        int day = 2;
        static List<string> recordform = new List<string>();

        private void enter_name_Click(object sender, EventArgs e)
        {
            electronic_chicken chi = new electronic_chicken();
            chickname= chi.enter_name(name_textbox.Text);
            name_textbox.Text = chickname;
            record_textbox.AppendText("你開始養了" + chickname + "\r\n" + "第一天" + "\r\n");
            accident.Text = chickname+"出生了";
            money.Text = "100";
            health.Text = "70";
            weight.Text = "700";
            belly.Text = "70";
            mood.Text = "50";
            pp = 0;
            si = 0;
            feed.Enabled = true;
            play.Enabled = true;
            sweep.Enabled = true;
            see_doctor.Enabled = true;
            finish_the_day.Enabled = true;
            enter_name.Enabled = false;
            name_textbox.ReadOnly = true;
        }
        private void feed_Click(object sender, EventArgs e)
        {
            if (int.Parse(money.Text) >= 10)
            {
                electronic_chicken chi = new electronic_chicken();
                record_textbox.AppendText("餵食了" + chickname + "\r\n");
                belly.Text = chi.feed_chicken(belly.Text, weight.Text)[0];
                weight.Text = chi.feed_chicken(belly.Text, weight.Text)[1];
                money.Text = (int.Parse(money.Text) - 10).ToString();
            }
            else
                record_textbox.AppendText("金額不足無法餵食\r\n");
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (int.Parse(money.Text) >= 5)
            {
                record_textbox.AppendText("與" + chickname + "玩耍了\r\n");
                electronic_chicken chi = new electronic_chicken();
                health.Text = chi.play_chicken(health.Text, mood.Text, belly.Text)[0];
                mood.Text = chi.play_chicken(health.Text, mood.Text, belly.Text)[1];
                belly.Text = chi.play_chicken(health.Text, mood.Text, belly.Text)[2];
                money.Text = (int.Parse(money.Text) - 5).ToString();
            }
            else
                record_textbox.AppendText("金額不足無法玩耍\r\n");
        }

        private void sweep_Click(object sender, EventArgs e)
        {
            if (int.Parse(money.Text) >= 5)
            {
                record_textbox.AppendText("清理了" + chickname + "\r\n");
                money.Text = (int.Parse(money.Text) - 5).ToString();
                pp = 0;
            }
            else
                record_textbox.AppendText("金額不足無法打掃\r\n");
        }

        private void see_doctor_Click(object sender, EventArgs e)
        {
            if (int.Parse(money.Text) >= 20)
            {
                record_textbox.AppendText("帶" + chickname + "去看醫生\r\n");
                money.Text = (int.Parse(money.Text) - 20).ToString();
                electronic_chicken chi = new electronic_chicken();
                health.Text = chi.seedoctor(health.Text, mood.Text)[0];
                mood.Text = chi.seedoctor(health.Text, mood.Text)[1];
                si = 0;
            }
            else
                record_textbox.AppendText("金額不足無法看醫生    \r\n");
        }

        private void finish_the_day_Click(object sender, EventArgs e)
        {
            record_textbox.AppendText("\r\n第" + day + "天\r\n");
            electronic_chicken chi = new electronic_chicken();       
            string l = chi.layegg(health.Text, weight.Text, mood.Text, chickname);
            string s = chi.sick(health.Text, mood.Text, chickname, weight.Text,si);
            string p = chi.poop(belly.Text,pp);
            if (String.Compare(chi.die(health.Text, weight.Text, mood.Text, chickname), "死掉了，遊戲結束") == 0)
            {
                record_textbox.AppendText(chi.die(health.Text, weight.Text, mood.Text, chickname));
                accident.Text = chickname + "死掉了";
                feed.Enabled = false;
                play.Enabled = false;
                sweep.Enabled = false;
                see_doctor.Enabled = false;
                finish_the_day.Enabled = false;
                enter_name.Enabled = false;
            }
            else
            {
                if (String.Compare(l, "") != 0)
                {
                    record_textbox.AppendText(l);
                    health.Text = (int.Parse(health.Text) - 5).ToString();
                    money.Text = (int.Parse(money.Text) + int.Parse(l.Substring(l.Length-6, 2))).ToString();
                }
                if (String.Compare(p, "") != 0||pp==1)
                {
                    if (pp == 1)
                    {
                        health.Text = (int.Parse(health.Text) - 30).ToString();
                    }
                    record_textbox.AppendText(p);
                    accident.Text = chickname + "大便了";
                    pp = 1;
                }
                if (String.Compare(s, "") != 0||si==1)
                {
                    mood.Text = (int.Parse(mood.Text) - 20).ToString();
                    weight.Text = (int.Parse(weight.Text) - 150).ToString();
                    if (int.Parse(weight.Text) < 600)
                        weight.Text = "600";
                    if (int.Parse(mood.Text) < 0)
                        mood.Text = "0";
                    if (pp == 1)
                    {
                        health.Text = (int.Parse(health.Text) - 30).ToString();
                    }
                    if (int.Parse(health.Text) < 0)
                        health.Text = "0";
                    record_textbox.AppendText(s);
                    accident.Text = chickname + "生病了";
                    si = 1;
                }
                if (String.Compare(s, "") != 0&& String.Compare(p, "") != 0 || (pp == 1 && si == 1))
                {
                    accident.Text = chickname + "大便了 " + chickname + "生病了";
                }
                if (s.Equals("") && l.Equals("") && p.Equals("") && pp == 0 && si == 0)
                {
                    record_textbox.AppendText("一天平安的過去了\r\n");
                    accident.Text = chickname + "今天很乖";
                }
                day++;
                belly.Text = chi.finishday(belly.Text, weight.Text, health.Text, day)[0];
                weight.Text = chi.finishday(belly.Text, weight.Text, health.Text, day)[1];
                health.Text = chi.finishday(belly.Text, weight.Text, health.Text, day)[2];
            }
        }
    }
}
