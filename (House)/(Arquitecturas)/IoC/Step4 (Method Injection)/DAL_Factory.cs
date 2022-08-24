namespace Step4MI
{
    class DAL_Factory
    {
        public static IDAL_Employee GetDAL_EmployeeObject()
        {
            return new DAL_Employee();
        }
    }
}
