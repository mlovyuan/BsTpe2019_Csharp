using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用迴圈在螢幕上輸出 1~100
//  遇到 3 改成 A
//  遇到 5 改成 B
//  遇到 9 改成 C
//  遇到 0 改成 D

//善用string.Replace()
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i.ToString().Replace("3", "A").Replace("5", "B").Replace("9", "C").Replace("0", "D"));
            }
            Console.ReadLine();
        }
    }
}
