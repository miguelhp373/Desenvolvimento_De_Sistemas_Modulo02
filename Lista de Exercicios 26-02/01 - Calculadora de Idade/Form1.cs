using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador_de_Idade
{
    public partial class Form1 : Form
    {
        int age, ageHours, ageDays, ageMonths;
        string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //anoAtual = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            name = textBox1.Text;
            age = Convert.ToInt16(textBox2.Text);
            ageHours = Convert.ToInt32(age * (24 * 365));
            ageDays = Convert.ToInt32(age * 365);
            ageMonths = Convert.ToInt32(age * 12);

            //idade * 12; //meses
            //idade*365; //dias
            //idade * (24 * 365);  //horas

            MessageBox.Show(name + " Está Vivo A: " + Convert.ToString(ageHours)+" Horas " + Convert.ToString(ageDays)+
            " Dias " + Convert.ToString(ageMonths) + " Meses ","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Calcule essa idade em meses 
            //dias
            //1 ano 12meses = 365dias
        }
    }
}
