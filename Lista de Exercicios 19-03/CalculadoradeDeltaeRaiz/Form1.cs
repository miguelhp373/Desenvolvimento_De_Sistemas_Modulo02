using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradeBhaskara
{
    public partial class Form1 : Form
    {
        double a, b, c, delta, raiz;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            delta = (b * b) - 4 * a * c;

            if (delta < 0)
            {
                MessageBox.Show("Não Existe Raiz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(delta == 0)
            {
                raiz = (-b + Math.Sqrt(delta)) / (2 * a);
                raizLabel.Text = Convert.ToString(raiz);
                deltaLabel.Text = Convert.ToString(delta);

            }
            else if (delta > 0)
            {
                raiz = (-b +(-Math.Sqrt(delta))) / (2 * a);
                raizLabel.Text = Convert.ToString(raiz);
                deltaLabel.Text = Convert.ToString(delta);
            }
        }
    }
}
