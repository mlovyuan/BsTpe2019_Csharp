using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_WFP
{
    public partial class Form1 : Form
    {
        private CountDay cd;
        public Form1()
        {
            InitializeComponent();
            cd = new CountDay();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            cd.Conversion(input);
            label2.Text = $"星期六有 {cd.Sat} 天";
            label3.Text = $"星期日有 {cd.Sun} 天";
        }

    }
    //public enum DaysOfWeek
    //{
    //    Saturday = 6, Sunday
    //}
}
