using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_WFP
{
    class CountDay
    {
        public int Sat { get; private set; }
        public int Sun { get; private set; }
        private DateTime d;

        internal void Conversion(string input)
        {
            d = new DateTime(int.Parse(input), 1, 1);
            int i = 1;
            Sat = 0; Sun = 0;
            while (d.Year == int.Parse(input))
            {
                if (d.DayOfWeek.ToString().Equals("Saturday"))
                {
                    Sat++;
                }
                else if (d.DayOfWeek.ToString().Equals("Sunday"))
                {
                    Sun++;
                }
                d = d.AddDays(i);
            }
        }
    }
}
