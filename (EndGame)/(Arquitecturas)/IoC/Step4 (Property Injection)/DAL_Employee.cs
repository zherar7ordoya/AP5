namespace Step4PI
{
    // LOW-LEVEL MODULE (CLASS)
    public class DAL_Employee : IDAL_Employee
    {
        public BEL_Employee GetEmployeeDetails(int id)
        {
            BEL_Employee emp = new BEL_Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000,
            };
            return emp;
        }
    }
}
