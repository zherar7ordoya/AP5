using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSOBLL
{
    public static class DALUtility
    {
        public static string GetSQLConnection()
        {
            return @"Integrated Security=True;Data Source=.\SQLEXPRESS;" +
                "Initial Catalog=OfficeSupply";
        }
    }
}