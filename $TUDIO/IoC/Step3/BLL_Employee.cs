namespace Step3
{
    // HIGH-LEVEL MODULE (CLASS)
    public class BLL_Employee
    {
        readonly IGestor DAL_EMPLOYEE;

        public BLL_Employee()
        {
            DAL_EMPLOYEE = DAL_Factory.GetDAL_EmployeeObject();
        }

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return DAL_EMPLOYEE.GetEmployeeDetails(id);
        }
    }
}
