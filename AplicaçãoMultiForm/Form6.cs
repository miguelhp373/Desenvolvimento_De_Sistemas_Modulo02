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
    public partial class Palavras10 : Form
    {
        List<string> wordsStorage1 = new List<string>();
        List<string> wordsStorage2 = new List<string>();
        string words, statusType, phrase, shareword;
        int countLength, countphrase;


  
        public Palavras10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void execAddWords(string palavra)
        {
            listBox1.Items.Add(palavra);
        }

        private void Palavras10_Load(object sender, EventArgs e)
        {
            statusType = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if ((statusType == "") || (statusType == "Disable"))
            {
                listBox1.Items.Clear();
            }
            else if (statusType == "Active")
            {
                if(Convert.ToInt32(listBox1.Items.Count) > 0)
                {
                    listBox1.Items.Remove(listBox1.Items[0]);
                }
    
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if ((statusType == "") || (statusType == "Disable"))
            {
                listBox2.Items.Clear();
            }
            else if (statusType == "Active")
            {
                if (Convert.ToInt32(listBox2.Items.Count) > 0)
                {
                    listBox2.Items.Remove(listBox2.Items[0]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(listBox1.Items.Count) > 0)
            {
                shareword = Convert.ToString(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
                listBox2.Items.Add(shareword);
                shareword = "";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            countLength = Convert.ToInt32(listBox2.Items.Count);

            for (int i = 0; i < countLength; i++)
            {
                wordsStorage2.Add(Convert.ToString(listBox2.Items[i]));
            }


            listBox2.Items.Clear();
            for (int i = 0; i < wordsStorage2.Count; i++)
            {
                listBox1.Items.Add(wordsStorage2[i]);
               
            }
            wordsStorage2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listBox2.Items.Count) > 0)
            {
                shareword = Convert.ToString(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
                listBox1.Items.Add(shareword);
                shareword = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            countLength = Convert.ToInt32(listBox1.Items.Count);

            for(int i = 0; i< countLength; i++) {
                wordsStorage1.Add(Convert.ToString(listBox1.Items[i]));
            }


            listBox1.Items.Clear();
            for(int i = 0; i< wordsStorage1.Count; i++)
            {
                listBox2.Items.Add(wordsStorage1[i]);
               
            }
            wordsStorage1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((statusType == "")||(statusType == "Disable"))
            {
                words = textBox1.Text;
                execAddWords(words);
                words = "";
            }else if(statusType == "Active")
            {
               countphrase = textBox1.Text.Length;
               phrase = textBox1.Text;

               for(int i = 0; i < countphrase; i++)
                {
                    listBox1.Items.Add(Convert.ToString(phrase[i]));

                }
                phrase = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((statusType == "Disable") || (statusType == ""))
            {
                statusType = "Active";
                button9.BackColor = Color.Green;
            }
            else if(statusType == "Active")
            {
                statusType = "Disable";
                button9.BackColor = Color.Red;
            }
        }
    }
}
