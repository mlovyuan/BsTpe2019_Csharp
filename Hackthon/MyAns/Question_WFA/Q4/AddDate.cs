using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class AddDate
    {
        public int Add(string date)
        {
            int sum = 0;
            foreach (var i in date)
            {
                sum += int.Parse(i.ToString());
            }
            return Check(sum);
           
        }
        private int Check(int sum)
        {
            int sum1 = 0;
            while (sum > 10)
            {
                sum1 = sum;
                sum = 0;
                foreach (var i in sum1.ToString())
                {
                    sum += int.Parse(i.ToString());
                }
            }
            return sum;
        }
    }
}
