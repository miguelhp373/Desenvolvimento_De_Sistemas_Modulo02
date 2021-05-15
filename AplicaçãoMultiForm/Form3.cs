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
    public partial class Fibonacci : Form
    {
        int before, after;
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
            before = 1;
            after = 0;

            while (after < 100)
            {
                listBox1.Items.Add(Convert.ToString(after));
                comboBox1.Items.Add(Convert.ToString(after));
                after = after + before;
                before = after - before;



                if (after == 0)
                {
                    after = after++;
                }
            }
        }
    }
}
