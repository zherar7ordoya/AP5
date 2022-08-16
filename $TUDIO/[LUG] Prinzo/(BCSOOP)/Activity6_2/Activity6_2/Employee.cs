using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity6_2
{
    class Employee
    {
        public Employee(int empID)
        {
            //Constructor for existing employee
            //Simulates retrieval from database
            if (empID == 1)
            {
                _empID = empID;
                LoginName = "smith";
                PassWord = "js";
                SSN = 123456789;
                Department = "IS";
            }
            else if (empID == 2)
            {
                _empID = empID;
                LoginName = "jones";
                PassWord = "mj";
                SSN = 987654321;
                Department = "HR";
            }
            else
            {
                throw new Exception("Invalid Employee ID");
            }
        }
        public Employee()
        {
            _empID = GetNextID();
        }

        private int _empID;
        private string _loginName;
        private string _passWord;
        private int _SSN;
        private string _department;

        public int EmpID
        {
            get { return _empID; }
        }
        
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
       
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
       
        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
       
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        private int GetNextID()
        {
            //simulates the retrieval of next
            //available id from database
            return 100;
        }
        public string Update(string loginName, string password)
        {
            LoginName = loginName;
            PassWord = password;
            return "Security info updated.";
        }
        public string Update(int ssNumber, string department)
        {
            SSN = ssNumber;
            Department = department;
            return "HR info updated.";
        }
    }
}
