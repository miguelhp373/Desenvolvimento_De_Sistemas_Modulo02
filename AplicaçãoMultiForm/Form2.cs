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
    public partial class Tabuada : Form
    {
        int valueTab,Result;
        public Tabuada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                listBox1.Items.Clear();
                valueTab = Convert.ToInt32(textBox1.Text);

                for (int i = 0; i <= 10; i++)
                {
                    Result = valueTab * i;
                    comboBox1.Items.Add(Convert.ToString(valueTab) + "X" + Convert.ToString(i) + "=" + Result);
                    listBox1.Items.Add(Convert.ToString(valueTab) + "X" + Convert.ToString(i) + "=" + Result);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro, Campo Vazio, Ou Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
