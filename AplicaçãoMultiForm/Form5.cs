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
    public partial class tabuada20 : Form
    {
        int startValue,endValue;
        public tabuada20()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                startValue = Convert.ToInt32(textBox1.Text);
                endValue = Convert.ToInt32(textBox2.Text);

                for (int i = startValue; i <= endValue; i++)
                {
                    for (int c = 0; c <= 10; c++)
                    {
                        listBox1.Items.Add(i + "X" + c + "=" + i * c);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Vazios, Verifique e Tente Novamente!");
                textBox1.Focus();
            }
         
        }
    }
}
