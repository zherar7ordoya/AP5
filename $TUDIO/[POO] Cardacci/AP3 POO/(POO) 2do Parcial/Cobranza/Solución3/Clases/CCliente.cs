using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonattto_POO_2P.Clases
{
    public class CCliente
    {
        #region Campos
        List<CPrestamo> listaPrestamo;
        List<CPrestamo> lPrestamos;
        #endregion

        #region Constructores
        public CCliente() { }

        public CCliente(string pDocumento, string pNombre, string pApellido)
        { Documento = pDocumento; Nombre = pNombre; Apellido = pApellido; listaPrestamo = new List<CPrestamo>(); lPrestamos = new List<CPrestamo>(); }
        #endregion

        #region Propiedades
        public string Documento { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        #endregion

        #region Metodos
        public void EliminarTitular()
        {
            lPrestamos.Clear();
            lPrestamos = RetornaListaPrestamos();
            foreach (CPrestamo p in lPrestamos)
            {
                CPrestamo _auxPrestamo = (CPrestamo)p;
                _auxPrestamo._titular = null;
            }
        }

        public void EliminaPrestamosCliente()
        {
            listaPrestamo.Clear();
        }

        public void AsignarPrestamo(CPrestamo pPrestamo)
        {
            listaPrestamo.Add(pPrestamo);
        }

        public List<CPrestamo> RetornaListaPrestamos()
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo select p;
            lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                lPrestamos.Add(p);
            }
            return lPrestamos;
        }

        public List<CPrestamo> RetornaPrestamosVencidos()
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.Vencido == true select p;
            lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                lPrestamos.Add(p);
            }
            return lPrestamos;
        }

        public List<CPrestamo> RetornaPrestamosNoPagados()
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.Pagado == false select p;
            lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                lPrestamos.Add(p);
            }
            return lPrestamos;
        }

        public List<CPrestamo> RetornaPrestamosPagados()
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.Pagado == true select p;
            lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                lPrestamos.Add(p);
            }
            return lPrestamos;
        }
        #endregion
    }
}
