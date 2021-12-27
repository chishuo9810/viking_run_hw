using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74091051_w5_practice__1_
{
    class Encrypt
    {
        public  string change(string sub,string t1)
        {
            string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char []enter = t1.ToCharArray();
            char[] result = new char[enter.Length];
            for(int i = 0; i < enter.Length; i++)
            {
                if (enter[i].Equals(' '))
                {
                    result[i] = ' ';
                }
                else
                {
                    result[i] = sub[letter.IndexOf(enter[i])];
                }
            }
            string final = new string(result);
            return final;
        }

    }
}
