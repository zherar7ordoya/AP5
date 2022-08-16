using BEL;

namespace DAL
{
    public static class DalFactory
    {
        public static BelEmployee CreateBelEmployee()
        {
            return new BelEmployee();
        }
    }
}
