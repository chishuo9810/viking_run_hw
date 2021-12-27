using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string SIZE, NUM, BOMBPLACE1, BOMBPLACE2, BOMBPLACE3,BOMBPLACE4;
            double size, num, bombplace2, bombplace3;
            Console.Write("地圖大小(1~10):");
            SIZE = Console.ReadLine();  
            num = Convert.ToDouble(SIZE);
            Console.Write("地雷數量(1~10):");
            NUM = Console.ReadLine();
            size = Convert.ToDouble(NUM);
            if (num > 10 || num < 1 || size > 10 || size < 1)
            {
                Console.WriteLine("超出範圍");
                if (num != (int)num || size != (int)size)
                    Console.WriteLine("請輸入範圍內整數");
                goto A;
            }
            string[,] bomb = new string[(int)num, (int)num];
            for (int i = 0; i < num; i++)
                for (int j = 0; j < num; j++)
                    bomb[i, j] = "0";
            for (int j = 0; j < size; j++)
            {
                Console.Write("第" + j + "個地雷的位置(以空白區隔):");
                BOMBPLACE1 = Console.ReadLine();
                if (BOMBPLACE1.Length < 3)
                {
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    goto A;
                }
                else if (BOMBPLACE1.Length > 3)
                {
                    for(int i = 0; i < BOMBPLACE1.Length; i++)
                    {
                        if(BOMBPLACE1.Substring(i, 1) == ".")
                        {
                            Console.WriteLine("請輸入兩個以空白區隔的整數");
                            goto A;
                        }
                        else if(BOMBPLACE1.Substring(i,1)==" "&& BOMBPLACE1.Substring(i+1, 1) != " ")
                        {
                            Console.WriteLine("超出範圍");
                            goto A;
                        }  
                    }
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    goto A;
                }
                else if (BOMBPLACE1.Length == 3)
                {
                    if (BOMBPLACE1.Substring(1, 1) != " ")
                    {
                        Console.WriteLine("請輸入兩個以空白區隔的整數");
                        goto A;
                    }
                }
                BOMBPLACE2 = BOMBPLACE1.Substring(0, 1);
                BOMBPLACE3 = BOMBPLACE1.Substring(2, 1);
                BOMBPLACE4 = BOMBPLACE1.Substring(1, 1);
                bombplace2 = Convert.ToDouble(BOMBPLACE2);
                bombplace3 = Convert.ToDouble(BOMBPLACE3);
                bomb[(int)bombplace2, (int)bombplace3] = "X";
            }
            int result, count;
            for (double i = 0; i < num; i++)
            {
                for (double j = 0; j < num; j++)
                {
                    if (num == 1)
                        break;
                    else if (String.Compare("X", bomb[(int)i, (int)j]) == 0)
                        ;
                    else if (i == 0 && j == 0)                                  //在左上角
                    {
                        count = 0;
                        if (String.Compare(bomb[0,1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[1, 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[1, 0], "X") == 0)
                            count++;
                        bomb[0, 0] = Convert.ToString(count);
                    }
                    else if (i == num - 1 && j == num - 1)                       //在右下角
                    {
                        count = 0;
                        if (String.Compare(bomb[(int)num - 2, (int)num - 2], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)num - 2, (int)num - 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)num - 1, (int)num - 2], "X") == 0)
                            count++;
                        bomb[(int)num - 1, (int)num - 1] = Convert.ToString(count);
                    }
                    else if (i == 0 && j == num - 1)                           //左下
                    {
                        count = 0;
                        if (String.Compare(bomb[1, (int)num - 2], "X") == 0)
                            count++;
                        if (String.Compare(bomb[0, (int)num - 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[1, (int)num - 1], "X") == 0)
                            count++;
                        bomb[0, (int)num - 1] = Convert.ToString(count);
                    }
                    else if (i == num - 1 && j == 0)                             //右上
                    {
                        count = 0;
                        if (String.Compare(bomb[(int)num - 2, 0], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)num - 2, 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)num - 1, 1], "X") == 0)
                            count++;
                        bomb[(int)num - 1, 0] = Convert.ToString(count);
                    }
                    else if (i == 0)                                     //左邊
                    {
                        count = 0;

                            if (String.Compare(bomb[0, (int)j+1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[0, (int)j -1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[1, (int)j +1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[1, (int)j], "X") == 0)
                                count++;
                            if (String.Compare(bomb[1, (int)j -1], "X") == 0)
                                count++;
                        bomb[0, (int)j] = Convert.ToString(count);
                    }
                    else if (j == 0)                              //上面
                    {
                        count = 0;
                            if (String.Compare(bomb[(int)i -1, 0], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i + 1, 0], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i +1, 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i, 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i -1, 1], "X") == 0)
                                count++;
                            bomb[(int)i, 0] = Convert.ToString(count);
                    }
                    else if (i == num - 1)                     //右邊
                    {
                        count = 0;
                            if (String.Compare(bomb[(int)num - 1, (int)j + 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)num - 1, (int)j - 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)num - 2, (int)j + 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)num - 2, (int)j], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)num - 2, (int)j - 1], "X") == 0)
                                count++;
                            bomb[(int)i, (int)j] = Convert.ToString(count);        
                    }
                    else if (j == num - 1)                //  下面
                    {
                        count = 0;
                            if (String.Compare(bomb[(int)i - 1, (int)num - 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i + 1, (int)num - 1], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i - 1, (int)num - 2], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i, (int)num - 2], "X") == 0)
                                count++;
                            if (String.Compare(bomb[(int)i + 1, (int)num - 2], "X") == 0)
                                count++;
                            bomb[(int)i, (int)j] = Convert.ToString(count);                   
                    }
                    else
                    {
                        count = 0;
                        if (String.Compare(bomb[(int)i + 1, (int)j + 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i + 1, (int)j], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i + 1, (int)j - 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i - 1, (int)j + 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i - 1, (int)j], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i - 1, (int)j - 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i, (int)j + 1], "X") == 0)
                            count++;
                        if (String.Compare(bomb[(int)i, (int)j - 1], "X") == 0)
                            count++;
                        bomb[(int)i, (int)j] = Convert.ToString(count);
                    }
                    }
                }
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    Console.Write(bomb[j, i]);
                    if (j == num - 1)
                        Console.WriteLine("");
                }
            }
            A:
                Console.ReadKey();
            }
        }
    }