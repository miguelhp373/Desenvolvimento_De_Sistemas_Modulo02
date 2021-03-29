using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadordeNumeroPar
{
    public partial class Form1 : Form
    {
        int numb;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numb = Convert.ToInt32(textBox1.Text);

                if(numb % 2 == 0)
                {
                    MessageBox.Show("O Numero Informado é PAR","Par", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O Numero Informado é IMPAR","Impar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o Campo e Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
