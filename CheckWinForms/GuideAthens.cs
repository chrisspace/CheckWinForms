using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmGuideAthens : Form
    {
        public frmGuideAthens()
        {
            InitializeComponent();
        }

               
        private void pictureBoxAthens_Click(object sender, EventArgs e)
        {

        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lblAcro.Visible = true;
            lblMoon.Visible = true;
            lblTheatre.Visible = true;
            lblThisio.Visible = true;
        }

        private void btnHideInfo_Click(object sender, EventArgs e)
        {
            lblAcro.Visible = false;
            lblMoon.Visible = false;
            lblTheatre.Visible = false;
            lblThisio.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
