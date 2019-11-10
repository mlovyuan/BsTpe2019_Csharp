using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEventSample001
{
    /// <summary>
    /// 請輸入一個整數數字，判斷其結果為奇數或偶數，並且在 Console 上顯示結果。
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
                Console.WriteLine(GetDispalyString(number));
            }

            Console.ReadLine();
        }
        static string GetDispalyString(int number)
        {
            // return IsOdd(number) ? $"{number} 是奇數" : $"{number} 是偶數";
            if (IsOdd(number))
            {
                return $"{number} 是奇數";
            }
            return $"{number} 是偶數";
        }

        static bool IsOdd(int number)
        {
            return (number % 2 == 1);
        }
    }
}
