using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_De_Todo_02
{
    public class Empresa
    {
        List<Cliente> LClientes;
        public Empresa()
        {
            LClientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente C)
        {
            if (!LClientes.Exists(x => x.Dni == C.Dni))
            {
                LClientes.Add(C);
            }
            else
            {
                throw new Exception("El Cliente con el DNI " + C.Dni + " ya existe.");
            }
        }

        public List<Cliente> RetornaClientes()
        {
            List<Cliente> LC = new List<Cliente>();
            foreach(Cliente C in LClientes)
            {
                LC.Add((Cliente)C.Clone());
            }
            return LC;
        }

        public IEnumerable RetornaSoloNombres()
        {
            var v = from C in LClientes select new { Nombre = C.Nombre };
            
            
            return v.ToList();

        }

        public List<Cliente> RetornaComienzanConA()
        {
            List<Cliente> LC = new List<Cliente>();
            var v = from C in LClientes where C.Nombre.StartsWith("A") select C;
            foreach (Cliente C in v)
            {
                LC.Add((Cliente)C.Clone());
            }

            return LC;
        }

        public List<Cliente> RetornaBusqueda(string A)
        {
            List<Cliente> LC = new List<Cliente>();
            var v = from C in LClientes where C.Nombre==A select C;
            foreach (Cliente C in v)
            {
                LC.Add((Cliente)C.Clone());
            }

            return LC;
        }
    }


}
