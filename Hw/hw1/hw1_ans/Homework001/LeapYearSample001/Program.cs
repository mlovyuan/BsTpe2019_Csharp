using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearSample001
{
    /// <summary>
    /// 請輸入一個中華民國年份，判斷是否為閏年

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入中華民國年");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int year = int.Parse(input);
                Display(year);
            }

            Console.ReadLine();
        }

        private static void Display(int year)
        {          
           Console.WriteLine ($"民國 {year} {GetResult(year)} 閏年");
        }

        private static string GetResult(int year)
        {
            TaiwanCalendar tw = new TaiwanCalendar();
            if (tw.IsLeapYear(year))
            {
                return "是";
            }
            return "不是";
        }

        //private static string GetResult(int year)
        //{           
        //    if (DateTime.IsLeapYear(1911+year))
        //    {
        //        return "是";
        //    }
        //    return "不是";
        //}


    }
}
