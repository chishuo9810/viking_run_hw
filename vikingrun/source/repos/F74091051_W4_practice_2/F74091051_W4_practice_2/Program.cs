using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74091051_W4_practice_2
{
    class Program
    {
        static int bottom,height;
        static int enter1, enter2,leave1,leave2;
        static int myPosition1, myPosition2,changeposition1,changeposition2;
        static int r, l, u, d,back,wall,finish;
        static int judge;          //leftup=1,upleft=2,rightup=3,upright=4,leftdown=5,downleft=6,rightdown=7,downright=8
        static string size;
        static string[,] map;
        static string[,] true_map;
        static void draw_map(int down,int high)
        {
            Console.WriteLine("輸入迷宮地圖: ");
            map = new string[high, 1];
            true_map = new string[high,down];
           for(int i = 0; i < high; i++)
            {
                map[i,0] = Console.ReadLine();
            }
           for(int i = 0; i < high; i++)
            {
                for(int j = 0; j < down; j++)
                {
                    true_map[i, j] = map[i, 0].Substring(j,1);
                }
            }
        }
        static void draw_road()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < bottom; j++)
                {
                    Console.Write(true_map[i, j]);
                    if (j == bottom - 1)
                        Console.WriteLine();
                }
            }
        }
        static void find_the_entrance()
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < bottom; j++)
                {
                    if (String.Compare(true_map[i,j],"0")==0)
                    {
                        enter1 = i;
                        enter2 = j;
                    }
                }
            }
        }
        static void find_the_exit()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < bottom; j++)
                {
                    if (String.Compare(true_map[i, j], "X") == 0)
                    {
                        leave1 = i;
                        leave2 = j;
                    }
                }
            }
        }
        static void check_the_relative_location()
        {
            if (enter1 >= leave1 && enter2 >= leave2)              //出口在入口左上
            {
                if (enter1 - leave1 >= enter2-leave2)
                {
                    judge = 1;
                }
                else if(enter1 - leave1 < enter2 - leave2)
                {
                    judge = 2;
                }
            }
            else if(enter1 <= leave1 && enter2 >= leave2)           //出口在入口右上
            {
                if (leave1 - enter1 >= enter2 - leave2)
                {
                    judge = 3;
                }
                else if (leave1 - enter1 < enter2 - leave2)
                {
                    judge = 4;
                }
            }
            else if (leave1>=enter1&&leave2>=enter2)                 //出口在入口右下
            {
                if (leave1 - enter1 >= leave2 - enter2)
                {
                    judge = 7;
                }
                else if (leave1 - enter1 < leave2 - enter2)
                {
                    judge = 8;
                }
            }
            else if (enter1>=leave1&&enter2<=leave2)                    //出口在左下
            {
                if (enter1 - leave1 >= leave2 - enter2)
                {
                    judge = 5;
                }
                else if (enter1 - leave1 < leave2 - enter2)
                {
                    judge = 6;
                }
            }
        }
        static void check_right( )
        {
            r = 0;
            try
            {
                string right = true_map[myPosition1, myPosition2 + 1];
                if (String.Compare(right, "1") == 0)
                {
                    wall+=1;
                }
                else if (String.Compare(right, "2") == 0)
                {
                    wall+=1;
                }
                else if (String.Compare(right, "3") == 0)
                {
                    back+=1;
                    changeposition1 = myPosition1;
                    changeposition2 = myPosition2 + 1;
                }
                else if (String.Compare(right, "X") == 0)
                {
                    finish+=1;
                }
                else if (String.Compare(right, "0") == 0)
                {
                    wall+=1;
                }
                else if (String.Compare(right, " ") == 0)
                {
                    r += 1;
                }
            }
            catch(FormatException)
            {
                wall+=1;
            }
        }
        static void check_left()
        {
            l = 0;
            try
            {
                string left = true_map[myPosition1, myPosition2 -1];
                if (String.Compare(left, "1") == 0)
                {
                    wall += 1;
                }
                else if (String.Compare(left, "2") == 0)
                {
                    wall += 1;
                }
                else if (String.Compare(left, "3") == 0)
                {
                    back += 1;
                    changeposition1 = myPosition1;
                    changeposition2 = myPosition2 - 1;
                }
                else if (String.Compare(left, "X") == 0)
                {
                    finish += 1;
                }
                else if (String.Compare(left, "0") == 0)
                {
                    wall += 1;
                }
                else if (String.Compare(left, " ") == 0)
                {
                    l += 1;
                }
            }
            catch (FormatException)
            {
                wall += 1;
            }
        }
        static void check_up()
        {
            u = 0;
            try
            {
                string up = true_map[myPosition1-1, myPosition2 ];
                if (String.Compare(up, "1") == 0)
                {
                    wall += 1;
                }
                else if (String.Compare(up, "2") == 0)
                {
                    wall += 1;
                }
                else if (String.Compare(up, "3") == 0)
                {
                    back += 1;
                    changeposition1 = myPosition1+1;
                    changeposition2 = myPosition2 ;
                }
                else if (String.Compare(up, "X") == 0)
                {
                    finish += 1;
                }
                else if (String.Compare(up, "0") == 0)
                {
                    wall += 1;
                }
                else if (String.Compare(up, " ") == 0)
                {
                    u += 1;
                }
            }
            catch (FormatException)
            {
                wall += 1;
            }
        }
        static void check_down()
        {
            d = 0;
            try
            {
                if (myPosition1 == height-1)
                {
                    ;
                }
                else
                {

                    string down = true_map[enter1 , enter2];
                    Console.WriteLine(down);
                    Console.ReadKey();
                    Environment.Exit(0);
                    if (String.Compare(down, "1") == 0)
                    {
                        wall += 1;
                    }
                    else if (String.Compare(down, "2") == 0)
                    {
                        wall += 1;
                    }
                    else if (String.Compare(down, "3") == 0)
                    {
                        back += 1;
                        changeposition1 = myPosition1 - 1;
                        changeposition2 = myPosition2;
                    }
                    else if (String.Compare(down, "X") == 0)
                    {
                        finish += 1;
                    }
                    else if (String.Compare(down, "0") == 0)
                    {
                        wall += 1;
                    }
                    else if (String.Compare(down, " ") == 0)
                    {
                        d += 1;
                    }
                }
            }
            catch (FormatException)
            {
                wall += 1;
            }
        }
        static void move(int direction)
        {
            myPosition1 = enter1;
            myPosition2 = enter2;
            for (; ; ) {
                wall = 0;
                back = 0;
                finish = 0;
                switch (direction)
                {
                    case 1:
                        check_left();
                        check_up();
                        check_down();
                        check_right();
                        if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                    case 2:
                        check_up();
                        check_left();
                        check_right();
                        check_down();                     
                        if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                    case 3:
                        check_right();
                        check_up();
                        check_down();
                        check_left();
                        if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                    case 4:
                        check_up();
                        check_right();
                        check_left();
                        check_down();
                        if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                    case 5:
                        check_left();
                        check_down();
                        check_up();
                        check_right();
                        if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                            break;
                    case 6:
                        check_down();
                        check_left();
                        check_right();
                        check_up();
                        if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                    case 7:
                        check_right();
                        check_down();
                        check_up();
                        check_left();
                        if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                    case 8:
                        check_down();
                        check_right();
                        check_left();
                        check_up();
                        if (d == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 -= 1;
                        }
                        else if (r == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 += 1;
                        }
                        else if (l == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition2 -= 1;
                        }
                        else if (u == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            myPosition1 += 1;
                        }
                        else if (wall == 3 && back == 1)
                        {
                            true_map[myPosition1, myPosition2] = "2";
                            myPosition1 = changeposition1;
                            myPosition2 = changeposition2;
                        }
                        else if (finish == 1)
                        {
                            true_map[myPosition1, myPosition2] = "3";
                            break;
                        }
                        break;
                }
                if (finish == 1)
                {
                    true_map[myPosition1, myPosition2] = "3";
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入迷宮大小(底,高): ");
            size = Console.ReadLine();
            for(int i = 0; i < size.Length; i++)
            {
                if (String.Compare(size.Substring(i, 1), ",") == 0)
                {
                    bottom = int.Parse(size.Substring(0, i));
                    height = int.Parse(size.Substring(i + 1, size.Length-i-1));
                }
            }
            draw_map(bottom,height);
            find_the_entrance();
            find_the_exit();
            Console.WriteLine(true_map[enter1,enter2]);
            Console.WriteLine(height-1);
            Console.ReadKey();
            Environment.Exit(0);
            check_the_relative_location();
            move(judge);
            draw_road();
        }
    }
}
