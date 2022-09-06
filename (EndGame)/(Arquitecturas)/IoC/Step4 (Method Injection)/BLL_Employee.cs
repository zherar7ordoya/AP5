namespace Step4MI
{
    // HIGH-LEVEL MODULE (CLASS)
    public class BLL_Employee : IDAL_DependenciaEmpleado
    {
        public IDAL_Employee DAL_EMPLOYEE { get; set; }

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return DAL_EMPLOYEE.GetEmployeeDetails(id);
        }

        public void SetDependency(IDAL_Employee DAL_EMPLOYEE)
        {
            this.DAL_EMPLOYEE = DAL_EMPLOYEE;
        }
    }
}
