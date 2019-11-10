using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerologySample
{
    /// <summary>
    /// 星座表
    /// </summary>
    public class Horoscope
    {
        /// <summary>
        /// 星座名稱
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 這個星座的起始月
        /// </summary>
        public int BeginMonth { get; private set; }
        /// <summary>
        /// 這個星座的起始日
        /// </summary>
        public int BeginDay { get; private set; }

        /// <summary>
        /// 這個星座的結束月
        /// </summary>
        public int EndMonth { get; private set; }

        /// <summary>
        /// 這個星座的結束日
        /// </summary>
        public int EndDay { get; private set; }

        public Horoscope(string name, int beginMonth, int beginDay, int endMonth, int endDay)
        {
            Name = name;
            BeginMonth = beginMonth;
            BeginDay = beginDay;
            EndMonth = endMonth;
            EndDay = endDay;
        }

        /// <summary>
        /// 檢查傳入的日期是否在這個星座
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        public bool IncludeCheck(DateTime birthday)
        {
            int year = birthday.Year;
            DateTime begin = new DateTime(year, BeginMonth, BeginDay);
            DateTime end = new DateTime(year, EndMonth, EndDay).AddDays(1);
            if (EndMonth < BeginMonth) //摩羯座
            {
                return (birthday > begin || birthday < end);
            }
            else
            {
                return (birthday >= begin && birthday < end);
            }
        }
    }

    public class Horoscopes
    {
        public static readonly string aries = "牡羊座";
        public static readonly string taurus = "金牛座";
        public static readonly string gemini = "雙子座";
        public static readonly string cancer = "巨蟹座";
        public static readonly string leo = "獅子座";
        public static readonly string virgo = "處女座";
        public static readonly string libra = "天秤座";
        public static readonly string scorpio = "天蠍座";
        public static readonly string sagittarius = "射手座";
        public static readonly string capricorn = "摩羯座";
        public static readonly string aquarius = "水瓶座";
        public static readonly string pisces = "雙魚座";

        private static IEnumerable<Horoscope> _items;
        public static IEnumerable<Horoscope> Items
        {
            get
            {
                if (_items == null)
                {
                    CreateItems();
                }
                return _items;
            }
        }

        private static void CreateItems()
        {
            _items = new List<NumerologySample.Horoscope>()
            {
                new Horoscope(aquarius, 1, 21, 2, 19),
                new Horoscope(pisces, 2, 20, 3, 20),
                new Horoscope(aries, 3, 21, 4, 19),
                new Horoscope(taurus, 4, 20, 5, 20),
                new Horoscope(gemini, 5, 21, 6, 21),
                new Horoscope(cancer, 6, 22, 7, 22),
                new Horoscope(leo, 7, 23, 8, 22),
                new Horoscope(virgo, 8, 23, 9, 22),
                new Horoscope(libra, 9, 23, 10, 23),
                new Horoscope(scorpio, 10, 24, 11, 21),
                new Horoscope(sagittarius, 11, 22, 12, 20),
                new Horoscope(capricorn, 12, 21, 1, 20),
            };

        }

        public static Horoscope GetHoroscope(DateTime birthday)
        {
            return Items.First((x) => x.IncludeCheck(birthday));
        }
    }
}
