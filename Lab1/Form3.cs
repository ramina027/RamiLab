using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form2 f3 = new Form2(textBox1.Text);
            f3.ShowDialog();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
