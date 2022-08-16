namespace MetodoFabrica
{
    public class CCreador
    {
        public static IVehiculo MetodoFabrica(int dinero)
        {
            IVehiculo temp = null;

            if (dinero > 1000000) temp = new CAvion();
            else if (dinero > 200000) temp = new CAuto();
            else temp = new CBici();

            return temp;
        }
    }

}
