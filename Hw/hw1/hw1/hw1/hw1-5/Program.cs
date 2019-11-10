using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//請輸入一個中華民國年份，判斷是否為閏年

namespace hw1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個中華民國年份: ");
            string input = Console.ReadLine();
            int input1 = int.Parse(input)+1911;
            Console.WriteLine(DateTime.IsLeapYear(input1) == true ? "4閏年" : "不4閏年");
            Console.ReadKey();
        }
    }
}
