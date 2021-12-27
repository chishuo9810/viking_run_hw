using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74091051_w4_practice_1
{
    class Program
    {
        static int money1, money2;
        static int points1, points2;
        static int bet1, bet2;
        static int a=1;
        static int tool = 0;
        static string enter;
        static string[] playing_cards = { "spade A", "spade 2", "spade 3", "spade 4", "spade 5", "spade 6", "spade 7", "spade 8", "spade 9", "spade 10", "spade J", "spade Q", "spade K",
                                          "heart A", "heart 2", "heart 3", "heart 4", "heart 5", "heart 6", "heart 7", "heart 8", "heart 9", "heart 10", "heart J", "heart Q", "heart K",
                                          "dimond A", "dimond 2", "dimond 3", "dimond 4", "dimond 5", "dimond 6", "dimond 7", "dimond 8", "dimond 9", "dimond 10", "dimond J", "dimond Q", "dimond K",
                                          "club A", "club 2", "club 3", "club 4", "club 5", "club 6", "club 7", "club 8", "club 9", "club 10", "club J", "club Q", "club K"};
        static Random rndcards = new Random();
        static string[] player1cards = { "0", "0" };
        static string[] player2cards = { "0", "0" };
        static void dealing_cards()
        {
            player1cards[0] = playing_cards[rndcards.Next(0, 52)];
            do
            {
                player1cards[1] = playing_cards[rndcards.Next(0, 52)];
            }
            while (player1cards[0] == player1cards[1]);
            do
            {
                player2cards[0] = playing_cards[rndcards.Next(0, 52)];
            }
            while (player1cards.Contains(player2cards[0]));
            do
            {
                player2cards[1] = playing_cards[rndcards.Next(0, 52)];
            }
            while (player1cards.Contains(player2cards[1]) || player2cards[0] == player2cards[1]);
        }
        static void counting_points()
        {
            int size1 = player1cards.Length;
            int size2 = player2cards.Length;
            int countA = 0, count1ALL = 0, count2ALL = 0;
            for (int i = 0; i < size1; i++)
            {
                if (String.Compare(player1cards[i].Substring(player1cards[i].Length - 1, 1), "J") == 0)
                {
                    count1ALL += 10;
                }
                else if (String.Compare(player1cards[i].Substring(player1cards[i].Length - 1, 1), "Q") == 0)
                {
                    count1ALL += 10;
                }
                else if (String.Compare(player1cards[i].Substring(player1cards[i].Length - 1, 1), "K") == 0)
                {
                    count1ALL += 10;
                }
                else if (String.Compare(player1cards[i].Substring(player1cards[i].Length - 1, 1), "0") == 0)
                {
                    count1ALL += 10;
                }
                else if (String.Compare(player1cards[i].Substring(player1cards[i].Length - 1, 1), "A") == 0)
                {
                    countA++;
                }
                else
                {
                    count1ALL += int.Parse(player1cards[i].Substring(player1cards[i].Length - 1, 1));
                }
                switch (countA)
                {
                    case 1:
                        count1ALL += 11;
                        break;
                    case 2:
                        count1ALL += 12;
                        break;
                    case 3:
                        count1ALL += 13;
                        break;
                    case 4:
                        count1ALL += 14;
                        break;
                }
                countA = 0;
                points1 = count1ALL;
            }
            for (int i = 0; i < size2; i++)
            {
                if (String.Compare(player2cards[i].Substring(player2cards[i].Length - 1, 1), "J") == 0)
                {
                    count2ALL += 10;
                }
                else if (String.Compare(player2cards[i].Substring(player2cards[i].Length - 1, 1), "Q") == 0)
                {
                    count2ALL += 10;
                }
                else if (String.Compare(player2cards[i].Substring(player2cards[i].Length - 1, 1), "K") == 0)
                {
                    count2ALL += 10;
                }
                else if (String.Compare(player2cards[i].Substring(player2cards[i].Length - 1, 1), "0") == 0)
                {
                    count2ALL += 10;
                }
                else if (String.Compare(player2cards[i].Substring(player2cards[i].Length - 1, 1), "A") == 0)
                {
                    countA++;
                }
                else
                {
                    count2ALL += int.Parse(player2cards[i].Substring(player2cards[i].Length - 1, 1));
                }
                switch (countA)
                {
                    case 1:
                        count2ALL += 11;
                        break;
                    case 2:
                        count2ALL += 12;
                        break;
                    case 3:
                        count2ALL += 13;
                        break;
                    case 4:
                        count2ALL += 14;
                        break;
                }
                countA = 0;
                points2 = count2ALL;
            }
        }
        static void check_money(int money, int bet)
        {
            a = 0;
            if (money < bet)
            {
                Console.WriteLine("金錢不足，請重新輸入!");
                a = 1;
            }
            else if (bet == 0)
            {
                Console.WriteLine("金錢不能為零，請重新輸入!");
                a = 1;
            }
        }
        static void move(int player)
        {
            tool = 0;
            for (; ; )
            {
                enter = Console.ReadLine();
                if (String.Compare(enter, "1") == 0)
                {
                    giving_cards(player);
                    counting_points();
                    if (points1 > 21)
                    {
                        Console.Write("玩家1手牌: ");
                        for (int i = 0; i < player1cards.Length; i++)
                        {
                            if (i > 0)
                            {
                                Console.Write(",");
                            }
                            Console.Write(player1cards[i]);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("玩家1目前點數: " + points1);
                        Console.WriteLine("玩家1爆了，玩家2獲勝!");
                        Console.WriteLine(" ");
                        Console.WriteLine("玩家2獲勝，獲得" + bet1 + "金錢");
                        money1 -= bet1;
                        money2 += bet1;
                        tool = 1;
                        break;
                    }
                    else if (points2 > 21)
                    {
                        Console.Write("玩家2手牌: ");
                        for (int i = 0; i < player2cards.Length; i++)
                        {
                            if (i > 0)
                            {
                                Console.Write(",");
                            }
                            Console.Write(player2cards[i] );
                        }
                        Console.WriteLine("");
                        Console.WriteLine("玩家2目前點數: " + points2);
                        Console.WriteLine("玩家2爆了，玩家1獲勝!");
                        Console.WriteLine(" ");
                        Console.WriteLine("玩家1獲勝，獲得" + bet2 + "金錢");
                        money1 += bet2;
                        money2 -= bet2;
                        break;
                    }
                    else if (player == 1)
                    {
                        Console.Write("玩家1手牌: ");
                        for (int i = 0; i < player1cards.Length; i++)
                        {
                            if (i > 0)
                            {
                                Console.Write(",");
                            }
                            Console.Write(player1cards[i] );
                        }
                        Console.WriteLine("");
                        Console.WriteLine("玩家1目前點數: " + points1);
                        Console.WriteLine("玩家1行動(輸入1抽一張牌、輸入P停止抽牌):");
                    }
                    else if (player == 2)
                    {
                        Console.Write("玩家2手牌: ");
                        for (int i = 0; i < player2cards.Length; i++)
                        {
                            if (i > 0)
                            {
                                Console.Write(",");
                            }
                            Console.Write(player2cards[i]);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("玩家2目前點數: " + points2);
                        Console.WriteLine("玩家2行動(輸入1抽一張牌、輸入P停止抽牌):");
                    }
                }
                else if (String.Compare(enter, "P") == 0)
                {

                    counting_points();
                    if (player == 1)
                    {
                        Console.WriteLine("玩家1跳過，目前點數: " + points1);
                    }
                    else if (player == 2)
                    {
                        Console.WriteLine("玩家2跳過，目前點數: " + points2);
                        if (points1 > points2)
                        {
                            Console.WriteLine("玩家1獲勝，獲得" + bet2 + "金錢");
                            money1 += bet2;
                            money2 -= bet2;
                        }
                        else if (points2 > points1)
                        {
                            Console.WriteLine("玩家2獲勝，獲得" + bet1 + "金錢");
                            money1 -= bet1;
                            money2 += bet1;
                        }
                        else if (points1 == points2)
                        {
                            Console.WriteLine("平手!拿回各自的錢");
                        }
                    }
                    break;
                }
            }
        }
        static void giving_cards(int player)
        {
            if (player == 1)
            {
                string[] b = player1cards;
                Array.Resize(ref player1cards, player1cards.Length + 1);
                do
                {           
                    player1cards[player1cards.Length - 1] = playing_cards[rndcards.Next(0, 52)];
                }
                while (player2cards.Contains(player1cards[player1cards.Length - 1])|| b.Contains(player1cards[player1cards.Length - 1]));
            }
            else if (player == 2)
            {
                string[] b = player2cards;
                Array.Resize(ref player2cards, player2cards.Length + 1);
                do
                {
                    player2cards[player2cards.Length - 1] = playing_cards[rndcards.Next(0, 52)];
                }
                while (player1cards.Contains(player2cards[player2cards.Length - 1]) || b.Contains(player2cards[player2cards.Length - 1]));
            }
        }
        static void check_cards()
        {

        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("玩家1初始金錢: ");
                money1 = int.Parse(Console.ReadLine());
                Console.Write("玩家2初始金錢: ");
                money2 = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------\n");
            }
            catch(FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (money1 < 0 || money2 < 0)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                Environment.Exit(0);
            }
            for (; ; ) {
                dealing_cards();
                counting_points();
                Console.WriteLine("玩家1手牌: " + player1cards[0] + "," + player1cards[1]);
                Console.WriteLine("玩家1目前點數: " + points1);
                Console.WriteLine("玩家1目前金錢: " + money1);
                try
                {
                    do
                    {
                        Console.Write("請輸下注金額: ");
                        bet1 = int.Parse(Console.ReadLine());
                        check_money(money1, bet1);
                    }
                    while (a == 1);
                }
                catch
                {
                    Console.WriteLine("請輸入正確格式");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine(" ");
                Console.WriteLine("玩家2手牌: " + player2cards[0] + "," + player2cards[1]);
                Console.WriteLine("玩家2目前點數: " + points2);
                Console.WriteLine("玩家2目前金錢: " + money2);
                try
                {
                    do
                    {
                        Console.Write("請輸下注金額: ");
                        bet2 = int.Parse(Console.ReadLine());
                        check_money(money2, bet2);
                    }
                    while (a == 1);
                }
                catch
                {
                    Console.WriteLine("請輸入正確格式");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine(" ");
                Console.WriteLine("玩家1行動(輸入1抽一張牌、輸入P停止抽牌):");
                move(1);
                if (tool != 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("玩家2行動(輸入1抽一張牌、輸入P停止抽牌):");
                    move(2);
                }
                if (money1 <= 0 || money2 <= 0)
                {
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Array.Resize(ref player1cards, 2);
                    Array.Resize(ref player2cards, 2);
                    Console.WriteLine("-----------------------------------------\n");
                }
            }
        }
    }
}
