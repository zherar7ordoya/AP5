using ABS;
using BEL;

namespace DAL
{
    public class DalEmployee : IEmployee
    {
        public BelEmployee GetEmployeeDetails(int id)
        {
            BelEmployee belEmployee = DalFactory.CreateBelEmployee();

            belEmployee.ID = id;
            belEmployee.Name = "Gerardo Tordoya";
            belEmployee.Department = "Development";
            belEmployee.Salary = 600 * 1000;

            return belEmployee;
        }
    }
}
