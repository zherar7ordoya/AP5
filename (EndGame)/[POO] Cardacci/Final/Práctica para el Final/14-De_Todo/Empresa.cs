using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_De_Todo
{
    public class Empresa
    {
        List<Cliente> ListaClientes;
        List<Pais<string>> ListaPaises;

        public Empresa()
        {
            ListaClientes = new List<Cliente>();
            ListaPaises = new List<Pais<string>>();
        }

        public void AgregarCliente(Cliente C)
        {

            var v = ListaClientes.Where(x => x.Id == C.Id);
            if (v.Count() == 0)
            {
                ListaClientes.Add(C);
            }
            else
            {
                throw new Exception("El Cliente ya existe");
            }

            //if (!ListaClientes.Exists(x => x.Id == C.Id))
            //{
            //    ListaClientes.Add(C);
            //}
            //else
            //{
            //    throw new Exception("El Cliente ya existe");
            //}
        }

        public void AgregarPais(Pais<string> P)
        {
            if (!ListaPaises.Exists(x => x.Codigo == P.Codigo))
            {
                ListaPaises.Add(P);
            }
            else
            {
                throw new Exception("El país ya existe");
            }
        }

        public List<Cliente> RetornaClientes()
        {
            List<Cliente> LC = new List<Cliente>();
            foreach (Cliente C in ListaClientes)
            {
                LC.Add((Cliente)C.Clone());
            }
            return LC;
        }
        public List<Pais<string>> RetornaPaises()
        {
            List<Pais<string>> LP = new List<Pais<string>>();
            foreach (Pais<string> P in ListaPaises)
            {
                LP.Add((Pais<string>)P.Clone());
            }
            return LP;
        }

        public IEnumerable RetornaClientePais()
        {
            var v = from C in ListaClientes
                    join
                    P in ListaPaises
                    on C.Id.Substring(0, 2) equals P.Codigo
                    select new { Nombre = C.Nombre, Procedencia = P.Nombre };
            return v.ToList();
        }

        public List<Cliente> AgruparPorCodigo()
        {
            List<Cliente> LC = new List<Cliente>();
            var v = from C in ListaClientes
                    group C by C.Id;
            foreach(var Codigo in v)
            {
                foreach(Cliente C in Codigo)
                {
                    LC.Add((Cliente)C.Clone());
                }
            }

            return LC;

        }
    }
}
