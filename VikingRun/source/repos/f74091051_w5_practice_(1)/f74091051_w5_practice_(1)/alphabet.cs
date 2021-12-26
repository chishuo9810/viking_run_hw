using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74091051_w5_practice__1_
{
    class alphabet
    {
        public string rnd_genertate()
        {
            char[] array = { 'A','B','C','D','E','F','G','H','I','J','K','L','M',
                             'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                             'a','b','c','d','e','f','g','h','i','j','k','l','m',
                             'n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Random rng = new Random();
            int n = 52;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            string rnd_num = new string(array);
            return rnd_num;
        }
    }
}
