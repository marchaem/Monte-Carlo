﻿using System;
using Wrapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the values of the parameters in the TextBoxes
            WrapperClass wc = new WrapperClass();
            wc.getPriceCallEuro(nbSamples, maturity, S0, strike, sigma, r);
            prixLabel.Text = wc.getPrice().ToString();
            icLabel.Text = wc.getIC().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
