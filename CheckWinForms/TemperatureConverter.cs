using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmTemperatureConverter : Form
    {
        public frmTemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnConvToFahr_Click(object sender, EventArgs e)
        {
            decimal celc;
            decimal fahr;

            celc = Convert.ToDecimal(txtInput.Text);
            fahr = (9 / 5m) * (celc + 32);

            txtOutput.Text = fahr.ToString();
        }

        private void btnConvToCelc_Click(object sender, EventArgs e)
        {
            // C= (5/9) * (F-32)
            decimal celc;
            decimal fahr;

            fahr = Convert.ToDecimal(txtInput.Text);
            celc = (5/9m) * (fahr-32);

            txtOutput.Text = celc.ToString();
        }
    }
}
