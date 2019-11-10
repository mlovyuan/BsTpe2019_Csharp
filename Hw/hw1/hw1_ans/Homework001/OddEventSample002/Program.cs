using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEventSample002
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {
                Console.WriteLine("請輸入一串以逗號分隔的整數數字");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                Display(input);

            }
            Console.ReadLine();
        }

        private static void Display(string input)
        {
            int[] source = GetNumbers(input);
            string odd = string.Empty;
            string even = string.Empty;

            for (int i = 0; i < source.Length; i++)
            {               
                if (IsOdd(source[i]))
                {
                    odd += $"{source[i]},";
                }
                else
                {
                    even += $"{source[i]},";
                }
            }                   
           
           
            Console.WriteLine($"奇數序列 {Remove(odd)}");
            Console.WriteLine($"偶數序列 {Remove(even)}");
        }

        static string Remove(string value)
        {
            if (value .Length > 0)
            {
                value = value.Remove(value.Length - 1);
            }
            return value;
        }

        static bool IsOdd(int number)
        {
            return (number % 2 == 1);
        }

        static int[] GetNumbers(string input)
        {
            string[] source = input.Split(new char[] { ',' });
            int[] result = new int[source.Length];
            int count = 0;
            foreach (var s in source)
            {
                result[count] = int.Parse(s);
                count++;
            }
            return Order(result);
        }


        /// <summary>
        /// 泡泡排序
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        static int[] Order(int[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i; j < source.Length; j++)
                {
                    if (source[i] > source[j])
                    {
                        int Temp = source[i];
                        source[i] = source[j];
                        source[j] = Temp; 
                    }
                }

            }
            return source;
        }


    }
}
