namespace Step3
{
    class DAL_Factory
    {
        public static IGestor GetDAL_EmployeeObject()
        {
            return new DAL_Employee();
        }
    }
}
