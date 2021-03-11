using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        //declara as variaveis
        decimal num1, num2, resp;
        string Operacao;
        public Form1()
        {
            InitializeComponent();
           
        }
        //funções para adicionar numeros ao input
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        //funções de metodos matematicos

        private void button11_Click(object sender, EventArgs e)//soma
        {
            //button12.Enabled = false;
            num1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            button13.Enabled = true;
            Operacao = "Som";
        }

        private void button12_Click(object sender, EventArgs e)//subtracao
        {
            num1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            button13.Enabled = true;
            Operacao = "Sub";
        }

        private void button16_Click(object sender, EventArgs e)//multiplicação
        {
            num1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            button13.Enabled = true;
            Operacao = "Mult";
        }

        private void button15_Click(object sender, EventArgs e)//divisao
        {
            num1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            button13.Enabled = true;
            Operacao = "Div";
        }

        //botao limpar
        private void button14_Click(object sender, EventArgs e)//limpar
        {
            num1 = 0;
            num2 = 0;
            textBox1.Text = null;
            Operacao = "";
            button13.Enabled = false;
        }
        

        private void button17_Click(object sender, EventArgs e)//botão de virgula
        {
            textBox1.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)//resultado
        {
            num2 = Convert.ToDecimal(textBox1.Text);
            

            if(Operacao == "Som")
            {
                resp = num1 + num2;
            }else if (Operacao == "Sub")
            {
                resp = num1 - num2;
            }else if (Operacao == "Mult")
            {
                resp = num1 * num2;
            }else if (Operacao == "Div")
            {
                resp = num1 / num2;
            }
            
            textBox1.Text = resp.ToString();
            button13.Enabled = false;

        }

        
    }
}
