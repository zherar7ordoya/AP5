using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Listas2
{
   public class ClsCliente:ICalcular
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ClsLocalidad oLoc { get; set; }
        public FormaPago oFPago { get; set; }

        internal List<ClsPaquete> LPaquetes = new List<ClsPaquete>();

        //constructor vacio
        public ClsCliente(){}

        //constructor sobrecargado
        public ClsCliente(int _Cod, string _Nom, string _Ape)
        {
            Codigo = _Cod;
            Nombre = _Nom;
            Apellido = _Ape;
         

        }

        double ICalcular.CalcularTotal(ClsCliente oCliente)
        {
            double MontoPagado = 0;
       
            if (oCliente.LPaquetes.Count > 0)
            {
                foreach (ClsPaquete item in oCliente.LPaquetes)
                {
                    MontoPagado += item.Abono;

                }

            }

            return MontoPagado;
        }

        //declaro el metodo del tipo delegado
        public delegate void DelInformar(List<ClsCliente> Lcli);

        //la variable del tipo delegado
        public DelInformar Informar;
    }
}
