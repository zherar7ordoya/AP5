using System;

namespace SingletonWinforms
{
    public static class Factory
    {
        public static IDisposable CrearForm1()
        {
            return new Form1();
        }

        public static IDisposable CrearForm2()
        {
            return new Form2();
        }
    }
}
