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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

        }

        
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Фаткуллина Рамиля Рафиковна, МКН 210");
        }
        Form2 f1 = new Form2();

        private void calculationFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.ShowDialog();
           
        }
        Form3 f = new Form3();
        

        private void answerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.ShowDialog();

        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
