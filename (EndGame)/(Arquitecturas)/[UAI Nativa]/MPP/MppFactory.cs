using ABS;
using DAL;

namespace MPP
{
    public static class MppFactory
    {
        public static IEmployee CreateDalEmployee()
        {
            return new DalEmployee();
        }
    }
}
