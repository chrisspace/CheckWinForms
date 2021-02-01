using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmLatinTranslator : Form
    {
        public frmLatinTranslator()
        {
            InitializeComponent();
        }

        private void btnSinisterTransl_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "left";
            lblOutput.Left = 50;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "center";
            //lblOutput.Left = (this.ClientSize.Width-lblOutput.Width) /2;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnDexter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "right";
            lblOutput.Left = 240;
        }
    }
}
