using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_De_todo_03
{
    class Empresa
    {
        private List<Auto> ListaAutos;
        private List<Persona> ListaPersonas;
        List<VistaInservible> ListaVistaInservible;

        public Empresa()
        {
            ListaAutos = new List<Auto>();
            ListaPersonas = new List<Persona>();
            ListaVistaInservible = new List<VistaInservible>();

            ListaPersonas.Add(new Persona(2000, "Alex"));
        }

        public void AgregarAuto(Auto pA)
        {
            var v = from A in ListaAutos where A.Patente == pA.Patente select A;
            if (v.Count() == 0)
            {
                ListaAutos.Add(pA);
            }
            else
            {
                throw new Exception("Ya existe");
            }
        }

        public List<VistaInservible> UsarJoin()
        {
            ListaVistaInservible.Clear();
            var v = from A in ListaAutos
                    join P in ListaPersonas
                    on A.Modelo equals P.Dni
                    select new VistaInservible(A.Marca, P.Nombre);

            foreach (VistaInservible L in v)
            {
                ListaVistaInservible.Add(L);
            }
            return ListaVistaInservible;
        }

        public List<Auto> GroupByModelo()
        {
            List<Auto> ListaRetorno = new List<Auto>();

            var v = from A in ListaAutos
                    group A by A.Modelo;
            foreach (var Modelo in v)
            {
                foreach (Auto A in Modelo)
                {
                    ListaRetorno.Add((Auto)A.Clone());
                }
            }
            return ListaRetorno;        

        }
    }

    public class VistaInservible
    {
        

        public string Marca { get; set; }
        public string Nombre { get; set; }
       
        public VistaInservible(string pMarca, string pNombre)
        {
            Marca = pMarca;
            Nombre = pNombre;

        }

        
    }
}
