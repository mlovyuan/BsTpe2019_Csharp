using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//算出 101~200 中間有多少個質數

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 200; i++)
            {
                //for  (int j = i-1; j > 1; j--)
                //{
                //    if (i % j == 0)
                //    {
                //        break;
                //    }
                //    if (i % j != 0 && j ==2)
                //    {
                //        Console.WriteLine(i);
                //    }
                //}
                var a = (int)Math.Sqrt(i);
                var x = Enumerable.Range(a, i - 1);
                var prime = x.FirstOrDefault((y) => i % y == 0);
                if (prime != i)
                {
                    continue;
                }

                //method2
                //var a = (int)Math.Sqrt(i);
                //var x = Enumerable.Range(2, a+1);
                //var prime = !x.any((y) => i % y == 0);

                //method3
                //var prime = x.any((y) => i % y != 0);

                Console.WriteLine(prime);
            }
            Console.ReadLine();
        }

        //public int Calculator(int i)
        //{
            
        //    var x = Enumerable.Range(2, i-1);
        //    for (int j = 2; j < i/2; j++)
        //    {
        //        var prime = x.FirstOrDefault((y) => i % y == 0);

        //    }
        //    Console.ReadLine();


        //    foreach (var k in x)
        //    {
        //    }

        //    return;

        //}
    }
}
