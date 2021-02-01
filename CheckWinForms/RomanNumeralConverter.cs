using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmRomanNumeralConverter : Form
    {
        public frmRomanNumeralConverter()
        {
            InitializeComponent();
        }


        private void btnConverter_Click(object sender, EventArgs e)
        {
            const string rom_1 = "I";
            const string rom_2 = "II";
            const string rom_3 = "III";
            const string rom_4 = "IV";
            const string rom_5 = "V";

            int number = Convert.ToInt32(txtInput.Text);

            if (number > 1 && number < 6)
            {
                switch (number)
                {
                    case 1:
                        lblOutput.Text = rom_1;
                        break;
                    case 2:
                        lblOutput.Text = rom_2;
                        break;
                    case 3:
                        lblOutput.Text = rom_3;
                        break;
                    case 4:
                        lblOutput.Text = rom_4;
                        break;

                    case 5:
                        lblOutput.Text = rom_5;
                        break;
                }
            }
            else
                MessageBox.Show("Invalid input", "You can into numbers between 1 and 5");
            
        }
    }
}
