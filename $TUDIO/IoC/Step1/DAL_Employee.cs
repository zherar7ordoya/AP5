namespace Step1
{
    public class DAL_Employee
    {
        public BEL_Employee GetEmployeeDetails(int id)
        {
            // In real-time get the employee details from db
            //but here we are hard coded the employee details
            BEL_Employee emp = new BEL_Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
