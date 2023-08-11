using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneableComparableDisposableEnumerable
{
    public class Empresa
    {
        List<Cliente> _clientes;

        public Empresa() { _clientes = new List<Cliente>(); }

        public void AgregarCliente(Cliente cliente)
        {
            if (!_clientes.Exists(x => x.DNI == cliente.DNI))
            {
                _clientes.Add(cliente);
            }
            else
            {
                throw new Exception($"El Cliente con el DNI { cliente.DNI } ya existe.");
            }
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            foreach (Cliente cliente in _clientes)
            {
                lista.Add((Cliente)cliente.Clone());
            }

            return lista;
        }


        public IEnumerable RetornaSoloNombres()
        {
            var nombres = from cliente
                          in _clientes
                          select new { cliente.Nombre };
            return nombres.ToList();

        }


        public List<Cliente> RetornaComienzanConA()
        {
            List<Cliente> lista = new List<Cliente>();

            var nombres = from cliente
                          in _clientes
                          where cliente.Nombre.StartsWith("A")
                          select cliente;

            foreach (Cliente cliente in nombres)
            {
                lista.Add((Cliente)cliente.Clone());
            }

            return lista;
        }


        public List<Cliente> RetornaBusqueda(string nombre)
        {
            List<Cliente> lista = new List<Cliente>();

            var nombres = from cliente
                          in _clientes
                          where cliente.Nombre == nombre
                          select cliente;

            foreach (Cliente cliente in nombres)
            {
                lista.Add((Cliente)cliente.Clone());
            }

            return lista;
        }
    }


}
