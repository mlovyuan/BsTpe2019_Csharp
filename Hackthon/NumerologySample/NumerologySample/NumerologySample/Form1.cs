using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerologySample
{
    /// <summary>
    /// 生命靈數
    /// http://www.twwiki.com/wiki/%E7%94%9F%E5%91%BD%E9%9D%88%E6%95%B8
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var birthday = dateTimePicker1.Value;
            var horoscope = Horoscopes.GetHoroscope(birthday);
            int index = NumerologyCollection.GetNumerologyIndex(birthday);
            string result = NumerologyCollection.GetNumerologyResult(index, horoscope);
            label3.Text = string.Empty;
            label3.Text += $"你的星座是 {horoscope.Name}{Environment.NewLine}";
            label3.Text += $"你的生命靈數 {index} : {result}";
        }

       
    }
}
