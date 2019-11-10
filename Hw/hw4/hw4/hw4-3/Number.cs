using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_3
{
    public class Number
    {
        public static void report(string input)
        {
            foreach(var item in Create.Table)
            {
                item.Print(input);
            }
        }

    }
    internal class DefNum
    {
        private readonly string _num;
        private readonly string _left_top;
        private readonly string _top;
        private readonly string _right_top;
        private readonly string _right_down;
        private readonly string _down;
        private readonly string _left_down;
        private readonly string _mid;
        internal DefNum(string num, string left_top, string top, string right_top, string right_down, string down, string left_down, string mid)
        {
            _num = num;
            _left_top = left_top;
            _top = top;
            _right_top = right_top;
            _right_down = right_down;
            _down = down;
            _left_down = left_down;
            _mid = mid;
        }
        public void Print(string input)
        {
            foreach (var k in input)
            {
                if (k.Equals(_num))
                {
                    Console.Write(_top);
                }
            }
            Console.WriteLine();
            foreach (var k in input)
            {
                if (k.Equals(_num))
                {
                    Console.Write(_left_top, _mid, _right_top);
                }
            }
            Console.WriteLine();
            foreach (var k in input)
            {
                if (k.Equals(_num))
                {
                    Console.Write(_left_down, _down, _right_down);
                }
            }
            Console.WriteLine();
        }
    }
    internal static class Create
    {
        private static IEnumerable<DefNum> _table;
        public static IEnumerable<DefNum> Table
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
            _table = new List<DefNum>
            {
                new DefNum("0", "|", "__", "|", "|", "__", "|", " "),
                new DefNum("1", " ", " ", "|", "|", " ", " ", " "),
                new DefNum("2", " ", "__", "|", " ", "__", "|", "__"),
                new DefNum("3", " ", "__", "|", "|", "__", " ", "__"),
                new DefNum("4", "|", " ", "|", "|", " ", " ", "__"),
                new DefNum("5", "|", "__", " ", "|", "__", " ", "__"),
                new DefNum("6", "|", " ", " ", "|", "__", "|", "__"),
                new DefNum("7", " ", "__", "|", "|", " ", " ", " "),
                new DefNum("8", "|", "__", "|", "|", "__", "|", "__"),
                new DefNum("9", "|", "__", "|", "|", "__", " ", "__"),
            };
        }
    }
}
