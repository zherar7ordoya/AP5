using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6_1
{
    class Employee
    {
        private int _empID;
        public int EmployeeID
        {
            get { return _empID; }
        }

        private string _loginName;
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private int _securityLevel;
        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        public Boolean Login(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            //Data nomally retrieved from database.
            //Hard coded for demo only.
            if (loginName == "Smith" & password == "js")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;

            }
            else if (loginName == "Jones" & password == "mj")
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
