using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSOBLL
{
    public class Employee
    {
        int employeeID;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        string loginName;

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        Boolean loggedIn = false;

        public Boolean LoggedIn
        {
            get { return loggedIn; }
        }

        public Boolean LogIn()
        {
            DALEmployee dbEmp = new DALEmployee();
            int empId;
            empId = dbEmp.LogIn(this.LoginName, this.Password);
            if (empId > 0)
            {
                this.EmployeeID = empId;
                this.loggedIn = true;
                return true;
            }
            else
            {
                this.loggedIn = false;
                return false;
            }

        }
    }
}