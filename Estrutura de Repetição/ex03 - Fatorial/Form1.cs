using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03___Fatorial
{
    public partial class Form1 : Form
    {
        int num, cont, fat;
        string fatFormat;
        public Form1()
        {
            InitializeComponent();
        }

        void NumberFormat()
        {
            num = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= num; i++)
            {
                fatFormat += Convert.ToString(i) + "*";
            }
        }

        void Fatorial()
        {
            num = Convert.ToInt32(textBox1.Text);

            if(num == 0)
            {
                label3.Text = "0! = 1";
            }
            else
            {
                cont = 1;
                fat = 1;
                while (cont <= num)
                {
                    fat = fat * cont;
                    cont++;
                   
                    
                }

                label3.Text = Convert.ToString(num) + "!=" + Convert.ToString(fat) + "(" + Convert.ToString(fatFormat) + ")";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberFormat();//cria a formatação exemplo: 1*2*3*4*5
            Fatorial();//calcula o fatorial
        }
    }
}
