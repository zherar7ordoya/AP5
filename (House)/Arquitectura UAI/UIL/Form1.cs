/**
 * https://dotnettutorials.net/lesson/introduction-to-inversion-of-control/
 */

using BEL;
using System;
using static System.Environment;
using System.Windows.Forms;
using static System.Windows.Forms.Application;
using ABS;

namespace UIL
{
    /// <summary>
    /// CLASS: EmployeeService
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            IEmployee bllEmployee = UilFactory.CreateBllEmployee();
            BelEmployee belEmployee = bllEmployee.GetEmployeeDetails(1);

            textBox1.Text =
                $"        ID: {belEmployee.ID}" + NewLine +
                $"      Name: {belEmployee.Name}" + NewLine +
                $"Department: {belEmployee.Department}" + NewLine +
                $"    Salary: " + string.Format($"{belEmployee.Salary:C}");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
