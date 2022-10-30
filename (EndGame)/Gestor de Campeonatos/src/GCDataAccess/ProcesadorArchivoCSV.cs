using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GCModels;

namespace GCDataAccess.ProcesadorCSV
{
    public static class ProcesadorArchivoCSV
    {
        public static string ArchivoPath(this string archivo)
        {
            return $"{ConfigurationManager.AppSettings["CarpetaCSV"]}\\{archivo}";
        }

        public static List<string> ConvertirArchivoTextoEnListaString(this string archivo)
        {
            if (File.Exists(archivo) == false)
            {
                return new List<string>();
            }
            return File.ReadAllLines(archivo).ToList();
        }

        public static List<PremioModel> ConvertirListaStringEnListaPremioModel(this List<string> lineas)
        {
            List<PremioModel> retorno = new List<PremioModel>();

            foreach (string linea in lineas)
            {
                string[] columnas = linea.Split(',');
                PremioModel premio = new PremioModel
                {
                    PremioID = int.Parse(columnas[0]),
                    Puesto = int.Parse(columnas[1]),
                    Nombre = columnas[2],
                    Monto = decimal.Parse(columnas[3]),
                    Porcentaje = double.Parse(columnas[4])
                };
                retorno.Add(premio);
            }
            return retorno;
        }

        public static void GuardarArchivoPremios(this List<PremioModel> modelos, string archivo)
        {
            List<string> lineas = new List<string>();

            foreach (PremioModel premio in modelos)
            {
                lineas.Add($"{premio.PremioID},{premio.Puesto},{premio.Nombre},{premio.Monto},{premio.Porcentaje}");
            }
            File.WriteAllLines(archivo.ArchivoPath(), lineas);
        }
    }
}
