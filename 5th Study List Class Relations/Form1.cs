using _5th_Study_List_Class_Relations.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5th_Study_List_Class_Relations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            Lab l = new Lab();
            l.Numb = textBox1.Text;
            l.Students = new List<Student>();

            listBox2.Items.Add(l); // we are adding the object's itself.
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            if(listBox2.SelectedIndex<0)
            {
                MessageBox.Show("Please select a Lab");
                return;
            }
            Student s = new Student()
            {
                Name = textBox1.Text,
                LastName = textBox2.Text
            };
            (listBox2.SelectedItems[0] as Lab).Students.Add(s);
            //In this expression, the first element of the selected item in the listbox (it will always be a single element since we can choose only one item at the moment) is cast to the Lab and unboxing it and we reach its Students list and add the student we created there...

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex>-1)
            {
                Text = (listBox2.SelectedItems[0] as Lab).Numb;
            };

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex>-1)
            {
                listBox1.Items.Clear();
                foreach(Student item in (listBox1.SelectedItems[0] as Lab).Students)
                {
                    listBox1.Items.Add(item.ReflectInfo());
                }
            };

        }
    }
}
