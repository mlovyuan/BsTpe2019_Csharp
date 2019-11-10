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
            foreach (var item in TaxRateService.Table)
            {
                result += item.Compute(income);
            }


            return result;
        }
    }

        //先建立資料結構
    internal class TaxRate
    {
        private readonly decimal _rate;
        private readonly decimal _lower;
        private readonly decimal _upper;

        internal TaxRate(decimal rate, decimal lower, decimal upper)
        {
            _rate = rate;
            _lower = lower;
            _upper = upper;
        }
        internal decimal Compute(decimal income)
        {
            //如果收入大於較低的上界
            if (income > _upper)
            {
                return InnerCompute(_upper);
            }
            else if (income >= _lower && income <= _upper)
            {
                return InnerCompute(income);
            }
            return 0;
        }
        private decimal InnerCompute(decimal upper)
        {
            return (upper - _lower + 1) * _rate;
        }
    }
    internal static class TaxRateService
    {
        private static IEnumerable<TaxRate> _table;
        public static IEnumerable<TaxRate> Table
        {
            get
            {
                if (_table == null)
                {
                    CreateTable();
                }
                return _table;
            }
        }
        private static void CreateTable()
        {
            _table = new List<TaxRate>
            {
                new TaxRate(0.05m, 1, 540000),
                new TaxRate(0.12m, 540001, 1210000),
                new TaxRate(0.2m, 1210001, 2420000),
                new TaxRate(0.3m, 2420001, 4530000),
                new TaxRate(0.4m, 4530001, 10310000),
                new TaxRate(0.5m, 10310001, decimal.MaxValue)
            };
        }
    } 

}
