using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsListaVistaGrillaEvento
    {
        #region CAMPOS

        private List<ClsListaVistaGrillaEvento> ListaVistaGrillaEvento;

        #endregion

        #region PROPIEDADES
        //La variables las declaro en general como string para personalizarlas en la vista
        public string Id { get; set; }
        public string Capital { get; set; }
        public int Plazo { get; set; }
        public string TNA { get; set; }
        public string Interes { get; set; }
        public string TotalaRetornar { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Titular { get; set; }
        
        #endregion

        #region CONSTRUCTORES

        //Constructor sin parámetros donde instancio la lista vista.
        public ClsListaVistaGrillaEvento()
        {
            ListaVistaGrillaEvento = new List<ClsListaVistaGrillaEvento>();
        }

        //Constructor con parámetros
        public ClsListaVistaGrillaEvento(string pId, string pCapital, int pPlazo, string pTasa, string pInteres, string pTotalaRetornar,
            DateTime pFechaVencimiento, string pNombre)
        {
            Id = pId;
            Capital = pCapital;
            Plazo = pPlazo;
            TNA = pTasa;
            Interes = pInteres;
            TotalaRetornar = pTotalaRetornar;
            FechaVencimiento = pFechaVencimiento;
            Titular = pNombre;
           
        }

        #endregion

        #region METODOS

        public List<ClsListaVistaGrillaEvento> RetornaListaVistaGrillaEvento(List<ClsPrestamo> pLP)
        {
            ListaVistaGrillaEvento.Clear();
            foreach(ClsPrestamo P in pLP)
            {
               //Configuro detalles de los nombres de los valores a mostrar
                TNA = P.TasaAnual + " %";
                if (P is ClsPrestamoPesos)
                {
                    Capital = "$ " + P.CapitalSolicitado;
                    //Aca uso el método polimórfico para calcular el interes 
                    //Y el metodo static de Truncar, para solo ver 2 decimales en las grillas
                    Interes = "$" + TruncarDecimales.Truncar(P.Interes());
                    TotalaRetornar = "$ " + TruncarDecimales.Truncar(P.TotalaRetornar());
                }
                else
                {
                    Capital = "U$S " + P.CapitalSolicitado;
                    //Aca uso el método polimórfico para calcular el interes 
                    //Y el metodo static de Truncar, para solo ver 2 decimales en las grillas
                    Interes = "U$S " + TruncarDecimales.Truncar(P.Interes());
                    TotalaRetornar = "U$S " + TruncarDecimales.Truncar(P.TotalaRetornar());
                }
                if (P.RetornaCliente().Dni == null)
                {
                    Titular = "NO ASIGNADO"; 
                }
                else
                {
                    Titular = P.RetornaCliente().Apellido + ", " + P.RetornaCliente().Nombre;
                }
                //Voy agregando las nuevas instancias de la Lista Vista
                ListaVistaGrillaEvento.Add(new ClsListaVistaGrillaEvento(P.IdPrestamo, Capital, P.Plazo, TNA, Interes, TotalaRetornar,
                   P.FechaDevolucion, Titular));
            }
            //Retorno la Vista
            return ListaVistaGrillaEvento;
        }

        #endregion

        #region DESTRUCTOR 

        ~ClsListaVistaGrillaEvento()  {  }

        #endregion

    }
}
