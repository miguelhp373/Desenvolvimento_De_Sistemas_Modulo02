using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediaAluno
{
    public partial class Form1 : Form
    {
        decimal n1, n2, n3,notas,peso, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(textBox1.Text);
            n2 = Convert.ToDecimal(textBox2.Text);
            n3 = Convert.ToDecimal(textBox3.Text);
            peso = 2 + 3 + 5;
            notas = n1 + n2 + n3;
            media = notas/peso;

            MessageBox.Show("Média Final: " + Convert.ToString(media), "Resulltado Final");

        }
    }
}
