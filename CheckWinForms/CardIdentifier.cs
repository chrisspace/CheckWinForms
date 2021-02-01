using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmCardIdentifier : Form
    {
        public frmCardIdentifier()
        {
            InitializeComponent();
        }

        private void pictureBoxAth_Click(object sender, EventArgs e)
        {
            lblOutput.Text="athens";
        }
    }
}
