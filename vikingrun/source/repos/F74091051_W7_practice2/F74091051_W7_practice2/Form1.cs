using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74091051_W7_practice2
{
    public partial class Form1 : Form
    {
        Button []newEnemy = new Button[4];
        Button me = new Button();
        Button[] blt = new Button[100];
        Random rnd = new Random();
        double sec1=1,sec2,sec3,sec4;
        int bltnum=0,bltnum2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sec1 = 0.1;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            attribute_lb.Visible = true;
            point_lb.Visible = true;
            time_lb.Visible = true;
            groupBox1.Visible = false;
            enter_btn.Visible = false;
            for(int i = 0; i < 4; i++)
            {
                newEnemy[i] = new Button();
                newEnemy[i].Location = new Point(5+45*i,0);
                newEnemy[i].Size = new Size(40,40);
                switch (rnd.Next(3))
                {
                    case 0:
                        newEnemy[i].BackColor = Color.Red;
                        newEnemy[i].Text = "火";
                        break;
                    case 1:
                        newEnemy[i].BackColor = Color.Blue;
                        newEnemy[i].Text = "水";
                        break;
                    case 2:
                        newEnemy[i].BackColor = Color.Green;
                        newEnemy[i].Text = "木";
                        break;
                }
                Controls.Add(newEnemy[i]);
            }
            //me = new Button();
            me.Location = new Point(50, 300);
            me.Size = new Size(40, 40);
            me.Text = "你";
            if (fire_rdb.Checked)
            {
                me.BackColor = Color.Red;
                attribute_lb.Text = "火";
            }
            else if (water_rdb.Checked)
            {
                me.BackColor = Color.Blue;
                attribute_lb.Text = "水";
            }
            else if (wood_rdb.Checked)
            {
                me.BackColor = Color.Green;
                attribute_lb.Text = "木";
            }
            Controls.Add(me);        
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (me.Location.X == 5)
                        ;
                    else
                        me.Left -= 45;
                    break;
                case Keys.D:
                    if (me.Location.X == 140)
                        ;       
                    else
                        me.Left += 45;
                    break;
                case Keys.W:
                    generaterate_blt();
                    timer2.Enabled = true;
                    bltnum++;
                    break;
            }
        }
        bullet b = new bullet();
        public void generaterate_blt()
        {
            //b = new bullet();
            blt[bltnum] = new Button();
            blt[bltnum].BackColor = me.BackColor;
            blt[bltnum].Size=new Size(20, 20);
            blt[bltnum].Location = new Point(me.Location.X + 10, me.Location.Y - 20);
            Controls.Add(blt[bltnum]);
        }
        moving_speed enemy = new moving_speed();

        private void timer2_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < bltnum; i++)
            {
                blt[i].Top -= 10;
            }
        }
        public void new_button(int i)
        {
            Controls.Remove(newEnemy[i]);
            newEnemy[i] = new Button();
            newEnemy[i].Location = new Point(5 + 45 * i, 0);
            newEnemy[i].Size = new Size(40, 40);
            switch (rnd.Next(3))
            {
                case 0:
                    newEnemy[i].BackColor = Color.Red;
                    newEnemy[i].Text = "火";
                    break;
                case 1:
                    newEnemy[i].BackColor = Color.Blue;
                    newEnemy[i].Text = "水";
                    break;
                case 2:
                    newEnemy[i].BackColor = Color.Green;
                    newEnemy[i].Text = "木";
                    break;
            }
            Controls.Add(newEnemy[i]);
        }
        public void change_color(int i)
        {
            me.BackColor = newEnemy[i].BackColor;
            if (me.BackColor == Color.Red)
            {
                attribute_lb.Text = "火";
            }
            if (me.BackColor == Color.Blue)
            {
                attribute_lb.Text = "水";
            }
            if (me.BackColor == Color.Green)
            {
                attribute_lb.Text = "木";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy.Set_speed(newEnemy[0]);
            newEnemy[0].Top += enemy.Get_speed();
            enemy.Set_speed(newEnemy[1]);
            newEnemy[1].Top += enemy.Get_speed();
            enemy.Set_speed(newEnemy[2]);
            newEnemy[2].Top += enemy.Get_speed();
            enemy.Set_speed(newEnemy[3]);
            newEnemy[3].Top += enemy.Get_speed();
            if (me.Location.X == 5 && newEnemy[0].Location.Y > 260)
            {
                change_color(0);
                new_button(0);
            }
            else if (newEnemy[0].Location.Y >= 340)
            {
                new_button(0);
            }
            if (me.Location.X == 50 && newEnemy[1].Location.Y > 260)
            {
                change_color(1);
                new_button(1);
            }
            else if (newEnemy[1].Location.Y >= 340)
            {
                new_button(1);
            }
            if (me.Location.X == 95 && newEnemy[2].Location.Y > 260)
            {
                change_color(2);
                new_button(2);
            }
            else if (newEnemy[2].Location.Y >= 340)
            {
                new_button(2);
            }
            if (me.Location.X == 140 && newEnemy[3].Location.Y > 260)
            {
                change_color(3);
                new_button(3);
            }
            else if (newEnemy[3].Location.Y >= 340)
            {
                new_button(3);
            }
        }
    }
}



