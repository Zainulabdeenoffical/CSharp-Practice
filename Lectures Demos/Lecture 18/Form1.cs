﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(textBox1.Text);
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            string names = null;
            foreach (string s in listBox1.SelectedItems)
            {
                names = names + s+"\n";
            }
            MessageBox.Show("Students: " + names);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }
    }
}
