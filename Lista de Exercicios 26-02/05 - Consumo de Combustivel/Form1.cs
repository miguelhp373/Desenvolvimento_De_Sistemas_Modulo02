using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05___Consumo_de_Combustivel
{
    public partial class Form1 : Form {

        double distance, time, speedMedia, consumeGas, km_litter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speedMedia = Convert.ToDouble(textBox1.Text);
            time = Convert.ToDouble(textBox2.Text);
            km_litter = Convert.ToDouble(textBox3.Text);

            distance = time * speedMedia;
            consumeGas = distance / km_litter;

            MessageBox.Show("A Velocidade Média é: " + Convert.ToString(speedMedia) + "km, Tempo Gasto: " + Convert.ToString(time) +
            ", Distância Percorrida: "+ Convert.ToString(distance)+", e o consumo foi de: "+Convert.ToString(consumeGas)+" Litros","Resultado");

            //DISTANCIA = TEMPO * VELOCIDADE
            //LITROS_USADOS = DISTÂNCIA / kml


        }
    }
}
