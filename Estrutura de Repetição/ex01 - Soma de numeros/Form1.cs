using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasDeRepeticao
{
    public partial class Form1 : Form
    {
        int end, num,imp,par,qtdimp,qtdpar;
        public Form1()
        {
            InitializeComponent();
        }
        

        void newNumber()
        {
            end = 0 ;
            end++;
            
            for (int i=0; i < end; i++)
            {
                num = Convert.ToInt32(textBox1.Text);

                if (num % 2 == 0)
                {
                    qtdpar++;
                    par = par + num;
                }
                else
                {
                    qtdimp++;
                    imp = imp + num;
                }
            }
            lb1.Text = Convert.ToString(par);
            lb2.Text = Convert.ToString(imp);
            lb3.Text = Convert.ToString(par + imp);
            lb4.Text = Convert.ToString(qtdpar);
            lb5.Text = Convert.ToString(qtdimp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newNumber();
        }
    }
}
