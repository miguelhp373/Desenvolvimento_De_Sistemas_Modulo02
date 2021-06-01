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
    public partial class Palavras20 : Form
    {
        string phraseReverse, phrase, trimphrase;
        int phraseLength, vogal01, vogal02, vogal03, vogal04, vogal05, countphrase;
        List<string> wordStorage = new List<string>();
        
        
        
        public Palavras20()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)//fecha o form
        {
            Close();
        }

        public void ClearComponents()//limpa todos os components
        {
            label1.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            vogal01 = 0;
            vogal02 = 0;
            vogal03 = 0;
            vogal04 = 0;
            vogal05 = 0;
            phrase = "";
            phraseReverse = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Clear();
            wordStorage.Clear();

        }

        public void PhraseLength()//verifica o tamanho da frase
        {
            phraseLength = Convert.ToInt32(textBox1.Text.Length);
            label1.Text = Convert.ToString(phraseLength);
        }

        public void RevertPhrase()//inverte a frase
        {
            phraseReverse = textBox1.Text;

            char[] chararray = phraseReverse.ToCharArray();
            Array.Reverse(chararray);
            string reversedText = new string(chararray);
            label12.Text = reversedText;
            reversedText = ""; 
        }

        public void VerifyVogals()//verifica as vogais
        { 
            int count;

            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                phrase = Convert.ToString(textBox1.Text[i]);
                wordStorage.Add(phrase.ToUpper());
            }

            count = Convert.ToInt32(wordStorage.Count);


            for (int i = 0; i < count; i++)
            {
                if ((wordStorage[i] == "A")||(wordStorage[i] == "Á") || (wordStorage[i] == "À") || (wordStorage[i] == "Â")|| (wordStorage[i] == "Ã"))
                {
                    vogal01++;

                }
                else if ((wordStorage[i] == "E") || (wordStorage[i] == "É") || (wordStorage[i] == "Ê") || (wordStorage[i] == "È"))
                {
                    vogal02++;

                }else if ((wordStorage[i] == "I") || (wordStorage[i] == "Ì") || (wordStorage[i] == "Í"))
                {
                    vogal03++;

                }else if ((wordStorage[i] == "O") || (wordStorage[i] == "Ó") || (wordStorage[i] == "Ò") || (wordStorage[i] == "Ô") || (wordStorage[i] == "Õ"))
                {
                    vogal04++;

                }else if((wordStorage[i] == "U") || (wordStorage[i] == "Ú") || (wordStorage[i] == "Ù") || (wordStorage[i] == "Û"))
                {
                    vogal05++;

                }
            }

            label7.Text = Convert.ToString(vogal01);
            label8.Text = Convert.ToString(vogal02);
            label9.Text = Convert.ToString(vogal03);
            label10.Text = Convert.ToString(vogal04);
            label11.Text = Convert.ToString(vogal05);
        }

        public void palindrome()//verifica se é palindromo
        {
            phraseReverse = textBox1.Text;

            char[] chararray = phraseReverse.ToCharArray();
            Array.Reverse(chararray);
            string reversedText = new string(chararray);

            if (reversedText == phraseReverse)
            {
                MessageBox.Show("Esta Frase é um Palíndromo!");
            }
            else
            {
                MessageBox.Show("Esta Frase NÃO é um Palíndromo!");
            }
            reversedText = "";
        }

        public void trimSpaces()//retira os espaços das palavras
        {
            trimphrase = "";
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if(Convert.ToString(textBox1.Text[i]) != " ")
                {
                    trimphrase += Convert.ToString(textBox1.Text[i]);
                }
            }
            label13.Text = trimphrase;
        }

        public void brokenWords()//quebras a palavra em linhas
        {
            countphrase = textBox1.Text.Length;
            phrase = textBox1.Text;

            for (int i = 0; i < countphrase; i++)
            {
                listBox1.Items.Add(Convert.ToString(phrase[i]));

            }
            phrase = "";
        }

        public void brokenPhrases()//quebra as frases
        {
            string PhraseBroken;

            PhraseBroken = "";
            int i = textBox1.Text.Length;

            for (int c = 0; c < i; c++)
            {
                if (Convert.ToString(textBox1.Text[c]) != " ")
                {
                    PhraseBroken += textBox1.Text[c];
                }
                else
                {
                    listBox2.Items.Add(PhraseBroken);
                    PhraseBroken = "";
                }
            }
            listBox2.Items.Add(PhraseBroken);

        }

       public void activeButtons()//ativa todos botoes
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = true;
        }

        public void disableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }



        // Executa as Funções atraves dos botoes

        private void button8_Click(object sender, EventArgs e)//limpa tudo
        {
            ClearComponents();
            activeButtons();
        }

        private void button9_Click(object sender, EventArgs e)//executa tudo
        { 
            PhraseLength();
            RevertPhrase();
            VerifyVogals();
            trimSpaces();
            brokenWords();
            brokenPhrases();
            palindrome();

            disableButtons();
        }

        private void Palavras20_Load(object sender, EventArgs e)//limpa ao abrir o form
        {
            ClearComponents();
        }

        private void button1_Click(object sender, EventArgs e)//calcula o tamanho da frase
        {
            PhraseLength();
            button1.Enabled = false;
            button9.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)//inverte a frase
        {
            RevertPhrase();
            button2.Enabled = false;
            button9.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)//calcula as vogais
        {
            VerifyVogals();
            button3.Enabled = false;
            button9.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)//verifica palindromo
        {
            palindrome();
            button4.Enabled = false;
            button9.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)//tira os espaços
        {
            trimSpaces();
            button5.Enabled = false;
            button9.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)//quebra as palavras em letras
        {
            brokenWords();
            button6.Enabled = false;
            button9.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)//quebra a frase em palavras
        {
            brokenPhrases();
            button7.Enabled = false;
            button9.Enabled = false;
        }
    }
}
