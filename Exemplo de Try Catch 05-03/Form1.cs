using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_de_Try_Catch
{
    public partial class Form1 : Form
    {
        double nota1, nota2, media;
        string nome;
        public Form1()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            nota1 = 0;
            nota2 = 0;
            media = 0;
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                nota1 = Convert.ToDouble(textBox2.Text);
                nota2 = Convert.ToDouble(textBox3.Text);

                media = (nota1 + nota2) / 2;

                nome = textBox1.Text;

                if (media >= 5)
                {
                    MessageBox.Show(nome + " Aprovado com Média " + Convert.ToString(media), "Aprovado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else if (media >= 3.5)
                {
                    MessageBox.Show(nome + " Recuperação com Média " + Convert.ToString(media), "Recuperação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpar();
                }
                else
                {
                    MessageBox.Show(nome + " Reprovado com Média " + Convert.ToString(media), "Reprovado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
            }
            catch(Exception){
                MessageBox.Show("Erro ao tentar Converter os Valores!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
                textBox1.Focus();
            }

           
           
        }
    }
}
