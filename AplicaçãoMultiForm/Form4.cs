using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaçãoMultiForm
{
    public partial class ParesImpares : Form
    {
        int InputNumber, Totalizador, TotPar, TotImpar, somaPar, somaImpar;

        List<int> valuesStorage = new List<int>();
        List<int> valuesPar = new List<int>();
        List<int> valuesImpar = new List<int>();
        
        public ParesImpares()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InputNumber = Convert.ToInt32(textBox1.Text);

                valuesStorage.Add(InputNumber);
                Totalizador += InputNumber;

                if (InputNumber % 2 == 0)
                {
                    valuesPar.Add(InputNumber);
                    TotPar++;
                    somaPar += InputNumber;
                }
                else
                {
                    valuesImpar.Add(InputNumber);
                    TotImpar++;
                    somaImpar += InputNumber;
                }

                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Campo Vazio ou Valor Incorreto, Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(valuesStorage.Count);
            label4.Text = Convert.ToString(Totalizador);

           if(valuesStorage.Count < 1)
            {
                MessageBox.Show("Foi Inserido Apenas Um Número Insira Mais, e Tent Novamente");
            }
            else
            {
                label6.Text = Convert.ToString(TotPar);
                label7.Text = Convert.ToString(somaPar);

                label13.Text = Convert.ToString(TotImpar);
                label12.Text = Convert.ToString(somaImpar);

                foreach (int i in valuesPar)
                { 
                   listBox1.Items.Add(Convert.ToString(i));
                   
                }

                foreach (int i in valuesImpar)
                {
                    listBox2.Items.Add(Convert.ToString(i));
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valuesStorage.Clear();
            valuesPar.Clear();
            valuesImpar.Clear();
            InputNumber = 0;
            Totalizador = 0;
            TotPar = 0;
            TotImpar = 0;
            somaPar = 0;
            somaImpar = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";
            label7.Text = "";
            label13.Text = "";
            label12.Text = "";
        }
    }
}
