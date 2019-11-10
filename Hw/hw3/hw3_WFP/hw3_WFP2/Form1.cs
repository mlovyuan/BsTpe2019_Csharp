using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_WFP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = CreateData1();
            dataGridView3.DataSource = CreateData2();
        }
        private List<Sales> CreateData1()
        {
            string fileName = "supplies.csv";
            List<Sales> result = new List<Sales>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(',');
                    var sales = new Sales
                    {
                        Salesman = items[0],
                        Ballpoint = int.Parse(items[1]),
                        Pencil = int.Parse(items[2]),
                        Eraser = int.Parse(items[3]),
                        Ruler = int.Parse(items[4]),
                        Whiteout = int.Parse(items[5])
                    };
                    result.Add(sales);
                }
            }
            return result;
        }
        private List<Total> CreateData2()
        {
            string fileName = "supplies.csv";
            List<Total> result = new List<Total>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(',');
                    var total = new Total
                    {
                        Salesman = items[0],
                        Ballpoint = int.Parse(items[1]),
                        Pencil = int.Parse(items[2]),
                        Eraser = int.Parse(items[3]),
                        Ruler = int.Parse(items[4]),
                        Whiteout = int.Parse(items[5]),
                        TotalResult = int.Parse(items[1]) + int.Parse(items[2]) + int.Parse(items[3]) 
                        + int.Parse(items[4]) + int.Parse(items[5])
                    };
                    result.Add(total);
                }
            }
            int a = 0, b = 0, c = 0, d = 0, e =0;
            for (int i = 0; i < result.Count(); i++)
            {
                a += result[i].Ballpoint;
                b += result[i].Pencil;
                c += result[i].Eraser;
                d += result[i].Ruler;
                e += result[i].Whiteout;
            }
            var add = new Total
            {
                Salesman = "Total",
                Ballpoint = a,
                Pencil = b,
                Eraser = c,
                Ruler = d,
                Whiteout = e,
                TotalResult = a + b + c + e + d
            };
            result.Add(add);
            var word1 = result.Max((x) => x.TotalResult) ;
            label3.Text = result.Max((x) => x.TotalResult.ToString());
            var word2 = result.Max((x) => x.Ballpoint);
            //label3.Text = result.Max((x) => x.Ballpoint);

            return result;
        }
    }
}
