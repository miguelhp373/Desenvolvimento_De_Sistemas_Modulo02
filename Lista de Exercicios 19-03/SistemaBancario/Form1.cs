using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
{
    public partial class Form1 : Form
    {
        Double Saldo,sAtual,UpdateSaldo,ChequeVal,SaqueVal;

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaqueVal = Convert.ToDouble(textBox1.Text);
                sAtual = Convert.ToDouble(SaldoVisor.Text);

                if ((SaqueVal > sAtual)||(SaqueVal <= 0))
                {
                    warningmessage.ForeColor = Color.Red;
                    warningmessage.Text = "Operação Não Concluida, Valor Incorreto ou Saldo Abaixo!";
                }
                else
                {

                    Saldo = sAtual - SaqueVal;
                    SaldoVisor.Text = Convert.ToString(Saldo);
                    warningmessage.ForeColor = Color.Green;
                    warningmessage.Text = "Operação Concluida Com Sucesso";

                    extrato.Text += "\r - R$" + Convert.ToString(SaqueVal) + " Saque";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o Campo de Valor, e Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ChequeVal = Convert.ToDouble(textBox1.Text);
                sAtual = Convert.ToDouble(SaldoVisor.Text);

                if ((ChequeVal > sAtual)||(ChequeVal<=0))
                {
                    warningmessage.ForeColor = Color.Red;
                    warningmessage.Text = "Operação Não Concluida, Valor Incorreto ou Saldo Abaixo!";
                }
                else
                {

                    Saldo = sAtual - ChequeVal;
                    SaldoVisor.Text = Convert.ToString(Saldo);
                    warningmessage.ForeColor = Color.Green;
                    warningmessage.Text = "Operação Concluida Com Sucesso";

                    extrato.Text += "\r - R$" + Convert.ToString(ChequeVal) + " Cheque";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o Campo de Valor, e Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();

            if (SaldoVisor.Text == "")
            {
                SaldoVisor.Text = "0";
                sAtual = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSaldo = Convert.ToDouble(textBox1.Text);
                sAtual = Convert.ToDouble(SaldoVisor.Text);

                if(UpdateSaldo <= 0)
                {
                    MessageBox.Show("Verifique o Campo de Valor, e Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Saldo = UpdateSaldo + sAtual;

                    SaldoVisor.Text = Convert.ToString(Saldo);

                    warningmessage.ForeColor = Color.Green;
                    warningmessage.Text = "Operação Concluida Com Sucesso";

                    extrato.ForeColor = Color.Green;
                    extrato.Text += "\r + R$" + Convert.ToString(UpdateSaldo) + " Depósito";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o Campo de Valor, e Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
