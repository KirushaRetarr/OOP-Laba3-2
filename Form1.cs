using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox1.Text);
            switch (day) {
                case 1: textBox2.Text = "0"; break;
                case 2: textBox2.Text = "2"; break;
                case 3: textBox2.Text = "2"; break;
                case 4: textBox2.Text = "6"; break;
                case 5: textBox2.Text = "6"; break;
                case 6: textBox2.Text = "0"; break;
                case 7: textBox2.Text = "0"; break;
            }
        }
    }
}
