using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//迴圈倒置 #1
//輸入一串以逗號分隔的字串，並將其反向顯示
//例如:
//輸入 1,2,3
//結果 3,2,1
/// <summary>
/// 改版，用SPLIT
/// 輸入 11,12,13
/// 結果 13,12,11
/// </summary>

namespace hw1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串以逗號分隔的數: ");
            string input = Console.ReadLine();
            for (int i = input.Length; i > 0; i--)
            {
                Console.Write(input[i-1]);
            }
            Console.ReadLine();
        }
    }
}
