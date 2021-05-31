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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void versão10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new Tabuada();
            Form2.Show();
        }

        private void versão10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Form3 = new Fibonacci();
            Form3.Show();
        }

        private void versão10ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Form4 = new ParesImpares();
            Form4.Show();
        }

        private void versão20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form5 = new tabuada20();
            Form5.Show();
        }

        private void palavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form6 = new Palavras10();
            Form6.Show();
        }

        private void letrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form7 = new Palavras20();
            Form7.Show();
        }
    }
}
