using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetMiniProject
{
    public partial class FormPet : Form
    {
        public FormPet()
        {
            InitializeComponent();
        }

        Pet pet;
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            string name = txxtName.Text;
            string type = txtType.Text;
            decimal age = 0.0m;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(txtAge.Text, out age))
            {
                pet = new Pet(name, type, age);
            }
            else
                MessageBox.Show("Please correct your input","Invalid input");
        }

        private void btnDipslayData_Click(object sender, EventArgs e)
        {
            try
            {
                lstOutput.Items.Add("Pet's name: "+ pet.Name);
                lstOutput.Items.Add("Pet's type: " + pet.Type);
                lstOutput.Items.Add("Pet's age: " + pet.Age);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please enter the pet data first!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
