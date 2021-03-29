using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerficadorDeDiferencas
{
    
    public partial class Form1 : Form
    {
        int n1, n2,result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);

                if (n2 > n1)
                {
                    result = n2 - n1;
                }
                else
                {
                    result = n1 - n2;
                }

                label1.Text = "A diferença dos valores é "+ Convert.ToString(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Ao Executar a Ação, Verifique os Campos e Tente Novamente", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
