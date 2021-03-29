using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Try_Catch
{
    public partial class Form1 : Form
    {
        double plus, minus, mult, divis, result,n1,n2;
        string signal;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            plus = 0;
            minus = 0;
            divis = 0;
            mult = 0;
            signal = "";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//soma
        {
            signal = button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)//subtração
        {
            signal = button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)//multiplicação
        {
            signal = button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)//multiplicação
        {
            
            signal = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)//igual
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);

                if (signal == "+")
                {
                    result = n1 + n2;
                    label1.Text = Convert.ToString(result);
                }
                else if (signal == "-")
                {
                    result = n1 - n2;
                    label1.Text = Convert.ToString(result);
                }
                else if (signal == "*")
                {
                    result = n1 * n2;
                    label1.Text = Convert.ToString(result);
                }
                else if (signal == "/")
                {
                    result = n1 / n2;
                    label1.Text = Convert.ToString(result);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não Foi Possivel Completar a Operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










    }
}
