using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        private AddDate AddDate;
        public Form1()
        {
            InitializeComponent();
            AddDate = new AddDate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //回傳生命靈數
            AddDate.Add(dateTimePicker1.Text);
        }
    }
}
