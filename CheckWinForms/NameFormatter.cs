using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmNameFormatter : Form
    {
        public frmNameFormatter()
        {
            InitializeComponent();
        }

        

        private void frmNameFormatter_Load(object sender, EventArgs e)
        {

        }

        private void btnFormatName_Click(object sender, EventArgs e)
        {
            string firstname;
            string middlename;
            string lastname;
            string title;

            firstname = txtFirstname.Text;
            middlename = txtLastname.Text;
            lastname = txtLastname.Text;
            title = txtTitle.Text;

            lstOutput.Items.Add(title + " " + firstname + " " + lastname);
            lstOutput.Items.Add(title + " " + firstname + " " +middlename+ " " +lastname);
            lstOutput.Items.Add(firstname + " " + lastname);
        }

    }
}
