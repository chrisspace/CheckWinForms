using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmClickablePhoto : Form
    {
        public frmClickablePhoto()
        {
            InitializeComponent();
        }

        private void pictureBoxAth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Athens", "First");

        }

        private void pictureBoxNaf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nafpaktos", "Second");
        }
    }
}
