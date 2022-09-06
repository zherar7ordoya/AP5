namespace Step2
{
    class DAL_Factory
    {
        /// 
        /// <summary>
        /// 
        /// Inversion of Control Using Factory Pattern
        /// 
        /// As you can see, the EmployeeBusinessLogic class uses
        /// DataAccessFactory.GetCustomerEmployeeDataAccessObject() method to
        /// get an object of the EmployeeDataAccess class instead of creating
        /// it using the new keyword. Thus, we have inverted the control of
        /// creating an object of the dependent class from the
        /// EmployeeBusinessLogic class to the DataAccessFactory class.
        /// 
        /// </summary>
        /// 
        /// <returns>DAL_Employee</returns>
        /// 
        public static DAL_Employee GetDAL_EmployeeObject()
        {
            return new DAL_Employee();
        }
    }
}
