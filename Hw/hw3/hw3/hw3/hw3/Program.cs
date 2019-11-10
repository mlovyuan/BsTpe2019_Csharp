using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//設計出一程式，輸入四位數的阿拉伯數字，結果顯示出中文表示法
//例如：
// 輸入 9654
// 顯示 九六五四

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type any four Arabic numerals here: ");
            string input = Console.ReadLine();
            ConvertToC(input);
            Console.ReadLine();
        }

        static void ConvertToC(string x)
        {
            Dictionary<char, char> cvrt = new Dictionary<char, char>()
            { {'0','零' }, {'1', '一' }, {'2', '二' }, {'3', '三' }, {'4', '四' }, {'5', '五' }
            , {'6', '六' }, {'7', '七' }, {'8', '八' }, {'9', '九' }};
            foreach (var i in x)
            {
                Console.Write(cvrt[i]);
            }
        }


    }
}
