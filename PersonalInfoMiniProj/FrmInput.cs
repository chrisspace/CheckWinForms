using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalInfoMiniProj
{
    public partial class FrmInput : Form
    {
        public FrmInput()
        {
            InitializeComponent();
        }

        public List<PersonalInfo> infoList = new List<PersonalInfo>();

        string name;
        string address;
        int age;
        string phone;

        private bool ValidateInput()
        {
            name = txtName.Text;
            address = txtAddress.Text;
            phone = txtPhone.Text;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(phone) &&
                int.TryParse(txtAge.Text, out age))
                return true;
            else
                return false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                PersonalInfo info = new PersonalInfo(name,  address, age, phone);
                infoList.Add(info);
                MessageBox.Show("Info submitted!");
            }
            else
                MessageBox.Show("Please enter valid data", "Invalid input");

        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            if (infoList.Count > 0)
                this.Close();
            else
                MessageBox.Show("No info was submitted yet!");
        }
    }
}
