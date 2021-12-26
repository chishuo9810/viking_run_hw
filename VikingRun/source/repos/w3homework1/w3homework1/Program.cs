using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            double check1, check2;
            string NUMBER1, NUMBER2;
            Console.Write("1月1日星期幾(1~7):");
            NUMBER1 = Console.ReadLine();
            check1 = Convert.ToDouble(NUMBER1);
            if (check1 != (int)check1)
            {
                Console.Write("請輸入範圍內的整數");
                goto Z;
            }
            number1 = Convert.ToInt32(NUMBER1);
            Console.Write("從幾月開始(1~12):");
            NUMBER2 = Console.ReadLine();
            check2 = Convert.ToDouble(NUMBER2);
            if (check2 != (int)check2)
            {
                Console.Write("請輸入範圍內的整數");
                goto Z;
            }
            number2 = Convert.ToInt32(NUMBER2);
            string week = "Mon Tue Wed Thu Fri Sat Sun";
            string blank4 = "    ";
            string blank8 = "        ";
            string blank12 = "            ";
            string blank16 = "                ";
            string blank20 = "                    ";
            string blank24 = "                        ";
            switch (number1)
            {
                case 1:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        A:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write("            ");
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        B:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write("            ");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        C:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write("                        ");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }


                            Console.WriteLine();
                            Console.WriteLine();
                        D:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write("    ");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        E:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write("                ");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        F:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write("                        ");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        G:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write("        ");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        H:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write("                    ");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        I:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        J:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write("            ");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        K:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write("                    ");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto A;
                        case 3:
                            goto B;
                        case 4:
                            goto C;
                        case 5:
                            goto D;
                        case 6:
                            goto E;
                        case 7:
                            goto F;
                        case 8:
                            goto G;
                        case 9:
                            goto H;
                        case 10:
                            goto I;
                        case 11:
                            goto J;
                        case 12:
                            goto K;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                case 2:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        AA:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        BB:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        CC:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }


                            Console.WriteLine();
                            Console.WriteLine();
                        DD:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        EE:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        FF:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        GG:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        HH:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        II:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        JJ:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        KK:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto AA;
                        case 3:
                            goto BB;
                        case 4:
                            goto CC;
                        case 5:
                            goto DD;
                        case 6:
                            goto EE;
                        case 7:
                            goto FF;
                        case 8:
                            goto GG;
                        case 9:
                            goto HH;
                        case 10:
                            goto II;
                        case 11:
                            goto JJ;
                        case 12:
                            goto KK;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                case 3:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        AAAAA:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        BBBBB:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        CCCCC:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        DDDDD:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        EEEEE:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        FFFFF:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        GGGGG:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        HHHHH:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        IIIII:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        JJJJJ:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        KKKKK:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto AAAAA;
                        case 3:
                            goto BBBBB;
                        case 4:
                            goto CCCCC;
                        case 5:
                            goto DDDDD;
                        case 6:
                            goto EEEEE;
                        case 7:
                            goto FFFFF;
                        case 8:
                            goto GGGGG;
                        case 9:
                            goto HHHHH;
                        case 10:
                            goto IIIII;
                        case 11:
                            goto JJJJJ;
                        case 12:
                            goto KKKKK;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                case 4:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        AAA:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        BBB:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        CCC:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }


                            Console.WriteLine();
                            Console.WriteLine();
                        DDD:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        EEE:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        FFF:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        GGG:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        HHH:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        III:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        JJJ:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        KKK:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto AAA;
                        case 3:
                            goto BBB;
                        case 4:
                            goto CCC;
                        case 5:
                            goto DDD;
                        case 6:
                            goto EEE;
                        case 7:
                            goto FFF;
                        case 8:
                            goto GGG;
                        case 9:
                            goto HHH;
                        case 10:
                            goto III;
                        case 11:
                            goto JJJ;
                        case 12:
                            goto KKK;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                case 5:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        AAAA:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        BBBB:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        CCCC:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }


                            Console.WriteLine();
                            Console.WriteLine();
                        DDDD:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        EEEE:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        FFFF:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        GGGG:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        HHHH:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        IIII:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        JJJJ:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        KKKK:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto AAAA;
                        case 3:
                            goto BBBB;
                        case 4:
                            goto CCCC;
                        case 5:
                            goto DDDD;
                        case 6:
                            goto EEEE;
                        case 7:
                            goto FFFF;
                        case 8:
                            goto GGGG;
                        case 9:
                            goto HHHH;
                        case 10:
                            goto IIII;
                        case 11:
                            goto JJJJ;
                        case 12:
                            goto KKKK;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                case 6:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        AAAAA:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        BBBBB:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        CCCCC:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }


                            Console.WriteLine();
                            Console.WriteLine();
                        DDDDD:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        EEEEE:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        FFFFF:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        GGGGG:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        HHHHH:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        IIIII:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        JJJJJ:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        KKKKK:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto AAAAA;
                        case 3:
                            goto BBBBB;
                        case 4:
                            goto CCCCC;
                        case 5:
                            goto DDDDD;
                        case 6:
                            goto EEEEE;
                        case 7:
                            goto FFFFF;
                        case 8:
                            goto GGGGG;
                        case 9:
                            goto HHHHH;
                        case 10:
                            goto IIIII;
                        case 11:
                            goto JJJJJ;
                        case 12:
                            goto KKKKK;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                case 7:
                    switch (number2)
                    {
                        case 1:
                            Console.WriteLine("January");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        AAAAA:
                            Console.WriteLine("February");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 29; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        BBBBB:
                            Console.WriteLine("March");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        CCCCC:
                            Console.WriteLine("April");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        DDDDD:
                            Console.WriteLine("May");
                            Console.WriteLine(week);
                            Console.Write("");
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 0)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        EEEEE:
                            Console.WriteLine("June");
                            Console.WriteLine(week);
                            Console.Write(blank12);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 4)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        FFFFF:
                            Console.WriteLine("July");
                            Console.WriteLine(week);
                            Console.Write(blank20);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 2)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        GGGGG:
                            Console.WriteLine("August");
                            Console.WriteLine(week);
                            Console.Write(blank4);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 6)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        HHHHH:
                            Console.WriteLine("September");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        IIIII:
                            Console.WriteLine("October");
                            Console.WriteLine(week);
                            Console.Write(blank24);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 1)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        JJJJJ:
                            Console.WriteLine("November");
                            Console.WriteLine(week);
                            Console.Write(blank8);
                            for (int i = 1; i < 31; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 5)
                                    Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        KKKKK:
                            Console.WriteLine("December");
                            Console.WriteLine(week);
                            Console.Write(blank16);
                            for (int i = 1; i < 32; i++)
                            {
                                if (i < 10)
                                    Console.Write("  " + i + " ");
                                else
                                    Console.Write(" " + i + " ");
                                if (i % 7 == 3)
                                    Console.WriteLine();
                            }
                            break;
                        case 2:
                            goto AAAAA;
                        case 3:
                            goto BBBBB;
                        case 4:
                            goto CCCCC;
                        case 5:
                            goto DDDDD;
                        case 6:
                            goto EEEEE;
                        case 7:
                            goto FFFFF;
                        case 8:
                            goto GGGGG;
                        case 9:
                            goto HHHHH;
                        case 10:
                            goto IIIII;
                        case 11:
                            goto JJJJJ;
                        case 12:
                            goto KKKKK;
                        default:
                            Console.Write("超出範圍");
                            break;
                    }
                    break;
                default:
                    Console.Write("超出範圍");
                    break;
            }
        Z:
            Console.ReadKey();
        }
    }
}
