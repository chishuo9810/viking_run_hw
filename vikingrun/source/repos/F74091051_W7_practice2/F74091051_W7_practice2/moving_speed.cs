using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74091051_W7_practice2
{
    class moving_speed
    {
        private int speed;
        public int Get_speed()
        {
            return speed;
        }
        public void Set_speed(System.Windows.Forms.Button enemy)
        {
            if (enemy.Text == "火")
            {
                speed = 20;
            }
            else if (enemy.Text == "水")
            {
                speed = 10;
            }
            else if (enemy.Text == "木")
            {
                speed = 30;
            }
        }
        public void Set_speed2(System.Windows.Forms.Button bullet)
        {
        }
    }
}
