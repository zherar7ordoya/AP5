using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte
{
    class ClsPersona
    { //Propiedades

        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNac { get; set; }

        //Constructor que recibe parametro del mismo clase
        public ClsPersona(int _Cod, string _Nombre, string _Apellido, int _DNI, string _Correo, DateTime _FechaNac)
        {
            Cod = _Cod;
            Nombre = _Nombre;
            Apellido = _Apellido;
            DNI = _DNI;
            Correo = _Correo;
            FechaNac = _FechaNac;
        }
    }
}
