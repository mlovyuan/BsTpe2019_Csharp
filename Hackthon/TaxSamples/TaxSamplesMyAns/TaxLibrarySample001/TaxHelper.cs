using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLibrarySample001
{
    /// <summary>
    /// 
    /// </summary>
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            decimal result = 0;
            if (income > 10310000)
            {
                result = Six(income);
            }
            else if( income > 4530000)
            {
                result = Five(income);
            }
            else if (income > 2420000)
            {
                result = Four(income);
            }
            else if (income > 1210000)
            {
                result = Three(income);
            }
            else if (income > 540000)
            {
                result = Two(income);
            }
            else
            {
                result = One(income);
            }
            
            return result;
        }
        private static decimal One(decimal income)
        {
            decimal result = income * (decimal)0.05;
            return result;
        }
        private static decimal Two(decimal income)
        {
            var one =  One(540000);
            decimal result = (income - 540000) * (decimal)0.12 + one;
            return result;
        }
        private static decimal Three(decimal income)
        {
            var two = Two(1210000);
            decimal result = (income - 1210000) * (decimal)0.2 + two;
            return result;
        }
        private static decimal Four(decimal income)
        {
            var three = Three(2420000);
            decimal result = (income - 2420000) * (decimal)0.3 + three;
            return result;
        }
        private static decimal Five(decimal income)
        {
            var four = Four(4530000);
            decimal result = (income - 4530000) * (decimal)0.4 + four;
            return result;
        }
        private static decimal Six(decimal income)
        {
            var five = Five(10310000);
            decimal result = (income - 10310000) * (decimal)0.5 + five;
            return result;
        }
    }
}
