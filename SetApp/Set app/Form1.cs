using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set_app
{
    public partial class Set_App : Form
    {

        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        //int[] arr;

        int addClicked = 0;

        public Set_App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Union_Click(object sender, EventArgs e)
        {
            list1.Clear();
            list2.Clear();
            list1.Add(set_1_1.Value.ToString());
            list1.Add(set_1_2.Value.ToString());
            list1.Add(set_1_3.Value.ToString());
            list1.Add(set_1_4.Value.ToString());
            list1.Add(set_1_5.Value.ToString());

            list2.Add(set_2_1.Value.ToString());
            list2.Add(set_2_2.Value.ToString());
            list2.Add(set_2_3.Value.ToString());

            string result = "{ ";
            List<string> a3 = new List<string>();
            a3.AddRange(list1);
            a3.AddRange(list2);

            List<string> union = a3.Distinct().ToList();
            
            for (int i = 0; i < union.Count; i++)
            {
                result += union[i] + ( i < union.Count - 1 ? " , " : "");
            }
            result += " }";
            resultLabel.Text = result;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            set_1_1.Value = 0;
            set_1_2.Value = 0;
            set_1_3.Value = 0;
            set_1_4.Value = 0;
            set_1_5.Value = 0;

            set_2_1.Value = 0;
            set_2_2.Value = 0;
            set_2_3.Value = 0;
        }

        private void Add_button_1_Click(object sender, EventArgs e)
        {
            if (addClicked == 0)
            {
                set_1_3.Show();
                addClicked++;
            }
            else if (addClicked == 1)
            {
                set_1_4.Show();
                addClicked++;
            }
            else if (addClicked == 2)
            {
                set_1_5.Show();
                addClicked++;
            }
            else if (addClicked == 2)
            {
                set_1_5.Show();
                addClicked++;
            }
        }
    }
}
