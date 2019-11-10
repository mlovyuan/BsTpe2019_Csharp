using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//奇偶數判斷 #2
//輸入一串以逗號分隔的整數數字字串，將其依照奇偶
//數分割為兩個數列，並且予以排序顯示結果
//例如：
// 輸入 8,7,9,3,11,6,2,18
// 結果為兩列
// 奇數 : 3,7,9,11
// 偶數 : 2,6,8,18

namespace hw1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一串以逗號分隔的整數數字: ");
            string input = Console.ReadLine();
            string[] input1 = input.Split(',');
            int[] x = new int[input1.Length];
            for (int i = 0; i < input.Length; i++)
            {
                x[i] = Convert.ToInt32(input1[i]);
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]%2 == 0)
                {

                }
            }
        }
    }
}
