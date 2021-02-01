using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckWinForms
{
    public partial class frmDistanceCalculator : Form
    {
        public frmDistanceCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateDistance_Click(object sender, EventArgs e)
        {
            int speed;
            decimal timeTravelled;
            decimal distance;

            speed = Convert.ToInt32(txtSpeed.Text);
            timeTravelled = Convert.ToDecimal(txtTime.Text);

            distance = speed * timeTravelled;

            txtDistanceCalc.Text = distance.ToString();
        }
    }
}
