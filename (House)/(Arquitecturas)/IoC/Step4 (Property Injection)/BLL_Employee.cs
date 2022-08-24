// <copyright file="BLL_Employee.cs" company="Gerardo Tordoya">
// Copyright (c) Gerardo Tordoya. All rights reserved.
// </copyright>

namespace Step4PI
{
    // HIGH-LEVEL MODULE (CLASS)
    public class BLL_Employee
    {
        public IDAL_Employee IDAL_EMPLOYEE { get; set; }

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return IDAL_EMPLOYEE.GetEmployeeDetails(id);
        }
    }
}
