using ABS;
using BEL;

namespace BLL
{
    public class BllEmployee : IEmployee
    {
        readonly IEmployee mppEmployee = BllFactory.CreateMppEmployee();

        public BelEmployee GetEmployeeDetails(int id)
        {
            return mppEmployee.GetEmployeeDetails(id);
        }
    }
}
