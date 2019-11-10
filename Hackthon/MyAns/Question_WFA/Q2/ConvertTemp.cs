using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class ConvertTemp
    {
        public decimal F { get; set; }
        public decimal C { get; set; }
        public decimal Convert(bool CtoF)
        {
            //Celsius攝氏   Fahrenheit華氏
            if (CtoF)
            {
                F = (decimal) 9 / 5 * C + 32;
                return Math.Round(F, 4);
            }
            else
            {
                C = (decimal) (F - 32) * 5 / 9;
                return Math.Round(C, 4);
            }
        }
    }
}
