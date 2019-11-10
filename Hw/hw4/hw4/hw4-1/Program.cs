using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type a number lager than 1 : ");
            var input = int.Parse(Console.ReadLine());
            if ( input > 1)
            {
                var sum = Calculate(input);
                Console.WriteLine($"The sum is {sum}");
            }
            Console.ReadLine();
        }
        static int Calculate(int input)
        {
            var quotient = input / 2;
            if (input % 2 == 0)
            {
                return quotient * (-1);
            }
            else
            {
                return quotient * (-1) + input;
            }
        }
    }
}
