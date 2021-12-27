using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74091051_W4_practice__2_
{
    class Program
    {
        static int height, bottom,count=0;
        static string size;
        static int enter1, enter2, leave1, leave2;
        static string[,] map;
        static string[,] true_map;
        static void draw_map(int down, int high)
        {
            Console.WriteLine("輸入迷宮地圖: ");
            map = new string[high, 1];
            true_map = new string[high, down];
            for (int i = 0; i < high; i++)
            {
                map[i, 0] = Console.ReadLine();
            }
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < down; j++)
                {
                    true_map[i, j] = map[i, 0].Substring(j, 1);
                }
            }
        }
        static void find_the_entrance()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < bottom; j++)
                {
                    if (String.Compare(true_map[i, j], "0") == 0)
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
        public class MyPosition
        {
            public MyPosition parent { get; set; }
            public int X;
            public int Y;
            public MyPosition(int a, int b)
            {
                this.X = a;
                this.Y = b;
            }
        }
        static void move(MyPosition p)
        {
            Queue queue = new Queue();
            queue.Enqueue(p);
            while (queue.Count > 0)
            {
                MyPosition queuePosition = (MyPosition)queue.Dequeue();
                for(int i = -1; i < 2; i ++)
                {
                    for(int j = -1; j < 2; j ++ )
                    {
                        if (queuePosition.X + i >= 0 && queuePosition.X + i < height && queuePosition.Y + j >= 0 && queuePosition.Y + j < bottom&&i+j!=-2&&i+j!=2&&i+j!=0)
                        {
                            if(String.Compare(true_map[queuePosition.X+i,queuePosition.Y+j]," ") == 0)
                            {
                                {
                                    MyPosition last = new MyPosition(queuePosition.X + i, queuePosition.Y + j);
                                    true_map[queuePosition.X + i, queuePosition.Y + j] = "5";
                                    last.parent = queuePosition;
                                    queue.Enqueue(last);
                                }
                            }
                            else if (String.Compare(true_map[queuePosition.X + i, queuePosition.Y + j], "X") == 0)
                            {
                                draw_road(queuePosition);
                                for (int a = 0; a < height; a++)
                                {
                                    for (int b = 0; b < bottom; b++)
                                    {
                                        if (String.Compare(true_map[a, b], "5") == 0)
                                            true_map[a, b] = " ";
                                    }
                                }
                                for (int a = 0; a < height; a++)
                                {
                                    for (int b = 0; b < bottom; b++)
                                    {
                                        Console.Write(true_map[a, b]);
                                        if (b == bottom - 1)
                                            Console.WriteLine("");
                                    }
                                }
                                Console.Write(count);
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }
        static void draw_road(MyPosition p)
        {
            if (p.parent != null)
            {
                true_map[p.X, p.Y] = "*";
                count += 1;
                draw_road(p.parent);
            }       
        }

        static void Main(string[] args)
        {
            Console.Write("請輸入迷宮大小(底,高): ");
            size = Console.ReadLine();
            for (int i = 0; i < size.Length; i++)
            {
                if (String.Compare(size.Substring(i, 1), ",") == 0)
                {
                    bottom = int.Parse(size.Substring(0, i));
                    height = int.Parse(size.Substring(i + 1, size.Length - i - 1));
                }
            }
            draw_map(bottom, height);
            find_the_entrance();
            find_the_exit();
            MyPosition start = new MyPosition(enter1, enter2);
            start.parent = null;
            move(start);
            for (int a = 0; a < height; a++)
            {
                for (int b = 0; b < bottom; b++)
                {
                    if (String.Compare(true_map[a, b], "5") == 0)
                        true_map[a, b] = " ";
                }
            }
            for (int a = 0; a < height; a++)
            {
                for (int b = 0; b < bottom; b++)
                {
                    Console.Write(true_map[a, b]);
                    if (b == bottom - 1)
                        Console.WriteLine("");
                }
            }
            if (count == 0)
                Console.Write("沒有路徑");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
