using ABS;
using BLL;

namespace UIL
{
    public static class UilFactory
    {
        public static IEmployee CreateBllEmployee()
        {
            return new BllEmployee();
        }
    }
}
