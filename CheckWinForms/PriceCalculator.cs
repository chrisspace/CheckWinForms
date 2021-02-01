using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmPriceCalculator : Form
    {
        public frmPriceCalculator()
        {
            InitializeComponent();
        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double tax = 0.23;
            const double tip = 0.01;
            double costOfMeal;
            double totalPrice;

            costOfMeal = Convert.ToDouble(txtBoxInput.Text);
            totalPrice = costOfMeal + (costOfMeal * tax) + (costOfMeal * tip);


            lstOutput.Items.Add("Cost of meal: " + costOfMeal.ToString());
            lstOutput.Items.Add("Tax: " + (costOfMeal*tax).ToString());
            lstOutput.Items.Add("Tip: " + (costOfMeal * tip).ToString());
            lstOutput.Items.Add("Total Price: " + totalPrice.ToString());
        }
    }
}
