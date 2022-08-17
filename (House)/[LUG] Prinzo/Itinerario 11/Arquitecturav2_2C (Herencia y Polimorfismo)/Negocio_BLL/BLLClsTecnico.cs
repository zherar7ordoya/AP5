using System;

namespace Negocio_BLL
{
    public class BLLClsTecnico
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        #region "cosntructores"
        //constructor vacio
        public BLLClsTecnico() { }

        //constructor sobrecargado
        public BLLClsTecnico(string _Nom, String _Ape, int _DNI)
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
