using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex02___Fibonacci
{
    public partial class Form1 : Form
    {
        int before, after;
        public Form1()
        {
            InitializeComponent();
        }


        void Fibonacci()
        {
            before = 0;
            after = Convert.ToInt32(startNumber.Text);

            while (after <100)
            {
                result.Text += Convert.ToString(after) + '-';
                after = after + before;
                before = after - before;



                if (after == 0)
                {
                    after = after++;
                }
            }
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fibonacci();

        }
    }
}
