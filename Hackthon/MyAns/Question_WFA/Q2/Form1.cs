using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        private ConvertTemp convertTemp;
        public Form1()
        {
            InitializeComponent();
            convertTemp = new ConvertTemp();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "請再次輸入";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                convertTemp.C = decimal.Parse(textBox1.Text);
                label1.Text = $"{textBox1.Text}°C = {convertTemp.Convert(true).ToString()}°F";
            }
            else if (radioButton2.Checked)
            {
                convertTemp.F = decimal.Parse(textBox1.Text);
                label1.Text = $"{textBox1.Text}°F = {convertTemp.Convert(false).ToString()}°C";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }
        private string AddNumber(string number)
        {
            return textBox1.Text += number;
        }

        //private void Button4_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("2");
        //}

        //private void Button5_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("3");
        //}

        //private void Button8_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("4");
        //}

        //private void Button7_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("5");
        //}

        //private void Button6_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("6");
        //}

        //private void Button11_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("7");
        //}

        //private void Button10_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("8");
        //}

        //private void Button9_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("9");
        //}

        //private void Button14_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber("0");
        //}

        //private void Button13_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = AddNumber(".");
        //}
    }
}
