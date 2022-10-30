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

        public static List<string> CargarArchivo(this string archivo)
        {
            if (File.Exists(archivo) == false)
            {
                return new List<string>();
            }
            return File.ReadAllLines(archivo).ToList();
        }

        public static List<PremioModel> ConvertirEnPremioModel(this List<string> lineas)
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
                    Monto = int.Parse(columnas[3]),
                    Porcentaje = double.Parse(columnas[4])
                };
                retorno.Add(premio);
            }
            return retorno;
        }
    }
}
