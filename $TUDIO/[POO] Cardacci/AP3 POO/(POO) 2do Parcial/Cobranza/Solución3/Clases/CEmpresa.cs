using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonattto_POO_2P.ClasesVista;

namespace Tonattto_POO_2P.Clases
{
    public class CEmpresa : ICloneable
    {
        #region Campos
        List<CPrestamo> listaPrestamo;
        List<CCliente> listaClientes;
        List<CPrestamo> _lPrestamos;
        public delegate void Vencimiento(List<CPrestamo> pListaPrestamo);
        public event Vencimiento PrestamoVencido;
        #endregion

        #region Constructores
        public CEmpresa() { listaPrestamo = new List<CPrestamo>(); listaClientes = new List<CCliente>(); _lPrestamos = new List<CPrestamo>(); }
        #endregion

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #region Clientes
        public bool ClienteExiste(CCliente pCliente)
        {
            return listaClientes.Exists(x => x.Documento == pCliente.Documento);
        }

        public void AgregarCliente(CCliente pCliente)
        {
            listaClientes.Add(pCliente);
        }

        public void EliminarCliente(CCliente pCliente)
        {
            listaClientes.Remove(listaClientes.Find(x => x.Documento == pCliente.Documento));
        }
        #endregion

        #region Prestamos
        public bool VerificarIdentificador(CPrestamo pPrestamo)
        {
            if (Regex.IsMatch(pPrestamo.Identificador, @"\A[A-Z]{4}[-]{1}[0-9]{6}\Z"))
            { return true; }
            else { return false; }
        }

        public bool PrestamoExiste(CPrestamo pPrestamo)
        {
            return listaPrestamo.Exists(x => x.Identificador == pPrestamo.Identificador);
        }

        public void AgregarPrestamo(CPrestamo pPrestamo)
        {
            listaPrestamo.Add(pPrestamo);
        }

        public void EliminarPrestamo(CPrestamo pPrestamo)
        {
            listaPrestamo.Remove(listaPrestamo.Find(x => x.Identificador == pPrestamo.Identificador));
        }

        public CPrestamo RetornaPrestamo(CVistaPrestamo pVistaPrestamo)
        {
            return listaPrestamo.Find(x => x.Identificador == pVistaPrestamo.Identificador);
        }

        public void PrestamoVence(DateTime pFecha)
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.FechaDevolucion < pFecha & p.Pagado == false select p;
            _lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                p.Vencido = true;
                _lPrestamos.Add(p);
            }

            var evento = PrestamoVencido;
            if (evento != null)
            {
                evento(_lPrestamos);
            }
        }

        public void PrestamoDesvence(DateTime pFecha)
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.FechaDevolucion > pFecha & p.Pagado == false select p;
            foreach (CPrestamo p in prestamos)
            {
                p.Vencido = false;
            }
        }

        public List<CPrestamo> ListaPrestamos()
        {
            return listaPrestamo;
        }

        public List<CCliente> ListaClientes()
        { return listaClientes; }

        public List<CPrestamo> ListaPrestamosNoPagados()
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.Pagado == false select p;
            _lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                _lPrestamos.Add(p);
            }
            return _lPrestamos;
        }

        public List<CPrestamo> ListaPrestamosPagados()
        {
            IEnumerable<CPrestamo> prestamos = from p in listaPrestamo where p.Pagado == true select p;
            _lPrestamos.Clear();
            foreach (CPrestamo p in prestamos)
            {
                _lPrestamos.Add(p);
            }
            return _lPrestamos;
        }
        #endregion
    }
}
