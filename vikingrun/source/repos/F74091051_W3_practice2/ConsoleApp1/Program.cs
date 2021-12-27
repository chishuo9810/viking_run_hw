using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int map_size, bomb_number, bomb_x = 0, bomb_y = 0;
            String b,c;
            Console.Write("地圖大小(1~10):");
            b = Console.ReadLine();
            if (!int.TryParse(b, out map_size))
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (map_size > 10 || map_size < 1)
            {
                Console.WriteLine("超出範圍");
                Console.ReadKey();
                Environment.Exit(0);
            }

            int[,] map = new int[map_size, map_size];

            for(int i = 0; i < map_size; i++)
            {
                for(int j = 0; j < map_size; j++)
                {
                    map[i,j] = 0;
                }
            }

            Console.Write("地雷數量(1~10):");
            c = Console.ReadLine();
            if (!int.TryParse(c, out bomb_number))
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (bomb_number > 10 || bomb_number < 1)
            {
                Console.WriteLine("超出範圍");
                Console.ReadKey();
                Environment.Exit(0);
            }

            for(int i = 0; i < bomb_number; i++)
            {
                Console.Write("第個{0}地雷的位置(以空白區隔):", i);
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"\d+ \d+"))
                {
                    string[] inputnum = input.Split(' ');
                    bomb_x = int.Parse(inputnum[0]);
                    bomb_y = int.Parse(inputnum[1]);
                }
                else
                {
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if(bomb_x > 10 || bomb_x < 0)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (bomb_y > 10 || bomb_y < 0)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                map[bomb_y, bomb_x] = 9;

            }

            for(int i = 0; i < map_size; i++)
            {
                for(int j = 0; j < map_size; j++)
                {
                    if(map[i,j] == 9)
                    {
                        continue;
                    }

                    if(j != map_size - 1)
                    {
                        if (map[i, j + 1] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if(j != 0)
                    {
                        if (map[i, j - 1] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if(i != map_size - 1)
                    {
                        if (map[i + 1, j] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if(i != 0)
                    {
                        if (map[i - 1, j] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if(i != map_size - 1 && j != map_size - 1)
                    {
                        if (map[i + 1, j + 1] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if(i != 0 && j != map_size - 1)
                    {
                        if (map[i - 1, j + 1] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if(i != map_size - 1 && j != 0)
                    {
                        if (map[i + 1, j - 1] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                    if (i != 0 && j != 0)
                    {
                        if (map[i - 1, j - 1] == 9)
                        {
                            map[i, j]++;
                        }
                    }
                }
            }

            Console.WriteLine("---");

            for(int i = 0; i < map_size; i++)
            {
                for(int j = 0; j < map_size; j++)
                {
                    if(j == map_size - 1)
                    {
                        if (map[i, j] == 9)
                            Console.WriteLine("X");
                        else
                            Console.WriteLine("{0}", map[i, j]);
                    }
                    else
                    {
                        if (map[i, j] == 9)
                            Console.Write("X");
                        else
                            Console.Write("{0}", map[i, j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}