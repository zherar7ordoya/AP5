using System;

namespace Presentacion_IU
{
    public class ClsTecnico
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        #region Constructores
        //constructor vacio
        public ClsTecnico() { }

        //constructor sobrecargado
        public ClsTecnico(string _Nom, String _Ape, int _DNI)
        {
            Nombre = _Nom;
            Apellido = _Ape;
            DNI = _DNI;

        }

        #endregion

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " + this.DNI + " ";
        }

    }
}
