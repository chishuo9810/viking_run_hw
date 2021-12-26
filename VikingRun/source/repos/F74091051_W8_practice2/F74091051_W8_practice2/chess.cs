using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace F74091051_W8_practice2
{
    
    class chess:System.Windows.Forms.Button
    {
        public int row,col;
        public void orange()
        {
            BackColor = Color.Orange;
        }
        public void dark_orange()
        {
            BackColor = Color.DarkOrange;
        }
        public void orange_red()
        {
            BackColor = Color.OrangeRed;
        }
        public void deep_sky_blue()
        {
            BackColor = Color.DeepSkyBlue;
        }
        public void dark_blue()
        {
            BackColor = Color.DarkBlue;
        }
        public void blue_violet()
        {
            BackColor = Color.BlueViolet;
        }
        
    }
}
