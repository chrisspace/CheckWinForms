using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDataForm
{
    public partial class frmEmplData : Form
    {
        public frmEmplData()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();



        private void btnDisplay_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee("Chris", 1, "IT", "Junior"));
            employees.Add(new Employee("George", 12));
            employees.Add(new Employee());

            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            txtOutput.Clear();

            foreach(Employee e in employees)
            {
                txtOutput.Text += e.ToString();
                txtOutput.Text += Environment.NewLine;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employees[1].Department = "Development";
            employees[1].Position = "Mid";

            employees[2].Name = "John"; 
            employees[2].Id = 23;
            employees[2].Department = "Accounting";
            employees[2].Position = "Junior";

            DisplayEmployees();
        }

        private void frmEmplData_Load(object sender, EventArgs e)
        {

        }

        
    }
}
