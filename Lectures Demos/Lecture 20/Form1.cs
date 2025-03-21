using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("Arrow Key Down");
            }*/

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {       
                this.pictureBox1.Location = new System.Drawing.Point(292, 90); 
            }
            if (e.KeyCode == Keys.Up)
            {              
                this.pictureBox1.Location = new System.Drawing.Point(292, 44);

            } if (e.KeyCode == Keys.Left)
            {   
                this.pictureBox1.Location = new System.Drawing.Point(272, 90);

            } if (e.KeyCode == Keys.Right)
            { 
                this.pictureBox1.Location = new System.Drawing.Point(222, 90);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar ==(char) Keys.Enter)
            {
         
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
