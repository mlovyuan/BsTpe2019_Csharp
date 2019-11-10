using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        private GetQuestion GetQuestion;
        private List<string> AddList;
        public Form1()
        {
            InitializeComponent();
            GetQuestion = new GetQuestion();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Text = "";
            textBox1.Clear();
            AddList = new List<string>();
            Random r = new Random();
            GetQuestion.Question = r.Next(1000, 10000);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (GetQuestion.Question.ToString() != null)
            {
                MessageBox.Show($"The answer is {GetQuestion.Question}");
            }
            else
            {
                MessageBox.Show("Please press the Start button!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Please type 4 numbers here");
            }
            else
            {
                GetQuestion.CheckAns(textBox1.Text);
                listBox1.DataSource = null;
                listBox1.DataSource = Add(GetQuestion.A, GetQuestion.B);
                if (GetQuestion.A == 4)
                {
                    MessageBox.Show("Correst");
                }
            }
        }
        private List<string> Add(int A, int B)
        {
            AddList.Add($"{textBox1.Text} : {GetQuestion.A}A{GetQuestion.B}B");
            return AddList;
        }
    }
}
