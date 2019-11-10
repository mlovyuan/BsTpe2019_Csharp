using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLoopSample002
{
    /// <summary>
    /// 請輸入一個整數數字，利用迴圈顯示以下結果：
    /// 若輸入是 5 則結果為 
    /// 5
    /// 44
    /// 333
    /// 2222
    /// 11111
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入一個整數數字");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int number = int.Parse(input);
                Display(number);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Display(int number)
        {
            int count = 1;
            Console.WriteLine("結果為");
            while (number > 0)
            {
               
                InnerDisplay(number, count);
                Console.WriteLine();
                number--;
                count++;
            }
        }

        private static void InnerDisplay(int number, int count)
        {
          
            for (int i = 0; i < count; i++)
            {
                Console.Write(number);
            }
        }
    }
}
