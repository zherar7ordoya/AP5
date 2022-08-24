using ABS;
using BEL;

namespace MPP
{
    public class MppEmployee : IEmployee
    {
        readonly IEmployee dalEmployee = MppFactory.CreateDalEmployee();

        public BelEmployee GetEmployeeDetails(int id)
        {
            return dalEmployee.GetEmployeeDetails(id);
        }
    }
}
