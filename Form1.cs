using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fizz_buzz_rekord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int licz=1;

        public void btn1_Click(object sender, EventArgs e)
        {
            fizz_buzz gra = new fizz_buzz();
            liczba.Text = licz.ToString();
            fizz_buzz.Text = gra.fizzbuzz(licz);
            licz++;
        }
    }
}
