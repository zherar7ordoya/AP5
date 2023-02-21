using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activity6_2
{
    public partial class EmployeeInfoForm : Form
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = "";
            txtEmpID.Enabled = true;
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtSSN.Text = "";
            txtDepartment.Text = "";
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee();

            txtEmpID.Text = oEmployee.EmpID.ToString();
            txtEmpID.Enabled = false;
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtSSN.Text = "";
            txtDepartment.Text = "";
        }

        private void btnUpdateSI_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmpID.Text));

            MessageBox.Show(oEmployee.Update(txtLoginName.Text, txtPassword.Text));
            txtLoginName.Text = oEmployee.LoginName;
            txtPassword.Text = oEmployee.PassWord;
        }

        private void btnUpdateHR_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmpID.Text));
            MessageBox.Show(oEmployee.Update(int.Parse(txtSSN.Text), txtDepartment.Text));
            txtSSN.Text = oEmployee.SSN.ToString();
        }

        private void btnExistingEmp_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmpID.Text));

            txtEmpID.Enabled = false;
            txtLoginName.Text = oEmployee.LoginName;
            txtPassword.Text = oEmployee.PassWord;
            txtSSN.Text = oEmployee.SSN.ToString();
            txtDepartment.Text = oEmployee.Department;
        }
    }
}
