using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalInfoMiniProj
{
    public partial class frmPersonalInfo : Form
    {
        public frmPersonalInfo()
        {
            InitializeComponent();
        }

        FrmInput frmInput;
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmInput = new FrmInput();
            frmInput.ShowDialog();
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            foreach(PersonalInfo p in frmInput.infoList)
            {
                txtOutput.Text += p.ToString();
                txtOutput.Text += Environment.NewLine;
            }
        }
    }
}
