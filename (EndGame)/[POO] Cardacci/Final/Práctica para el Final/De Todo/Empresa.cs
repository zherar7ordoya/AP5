
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public class Empresa
    {
        private List<Persona<int>> ListaPersonas;
        private List<Auto> ListaAutos;

        public Empresa()
        {
            ListaPersonas = new List<Persona<int>>();
            ListaAutos = new List<Auto>();
        }

        public void AgregarPersona(Persona<int> pPersona)
        {
            if (!ListaPersonas.Exists(x => x.Dni == pPersona.Dni))
            {
                ListaPersonas.Add(pPersona);
            }
            else
            {
                throw new Exception("El Dni ya existe");
            }
        }

        public List<Persona<int>> RetornaPersonas()
        {
            List<Persona<int>> ListaClonada = new List<Persona<int>>();
            foreach (Persona<int> p in ListaPersonas)
            {
                //ListaClonada.Add(new Persona(p.Nombre, p.Dni, p.Edad));
                ListaClonada.Add((Persona<int>)p.Clone());
            }
            return ListaClonada;
        }

        public Persona<int> RetornaPersonaOriginal(Persona<int> pP)
        {
            return ListaPersonas.Find(x => x.Dni == pP.Dni);

        }

        public void ModificarEdad(Persona<int> pP,int pEdad)
        {
            try
            {
                Persona<int> P = ListaPersonas.Find(x => x.Dni == pP.Dni);
                P.Edad = pEdad;
            }
            catch (Exception)
            {

                
            }
           
        }

        public void AgregarAuto(Auto pAuto)
        {
            if (!ListaAutos.Exists(x => x.Patente == pAuto.Patente))
            {
                ListaAutos.Add(pAuto);
            }
        }
        public List<Auto> RetornaAutos()
        {
            List<Auto> LAutosClon = new List<Auto>();
            foreach(Auto A in ListaAutos)
            {
                LAutosClon.Add((Auto)A.Clone());
            }
            return LAutosClon;
        }

        public List<Auto> RetornaAutosViejos()
        {
            List<Auto> ListaRetorno = new List<Auto>();
            var v = from A in ListaAutos where A.Modelo < 2000 select A;
            foreach(Auto A in v)
            {
                ListaRetorno.Add((Auto)A.Clone());
            }
            return v.ToList<Auto>();
        }

        public IEnumerable RetornaAutosTitulares()
        {
            var v = from P in ListaPersonas
                    join A in ListaAutos
                    on P.Id equals A.IdTitular
                    select new { Patente = A.Patente, Titular = P.Nombre };
            return v.ToList();
        }

        public List<Auto> RetornoAutosNuevos()
        {
            var V = ListaAutos.Where(x => x.Modelo == 2020);
            return V.ToList();
        }

    }
}
