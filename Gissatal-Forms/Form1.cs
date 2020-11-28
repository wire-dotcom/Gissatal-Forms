using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissatal_Forms
{
    public partial class Form1 : Form
    {
        private int rndtal;
        private int antalGuess;
        public Form1()
        {
            InitializeComponent();
            Random rndint = new Random(); // Våran slumpmäsiga int variabel.            
            rndtal = rndint.Next(1, 101); // Här sätts värdet på variablen till ett slumpmässigt tal mellan 0 och 100.
            //int antalGuess = 0;
            richTextBox1.Text = ("Jag har valt ett tal, gissa vilket!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            antalGuess++;
            string strsvar = textBox1.Text;
            int intsvar = Convert.ToInt32(strsvar);
            if (intsvar == rndtal)
            {
                richTextBox1.Text = ("Du har gissat rätt, bra jobbat!                    Det tog dig " + antalGuess + "  försök");
            }
            else if (intsvar > rndtal)
            {
                richTextBox1.Text = ("Fel! Du har gissat för högt! Försök igen");
            }
            else
            {
                richTextBox1.Text = ("Fel! Du har gissat för lågt! Försök igen");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
