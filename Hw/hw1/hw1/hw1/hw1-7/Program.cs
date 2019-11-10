using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//假設A步行的速度為每秒1公尺，B步行的速度為每秒75公分，如果兩人相距300公尺並開始面對面前進，請使用程式計算兩人多久會相遇

namespace hw1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = 0, distance = 300;
            while (distance > 0)
            {
                distance += -(1.75 * time);
                time = time + 0.01;
            }
            Console.WriteLine($"用了{time}秒");
            Console.ReadLine();
        }
    }
}
