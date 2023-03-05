using System;

namespace Captura
{
    public static class Herramientas
    {
        public static string GetFecha()
        {
            var fecha = DateTime.Now;
            return $"{fecha.Year}-{fecha.Month}-{fecha.Day}";
        }

        public static string GetHora()
        {
            var hora = DateTime.Now;
            return $"{hora.Hour}:{hora.Minute}";
        }
    }
}
