using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Male");
            }
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Female");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string colors="Your Favourite colors are ";
            if (checkBox1.Checked == true)
            {
                colors = colors + "Yellow ";
            }
            if (checkBox2.Checked == true)
            {
                colors = colors + "Red ";
            }
            if (checkBox3.Checked == true)
            {
                colors = colors + "Green ";
            }

            MessageBox.Show(colors);
        }
    }
}
