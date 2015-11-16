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
    public partial class Form2 : Form
    {
        public Form2(string s)
        {
            InitializeComponent();
        }
       
        string s;
        double a;
        double b;
        double c;
        double d;
        int nod_recur(int num1, int num2)
        {
            int n = num1 % num2;
            num1 = num2;
            num2 = n;
            if (n > 0)
                return nod_recur(num1, num2);
            else
                return num1;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите число!");
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите число!");
                return;
            }
          
            
            {

                if (checkBox1.Checked || checkBox2.Checked)
                {
                    if (checkBox1.Checked)
                  {
                      if (textBox3.Text.Length == 0)
                      {
                          MessageBox.Show("Введите число!");
                          return;
                      }
                        d = a + b + c;
                        textBox4.Text = Convert.ToString(d);
                  }
                    if(checkBox2.Checked)
                    {
                        int num1 = Convert.ToInt32(textBox1.Text);
                        int num2 = Convert.ToInt32(textBox2.Text);
                        textBox5.Text = Convert.ToString(num1 * num2 / nod_recur(num1, num2));

                    }

                }
                else
                {
                    MessageBox.Show("Сделайте выбор операции!");
                    return;
                }


               

            }
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = Convert.ToDouble(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            b = Convert.ToDouble(s);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            s = textBox3.Text;
            c = Convert.ToDouble(s);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            d = a + b + c;
            textBox4.Text = Convert.ToString(d);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
