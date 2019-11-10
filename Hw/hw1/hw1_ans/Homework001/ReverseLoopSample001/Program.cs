using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLoopSample001
{
    /// <summary>
    /// 輸入一串以逗號分隔的字串，並將其反向顯示
    ///例如:
    ///輸入 1,2,3 結果 3,2,1
    ///輸入 11,12,13 結果 13,12,11
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("請輸入一串逗號字串分隔的字串");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }                
                Console.WriteLine(Reverse(input));
            }

            Console.WriteLine();
        }



        static string Reverse(string input)
        {
            string[] array = input.Split(new char[] { ',' });            
            return Contact(array);            
        }
       
        private static string Contact(string[] array)
        {
            string result = string.Empty;
            for(int i = 1; i < array.Length +1 ; i++)
            {
                result += $"{array[array.Length - i]},";
            }
            return result.Remove(result.Length - 1);
        }
    }
}
