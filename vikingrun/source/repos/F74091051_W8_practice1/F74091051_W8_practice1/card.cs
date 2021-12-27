using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace F74091051_W8_practice1
{
    class Card : System.Windows.Forms.Button
    {
        public int number;
        public void hideNumber()
        {
            BackColor = Color.Gray;
            Text = null;
        }
        public void showNumber()
        {
            BackColor = Color.LightBlue;
            Text = number.ToString();
            Enabled = false;
        }

    }
}
