using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                Thread.Sleep(2000);

                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                Thread.Sleep(2000);

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                Thread.Sleep(2000);

            }
        }
    }
}
