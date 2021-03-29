using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorDeIMC
{
    public partial class Form1 : Form
    {
        Single weight, height, imc; 

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            weight = 0;
            height = 0;
            imc = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                height = Convert.ToSingle(textBox1.Text);
                weight = Convert.ToSingle(textBox2.Text);
                imc = (weight / (height * height));
               
                if(imc < 18.5)
                {
                    label1.Text = "Magro";
                    label1.ForeColor = Color.Yellow;

                }else if((imc >= 18.5) && (imc < 25))
                {
                    label1.Text = "Normal";
                    label1.ForeColor = Color.Green;
                }
                else if ((imc >= 25) && (imc < 30))
                {
                    label1.Text = "Obeso!";
                    label1.ForeColor = Color.Yellow;
                }
                else if (imc >= 30)
                {
                    label1.Text = "Obeso Morbido!"; ;
                    label1.ForeColor = Color.Red;
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar executar a ação, verfique os campos e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
