using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsVistaGrilla2
    {
        #region CAMPOS

        private List<ClsVistaGrilla2> ListaVistaGrilla2;

        #endregion

        #region PROPIEDADES
        //pongo la mayoria de las propiedades string para darle formato en la vista
        public string  Id { get; set; }
        public string Capital { get; set; }
        public int Plazo { get; set; }
        public string TNA { get; set; }
        public string MontoInteres { get; set; }
        public string TotalaRetornar { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }

        #endregion

        #region CONSTRUCTORES

        public ClsVistaGrilla2()
        {
            ListaVistaGrilla2 = new List<ClsVistaGrilla2>();
        }

        public ClsVistaGrilla2(string pId, string pCapital, int pPlazo, string pTEA, string pMontoInteres,
            string pTotalaRetornar, string pNombre, string pApellido, string pDni)
        {
            Id = pId;
            Capital = pCapital;
            Plazo = pPlazo;
            TNA = pTEA;
            MontoInteres = pMontoInteres;
            TotalaRetornar = pTotalaRetornar;
            Nombre = pNombre;
            Apellido = pApellido;
            Dni = pDni;
        }

        #endregion

        #region METODOS

        //llega por referencia una lista de prestamos.
        public List<ClsVistaGrilla2> RetornaListaVistaGrilla2(List<ClsPrestamo> pLP)
        {
            ListaVistaGrilla2.Clear();
            foreach(ClsPrestamo P in pLP)
            {   
                TNA = P.TasaAnual.ToString() + " %";
                //Le doy formato a las propiedades segun el tipo de prestamo
                if (P is ClsPrestamoPesos)
                {
                    Capital = "$ " + P.CapitalSolicitado;
                    MontoInteres = "$ "+ TruncarDecimales.Truncar(P.Interes()).ToString();
                    TotalaRetornar = "$ " + TruncarDecimales.Truncar(P.TotalaRetornar()).ToString();
                }
                else
                {
                    Capital = "U$S " + P.CapitalSolicitado;
                    MontoInteres = "U$S " + TruncarDecimales.Truncar(P.Interes()).ToString();
                    TotalaRetornar = "U$S " + TruncarDecimales.Truncar(P.TotalaRetornar()).ToString();
                }
                //Voy  agregando los nuevos objetos a la Vista
                ListaVistaGrilla2.Add(new ClsVistaGrilla2(P.IdPrestamo, Capital ,P.Plazo, TNA,MontoInteres,TotalaRetornar,
                    P.RetornaCliente().Nombre, P.RetornaCliente().Apellido, P.RetornaCliente().Dni));
            }
            //retorno la lista
            return ListaVistaGrilla2;
        }

        #endregion

        #region DESTRUCTOR 

        ~ClsVistaGrilla2() {  }

        #endregion

    }
}
