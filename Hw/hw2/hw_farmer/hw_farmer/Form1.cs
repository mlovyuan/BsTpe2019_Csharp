using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_farmer
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        private List<string> output;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBOxDataSource();
            ChangeData();
            //listBox1.ValueMember = "農夫";
            //listBox2.ValueMember = "農夫";
        }
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫", "狼", "羊", "菜"
            };
            _rightList = new List<string>();
            output = new List<string>();
        }
        private void SetListBOxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox3.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
            listBox3.DataSource = output;
            listBox1.SelectedItem = null;
            listBox2.SelectedItem = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BoatEvent(true, _leftList, listBox1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BoatEvent(false, _rightList, listBox2);
        }
        private void BoatEvent(bool direction, List<string> list, ListBox listbox)
        {
            if (listbox.SelectedItem == null)
            {
                MessageBox.Show("請選擇農夫和要運送的項目");
            }
            else if ((listbox.SelectedItem != null) && (listbox.SelectedItems.Count <= 2))
            {
 
                if ((list.Contains("農夫")) && (listbox.SelectedItems.Contains("農夫")))
                {
                    RenewItem(direction, listbox);
                    GameOver(list);
                    ChangeData();
                }
                else
                {
                    MessageBox.Show("需要農夫划船!");
                }
            }
            else
            {
                MessageBox.Show("船坐不下喔!");
            }
        }
        private void RenewItem(bool direction, ListBox listbox)
        {
            if (direction)
            {
                for (int i = 0; i < listbox.SelectedItems.Count; i++)
                {
                    string item = (string)listbox.SelectedItems[i];
                    _leftList.Remove(item);
                    _rightList.Add(item);
                    output.Add($"\n{item}被移動到了右岸");
                }
            }
            else
            {
                for (int i = 0; i < listbox.SelectedItems.Count; i++)
                {
                string item = (string)listbox.SelectedItems[i];
                _rightList.Remove(item);
                _leftList.Add(item);
                output.Add($"\n{item}被移動到了左岸");
                }
            }
        }
        private void GameOver(List<string> list)
        {
            //Check 
            if (!list.Contains("農夫"))
            {
                if (list.Contains("羊") && list.Contains("菜") && (!list.Contains("狼")))
                {
                    output.Add("\n菜被吃了GG");
                }
                else if (list.Contains("羊") && list.Contains("狼") && (!list.Contains("菜")))
                {
                    output.Add("\n羊被吃了GG");
                }
            }
            else if ((list == _rightList) && (listBox1.SelectedItems.Count == 4))
            {
                output.Add("\n通關，成功渡河!");
            }
        }
    }
}
