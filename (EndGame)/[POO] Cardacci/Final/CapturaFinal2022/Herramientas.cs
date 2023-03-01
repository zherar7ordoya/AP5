using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaFinal2022
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
