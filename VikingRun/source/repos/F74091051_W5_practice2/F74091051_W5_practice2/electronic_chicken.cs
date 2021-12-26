using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74091051_W5_practice2
{
    class electronic_chicken
    {
        public string enter_name(string name)
        {
            if (String.Compare(name,"")==0)
                return "電子雞";
            else
                return name;
        }
        public  string[] feed_chicken( string bel, string wei)
        {
            Random rnd_num = new Random();
            bel = (int.Parse(bel) + rnd_num.Next(21)).ToString();
            wei = (int.Parse(wei) + rnd_num.Next(50, 101)).ToString();
            if (int.Parse(bel) > 100)
                bel = "100";
            if (int.Parse(wei) > 4000)
                wei="4000";
            string[] result = { bel, wei };
            return result;
        }
        public string[] play_chicken(string hea, string mo, string bel)
        {
            Random rnd_num = new Random();
            bel = (int.Parse(bel) - rnd_num.Next(21)).ToString();
            mo = (int.Parse(mo) + rnd_num.Next(21)).ToString();
            hea= (int.Parse(hea) + rnd_num.Next(21)).ToString();
            if (int.Parse(bel) <0)
                bel = "0";
            if (int.Parse(mo) > 100)
                mo = "100";
            if (int.Parse(hea) > 100)
                hea = "100";
            string[] result = {hea,mo,bel};
            return result;
        }
        public string[] seedoctor(string hea, string mo)
        {
            mo = (int.Parse(mo) -20).ToString();
            hea = (int.Parse(hea) + 30).ToString();
            if (int.Parse(mo) < 0)
                mo = "0";
            if (int.Parse(hea) > 100)
                hea = "100";
            string[] result = { hea, mo };
            return result;
        }
        public string[] finishday(string bel, string wei,string hea,int day)
        {
            if (int.Parse(bel) == 0)
            {
                wei = (int.Parse(wei) - 200).ToString();
            }
            else
            {
                bel = (int.Parse(bel) - 20).ToString();
            }
            if (day >= 11)  
            {
                hea = (int.Parse(hea) - 10).ToString();
            }
            if (int.Parse(bel) < 0)
                bel = "0";
            if (int.Parse(wei) < 600)
                wei = "600";
            if (int.Parse(hea) < 0)
                hea = "0";
            string[] result = { bel, wei, hea };
            return result;
        }
        public string poop(string bel,int a)
        {
            if (int.Parse(bel) >= 50||a==1)
            {
                return "牠大便了" + "\r\n";
            }
            else return "";
        }
        public string layegg(string hea, string wei, string mo,string name)
        {
            Random rnd = new Random();
            if (int.Parse(wei) > 1000 && int.Parse(hea) > 60)
            {
                if (rnd.Next(101) > int.Parse(mo))
                {
                    return "";
                }
                else if ((rnd.Next(101) <= int.Parse(mo)))
                {
                    return name+"下蛋了，賣掉後獲得" + rnd.Next(15, 26)+"塊錢\r\n";
                }
                else
                    return "";
            }
            else
                return "";
        }
        public string sick(string hea,  string mo,string name,string wei,int s)
        {
            Random rnd = new Random();
            if (int.Parse(hea) <= 50 && int.Parse(mo) <= 50)
            {
                if (rnd.Next(101) > int.Parse(mo)||s==1)
                {                  
                    return name + "生病了" + "\r\n";
                }
                else
                    return "";
            }
            else
                return "";
        }
        public string die(string hea, string wei, string mo,string name)
        {
            Random rnd = new Random();
            if (int.Parse(wei) <1000&&int.Parse(hea)<10)
            {
                if (rnd.Next(101) > int.Parse(mo))
                {
                    return "死掉了，遊戲結束";
                }
                else
                    return "";
            }
            else return "";
        }   
    }
}
