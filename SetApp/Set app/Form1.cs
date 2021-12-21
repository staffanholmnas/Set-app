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
        private readonly List<string> list1 = new List<string>();
        private readonly List<string> list2 = new List<string>();
        private readonly List<string> list3 = new List<string>();
        private readonly List<string> list4 = new List<string>();
        private readonly List<string> list5 = new List<string>();

        int addButtonClicked = 0;
        bool textbox3IsVisible = false;
        bool textbox4IsVisible = false;
        bool textbox5IsVisible = false;

        public Set_App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Add_To_List(int setBox)
        {
           
            string s = "";
            switch (setBox)
            {
                case 1:     s = richTextBox1.Text;   break;
                case 2:     s = richTextBox2.Text;   break;
                case 3:     s = richTextBox3.Text;   break;
                case 4:     s = richTextBox4.Text;   break;
                case 5:     s = richTextBox5.Text;   break;
                default:    break;
            }
            
            string[] values = s.Split(',').Select(sValue => sValue.Trim()).ToArray();
            foreach (var item in values)
            {
                switch (setBox)
                {
                    case 1: list1.Add(item);  break;
                    case 2: list2.Add(item);  break;
                    case 3: list3.Add(item);  break;
                    case 4: list4.Add(item);  break;
                    case 5: list5.Add(item);  break;
                    default:   break;    
                }
            }
        }

        private void Union_Click(object sender, EventArgs e)
        {
            List<string> union = new List<string>();
            Create_Result_Lists();
            union.AddRange(list1);
            union.AddRange(list2);
            if (textbox3IsVisible == true) union.AddRange(list3);
            if (textbox4IsVisible == true) union.AddRange(list4);
            if (textbox5IsVisible == true) union.AddRange(list5);
            union = union.Distinct().ToList();
            Print_Result(union);
        }

        private void Create_Result_Lists()
        {
            list1.Clear();
            list2.Clear();
            list3.Clear();
            list4.Clear();
            list5.Clear();
            Add_To_List(1);
            Add_To_List(2);
            if (textbox3IsVisible == true) Add_To_List(3);
            if (textbox4IsVisible == true) Add_To_List(4);
            if (textbox5IsVisible == true) Add_To_List(5);
           
        }

        private void Print_Result(List<string> list)
        {
            string result = "{ ";
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i] + (i < list.Count - 1 ? " , " : "");
            }
            result += " }";
            resultLabel.Text = result;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            list1.Clear();
            list2.Clear();
            list3.Clear();
            list4.Clear();
            list5.Clear();
            resultLabel.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox3.Hide();
            richTextBox4.Hide();
            richTextBox5.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textbox3IsVisible = false;
            textbox4IsVisible = false;
            textbox5IsVisible = false;
            addButtonClicked = 0;
        }

        private void Add_Set_Click(object sender, EventArgs e)
        {
            if (addButtonClicked == 0)
            {
                richTextBox3.Show();
                label3.Show();
                textbox3IsVisible = true;
                addButtonClicked++;
            }
            else if (addButtonClicked == 1)
            {
                richTextBox4.Show();
                label4.Show();
                textbox4IsVisible = true;
                addButtonClicked++;
            }
            else if (addButtonClicked == 2)
            {
                richTextBox5.Show();
                label5.Show();
                textbox5IsVisible = true;
                addButtonClicked++;
            }
        }

        private void Intersection_Click(object sender, EventArgs e)
        {
            Create_Result_Lists();
            List<string> intersection = list1.Intersect(list2).ToList();
            if (textbox3IsVisible == true) intersection = intersection.Intersect(list3).ToList();
            if (textbox4IsVisible == true) intersection = intersection.Intersect(list4).ToList();
            if (textbox5IsVisible == true) intersection = intersection.Intersect(list5).ToList();
            
            Print_Result(intersection);
        }

        private void Difference_Click(object sender, EventArgs e)
        {
            Create_Result_Lists();
            List<string> difference = list1.Except(list2).ToList();
            if (textbox3IsVisible == true) difference = difference.Except(list3).ToList();
            if (textbox4IsVisible == true) difference = difference.Except(list4).ToList();
            if (textbox5IsVisible == true) difference = difference.Except(list5).ToList();

            Print_Result(difference);
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Create_Result_Lists();
            List<string> product = new List<string>();
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (textbox3IsVisible == true)
                    {
                        for (int k = 0; k < list3.Count; k++)
                        {
                            if (textbox4IsVisible == true)
                            {
                                for (int l = 0; l < list4.Count; l++)
                                {
                                    if (textbox5IsVisible == true)
                                    {
                                        for (int m = 0; m < list5.Count; m++)
                                        {
                                            product.Add("(" + list1[i] + "," + list2[j] + "," + list3[k] + "," + list4[l] + "," + list5[m] + ")");
                                        }
                                    }
                                    else product.Add("(" + list1[i] + "," + list2[j] + "," + list3[k] + "," + list4[l] + ")");
                                }
                            }
                            else product.Add("(" + list1[i] + "," + list2[j] + "," + list3[k] + ")");
                        }
                    }
                    else product.Add("(" + list1[i] + "," + list2[j] + ")");
                }
            }
            product = product.Distinct().ToList();
            Print_Result(product);
        }
    }
}
