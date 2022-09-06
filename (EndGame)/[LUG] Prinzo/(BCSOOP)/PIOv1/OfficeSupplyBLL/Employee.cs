using System;

namespace OfficeSupplyBLL
{
    public class Employee
    {
        int _employeeID;

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        string _loginName;

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        Boolean _loggedIn = false;

        public Boolean LoggedIn
        {
            get { return _loggedIn; }
        }

        public Boolean LogIn()
        {
            DALEmployee dbEmp = new DALEmployee();
            int empId;
            empId = dbEmp.LogIn(this.LoginName, this.Password);
            if (empId > 0)
            {
                this.EmployeeID = empId;
                this._loggedIn = true;
                return true;
            }
            else
            {
                this._loggedIn = false;
                return false;
            }

        }
    }
}
