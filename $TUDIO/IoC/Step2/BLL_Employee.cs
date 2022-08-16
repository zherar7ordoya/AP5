namespace Step2
{
    public class BLL_Employee
    {
        readonly DAL_Employee DAL_EMPLOYEE;

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public BLL_Employee()
        {
            DAL_EMPLOYEE = DAL_Factory.GetDAL_EmployeeObject();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return DAL_EMPLOYEE.GetEmployeeDetails(id);
        }
    }
}
