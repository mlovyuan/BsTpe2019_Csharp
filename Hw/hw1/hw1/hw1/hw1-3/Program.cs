using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//迴圈倒置 #2
//請輸入一個整數數字，利用迴圈顯示以下結果：
//若輸入是 5 則結果為
// 5
// 44
// 333
// 2222
// 11111

namespace hw1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字: ");
            string input = Console.ReadLine();
            int input1 = int.Parse(input);
            Console.WriteLine(input1);
            for (int i = 1; i < input1; i++)
            {
                for (int j =0; j <= i; j++)
                {
                    Console.Write(input1-i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
