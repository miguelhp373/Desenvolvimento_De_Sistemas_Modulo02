using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorDeNumeros
{
    public partial class Form1 : Form
    {
        double n1, n2, n3;
        string BigNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                n3 = Convert.ToDouble(textBox3.Text);

                if ((n1>n2)&&(n1>n3))
                {
                    BigNumber = Convert.ToString(n1);

                }else if ((n2>n1) && (n2>n3))
                {
                    BigNumber = Convert.ToString(n2);

                }else if ((n3 > n1) && (n3 > n2))
                {
                    BigNumber = Convert.ToString(n3);
                }
                else if ((n1==n2)&&(n1==n3)&&(n2==n3))
                {
                    MessageBox.Show("Numeros Iguais","Info");
                }

                label1.Text = "O Maior Número é " + BigNumber;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu Um Erro, Prencha os Campos novamente e Tente", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
