using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeSalarioLiquido
{
    public partial class Form1 : Form
    {
        double SalarioBruto, FaixaInss, inss, Dependentes , ValDependentes, BaseCalculo, FaixaImpRenda, impDeRenda, Descontos, SalLiquido;

        //Referencias Para Testes
        //https://valorinveste.globo.com/ferramentas/calculadoras/calculadora-salario-liquido/

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Inss()
        {
            double DeducaoInss;
            

            if (SalarioBruto <= 1100.00)
            {
                DeducaoInss = 0;
                FaixaInss = 0.075;

                inss = (SalarioBruto * FaixaInss) - DeducaoInss;

            }else if (SalarioBruto <= 2203.48)
            {
                DeducaoInss = 16.50;
                FaixaInss = 0.09;

                inss = (SalarioBruto * FaixaInss) - DeducaoInss;
            }else if (SalarioBruto <= 3305.22)
            {
                DeducaoInss = 82.60;
                FaixaInss = 0.12;

                inss = (SalarioBruto * FaixaInss) - DeducaoInss;

            }
            else if (SalarioBruto <= 6433.57)
            {
                DeducaoInss = 148.71;
                FaixaInss = 0.14;

                inss = (SalarioBruto * FaixaInss) - DeducaoInss;

            }
            else
            {
                DeducaoInss = 148.71;
                FaixaInss = 0.14;

                inss = (6433.57 * FaixaInss) - DeducaoInss;
            }

        }


        public void ImpostoDeRenda()
        {
            double deducaoImpRenda;
            

            Dependentes = Convert.ToDouble(textDep.Text);

            ValDependentes = Dependentes * 189.59;
            BaseCalculo = SalarioBruto - inss - ValDependentes;

            if (BaseCalculo <= 1903.98)
            {
                FaixaImpRenda = 0;
                deducaoImpRenda = 0;
                impDeRenda = (BaseCalculo * FaixaImpRenda) - deducaoImpRenda;
            }
            else if (BaseCalculo <= 2826.65)
            {
                FaixaImpRenda = 0.075;
                deducaoImpRenda = 142.80;
                impDeRenda = (BaseCalculo * FaixaImpRenda) - deducaoImpRenda;
            }
            else if (BaseCalculo <= 3751.05)
            {
                FaixaImpRenda = 0.15;
                deducaoImpRenda = 354.80;
                impDeRenda = (BaseCalculo * FaixaImpRenda) - deducaoImpRenda;
            }
            else if (BaseCalculo <= 4664.68)
            {
                FaixaImpRenda = 0.225;
                deducaoImpRenda = 636.13;
                impDeRenda = (BaseCalculo * FaixaImpRenda) - deducaoImpRenda;
            }
            else
            {
                FaixaImpRenda = 0.275;
                deducaoImpRenda = 869.36;
                impDeRenda = (BaseCalculo * FaixaImpRenda) - deducaoImpRenda;
            }
        }

        public void SalarioLiquido()
        {
            

            Descontos = inss + impDeRenda;
            SalLiquido = SalarioBruto - Descontos;

            label8.Text = textName.Text + " Esse Foi Resultado:";
            txtSB.Text = "R$" + Convert.ToString(Math.Round(SalarioBruto,2));
            txtIN.Text = "- R$" + Convert.ToString(Math.Round(inss,2));
            txtIR.Text = "- R$" + Convert.ToString(Math.Round(impDeRenda,2));
            txtSL.Text = "R$" + Convert.ToString(Math.Round(SalLiquido,2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorHora, Aulas;

                ValorHora = Convert.ToDouble(textValor.Text);
                Aulas =  Convert.ToDouble(textAulas.Text);
                SalarioBruto = ValorHora * Aulas * 4.5;

                Inss();
                ImpostoDeRenda();
                SalarioLiquido();

                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }


        }




        private void button2_Click(object sender, EventArgs e)//limpar
        {
            txtIN.Text = "";
            txtIR.Text = "";
            txtSB.Text = "";
            txtSL.Text = "";
            textAulas.Text = "";
            textDep.Text = "";
            textValor.Text = "";
            textName.Text = "";
            label8.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
