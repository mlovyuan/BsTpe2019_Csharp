using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//奇偶數判斷 #1
//請輸入一個整數數字，判斷其結果為奇數或偶數，並
//且在 Console 上顯示結果。

namespace hw1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please type a number here: ");
            string input = Console.ReadLine();
            int input1 = int.Parse(input);
            //if (input1%2 == 0)
            //{
            //    Console.WriteLine("It's an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("It's an odd number.");
            //}

            Console.WriteLine(input1%2 ==0 ? "It's an even number.": "It's an odd number.");
            Console.ReadLine();
        }
    }
}
