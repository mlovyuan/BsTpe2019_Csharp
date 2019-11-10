using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//n個包裝紙可以換一個糖果，若想吃x個糖果，最少需要買y個糖果?
//本題有公式可以解，但這個題目要求使用迴圈。

namespace hw1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("商店規定用多少糖果紙換一顆呢? ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Console.Write("想吃幾顆糖? ");
            string input1 = Console.ReadLine();
            int x = int.Parse(input1);
            int y = 0, c, p = 0, t = 0;
            //while(t != x)
            //{
            //    p = y % n;
            //    c = y / n;
            //    t = y + c;
            //    c += p;
            //    y++;
            //}
            //Console.WriteLine($"至少要買{y}顆糖");
            //Console.ReadLine();
            while (x> 0)
            {
                y++; //先買一顆
                x--; //願望滿足，糖扣1
                p++; //因為糖扣1，所以包裝紙得1
                while ( p == n ) //如果包裝紙夠換一顆糖
                {
                    x--; //得到糖果，願望再扣1
                    p = 1; //吃了一顆，糖果紙總共剩一張
                }
            }
        }
    }
}
