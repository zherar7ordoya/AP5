using System;

namespace BE
{
    public class TecnicoBE : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public bool Estado { get; set; }

        //*----------------------------------------------------=> CONSTRUCTORES

        // Vacío
        public TecnicoBE() { }

        // Sobrecargado
        public TecnicoBE(string _Nom, String _Ape, int _DNI)
        {
            Nombre = _Nom;
            Apellido = _Ape;
            DNI = _DNI;

        }
        //*-------------------------------------------------------------------*

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " + this.DNI + " ";
        }

        ///////////////////////////////////////////////////////////////////////
    }
}
