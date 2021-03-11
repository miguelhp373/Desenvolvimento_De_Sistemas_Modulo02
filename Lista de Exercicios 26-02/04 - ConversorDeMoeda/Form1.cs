using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMoeda
{
    public partial class Form1 : Form
    {
        double dollarCotation, realValueCotation, dollarConversion, conversionValue;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dollarCotation = Convert.ToDecimal(textBox1.Text);
            realValueCotation = Convert.ToDouble(textBox4.Text);
            //$1 * R$5,60

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conversionValue = Convert.ToDouble(textBox1.Text) * realValueCotation;
            textBox2.Text = Convert.ToString(conversionValue);
        }

        


    }
}
