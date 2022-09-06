namespace Step4CI
{
    // HIGH-LEVEL MODULE (CLASS)
    public class BLL_Employee
    {
        IDAL_Employee IDAL_EMPLOYEE;

        public BLL_Employee(IDAL_Employee DATA_ACCESS)
        {
            IDAL_EMPLOYEE = DATA_ACCESS;
        }

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return IDAL_EMPLOYEE.GetEmployeeDetails(id);
        }
    }
}
