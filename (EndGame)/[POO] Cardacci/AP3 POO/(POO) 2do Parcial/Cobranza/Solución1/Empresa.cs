using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUrbainskyAlexis
{
    class Empresa : IDisposable
    {
        #region Atributos
        List<Cliente> _ListaClientes;
        List<Cobro> _ListaCobros;
        #endregion

        #region Constructor
        public Empresa() {
            _ListaClientes = new List<Cliente>();
            _ListaCobros = new List<Cobro>();
        }
        #endregion

        #region Clientes

        public void AltaCliente(Cliente cliente) {
            try
            {
                if (cliente != null) {
                    _ListaClientes.Add(new Cliente(cliente.Legajo, cliente.Nombre));
                } else {
                    throw new Exception("El cliente no puede ser Nulo");
                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public void BajaCliente(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    if (ValidarExistenciaCliente(cliente)) {
                        _ListaClientes.Remove(_ListaClientes.Find(x => x.Legajo == cliente.Legajo));
                    } else {
                        throw new Exception("El cliente a dar de baja no existe en la empresa, Legajo: " + cliente.Legajo);
                    }
                } else {
                    throw new Exception("El cliente a dar de baja no puede ser Nulo");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarCliente(Cliente pCliente)
        {
            try
            {
                if (pCliente != null)
                {
                    if (ValidarExistenciaCliente(pCliente))
                    {
                        Cliente auxCliente = _ListaClientes.Find(x => x.Legajo == pCliente.Legajo);
                        auxCliente.Nombre = pCliente.Nombre;
                        auxCliente.Legajo = pCliente.Legajo;
                    } else {
                        throw new Exception("El cliente a modificar no existe en la empresa, Legajo: " + pCliente.Legajo);
                    }
                } else {
                    throw new Exception("El cliente a dar de baja no puede ser Nulo");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void PagarCobro(Cobro cobro)
        {
            try
            {
                Cobro auxCobro = _ListaCobros.Find(x => x.Código == cobro.Código);
                auxCobro.CancelarCobro();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarExistenciaCliente(Cliente cliente)
        {
            return _ListaClientes.Exists(x => x.Legajo == cliente.Legajo);
        }

        public List<Cliente> DevolverListadoClientes()
        {
            return _ListaClientes.ToList();
        }

        public bool PagosPendientesMayorAlLimite(Cliente pCliente) {
            Cliente auxCliente = _ListaClientes.Find(x=> x.Legajo == pCliente.Legajo);
            int cobrosPendientes = 0;
            
            foreach (Cobro c in auxCliente._ListaCobros) {
                if (c.Importe > 0) {
                    cobrosPendientes += 1;
                }       
            }

            if (cobrosPendientes == 2)
            {
                return true;
            }
            else {
                return false;
            }
            
        }

        

        #endregion

        #region Cobros

        public void AltaCobro(Cobro pCobro, Cliente pCliente)
        {
            try
            {
                if (pCobro != null && pCliente != null) {

                    string tipoCobro = pCobro.GetType().Name;

                    if (tipoCobro == "Normal")
                    {
                        _ListaCobros.Add(new Normal(pCobro.Código, pCobro.Nombre, pCobro.FechaVencimiento, pCobro.Importe, RetornaCliente(pCliente)));
                    }
                    else if (tipoCobro == "Especial")
                    {
                        _ListaCobros.Add(new Especial(pCobro.Código, pCobro.Nombre, pCobro.FechaVencimiento, pCobro.Importe, RetornaCliente(pCliente)));
                    }
                    
                    Cliente auxCliente = RetornaCliente(pCliente);
                    auxCliente.AgregarCobro(RetornaCobro(pCobro));
                }
                else {
                    throw new Exception("Error, El Cobro o el cliente que desea ingresar son Nulos");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarExistenciaCobro(Cobro cobro)
        {
            return _ListaCobros.Exists(x => x.Código == cobro.Código);
        }

        public List<Cobro> DevolverListadoCobros()
        {
            return _ListaCobros.ToList();
        }

        #endregion

        #region Metodos
        public Cliente RetornaCliente(Cliente pCliente)
        {
            return _ListaClientes.Find(x => x.Legajo == pCliente.Legajo);
        }

        public Cobro RetornaCobro(Cobro pCobro)
        {
            return _ListaCobros.Find(x => x.Código == pCobro.Código);
        }

        public List<Cliente> DevuelveListaClientesClon() {

            List<Cliente> listaClientes = new List<Cliente>();

            foreach (Cliente c in _ListaClientes) {
                listaClientes.Add((Cliente)c.Clone());
            }

            return listaClientes;
        }

        public List<Cobro> DevuelveListaCobrosClon()
        {
            List<Cobro> listaClientes = new List<Cobro>();

            foreach (Cobro c in _ListaCobros)
            {
                listaClientes.Add((Cobro)c.Clone());
            }

            return listaClientes;
        }

        #endregion

        #region Destructor
        bool _DisposeOk = false;
        ~Empresa()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
                Console.WriteLine("La el objeto empresa ha finalizado");
            }
        }
        public void Dispose()
        {
            _DisposeOk = true;
        }
        #endregion

    }
}
