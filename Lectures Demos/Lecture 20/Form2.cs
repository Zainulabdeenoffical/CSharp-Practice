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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //label1.Text = "Current Time: " + DateTime.Now.ToString("HH:mm:ss tt");      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);
            //MessageBox.Show("1 second");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*for (int m = 0; m < 60; m++)
            {
                for (int s = 0; s < 60; s++)
                {
                    Console.WriteLine(m + "::" + s);
                    Thread.Sleep(1000);
                }
            }*/
        }
    }
}
