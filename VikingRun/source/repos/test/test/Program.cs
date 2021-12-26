using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)                                                              //這不是java這是c#，給你看個概念，寫法改一下基本上對了
        {
            int[] a = { 1, 4, 2, 5, 6, 7 };
            Array.Sort(a);
            Console.WriteLine(a[1]);
            string input,name;                                                                       //宣告一個字串input
            int len;                                                                                 //宣告一個int 
            Console.Write("請輸入您的姓名:");
            name = Console.ReadLine();
            Console.Write("請輸入一組五位數的數字:");
            input = Console.ReadLine();                                                              //讀取一個字串      
            Console.Write(name + " 您好，您輸入的" + input);
            len = input.Length;                                                                      //字串長度
            for (int i = 0, j = len - 1; i < len / 2; i++, j--)                                      //判斷字串頭尾
            {
                if (input.Substring(i, 1)/*字串的前面*/ != input.Substring(j, 1)/*字串的後面*/)      //如果字串頭尾不相等，印出不是回文結束程式(注意:java的substring跟c#用法不一樣你不能直接抄)
                {
                    Console.WriteLine("不是回文!");                                                   //印出不是回文
                    Console.ReadKey();                                                               //這行你不用裡他
                    Environment.Exit(0);                                                             //結束程式
                }
            }
            Console.WriteLine("是回文!");                                                             //如果都相等的話，for迴圈裏面不會執行任何動作，離開迴圈後印出是回文並結束程式
            Console.ReadKey();                                                                       //這行你不用裡他
            Environment.Exit(0);                                                                     //結束程式
        }
    }
}
