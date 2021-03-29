using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorDeNadador
{
    public partial class Form1 : Form
    {
        int age;
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           try
            {
                age = Convert.ToInt32(textBox1.Text);
                if ((age >= 5) && (age <= 7))
                {
                    result = "Nadador Infantil A";

                } else if ((age >= 8) && (age <= 10)) {
                   
                   result = "Nadador Infantil B";

                }
                else if ((age >= 11) && (age <= 13))
                {
                    result = "Nadador Juvenil A";
     
                }
                else if ((age >= 14) && (age <= 17))
                {
                    result = "Nadador Juvenil B";

                }
                else if ((age >= 18) && (age <= 25))
                {
                    result = " Nadador Sênior";
                }
                else
                {
                    result = "Idade Fora da Faixa Etária";
                }

                label2.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os Campos e Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
