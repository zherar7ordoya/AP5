using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8_1
{
    public delegate void LoginEventHandler(string loginName, Boolean status);
    class Employee
    {
        public event LoginEventHandler LoginEvent;

        public void Login(string loginName, string password)
        {
            //Data normally retrieved from database.
            if (loginName == "Smith" && password == "js")
            {
                LoginEvent(loginName, true);
            }
            else
            {
                LoginEvent(loginName, false);
            }
        }
    }
}
