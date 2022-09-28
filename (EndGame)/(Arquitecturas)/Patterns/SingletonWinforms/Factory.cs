using System;

namespace SingletonWinforms
{
    public static class Factory
    {
        public static IDisposable CrearForm1() => new Form1();

        public static IDisposable CrearForm2() => new Form2();
    }
}
