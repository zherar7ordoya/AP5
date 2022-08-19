using ABS;
using MPP;

namespace BLL
{
    public static class BllFactory
    {
        public static IEmployee CreateMppEmployee()
        {
            return new MppEmployee();
        }
    }
}
