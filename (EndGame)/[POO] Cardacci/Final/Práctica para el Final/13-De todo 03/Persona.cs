using _13_De_todo_03.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_De_todo_03
{
    public class Persona : ICloneable,  IComparable<Persona>, IDisposable
    {
        private List<Auto> ListaAutos;

        public static event EventHandler NombreDeMierda;

        Class1 Jourdan;
        
        private string _Nombre;

        public int Dni { get; set; }
        public string Nombre { get { return _Nombre; }
            set
            {
                if (value == "Mierda")
                {
                    NombreDeMierda?.Invoke(this, null);
                    
                }
                _Nombre = value;
            }
        }

        public Persona()
        {
            ListaAutos = new List<Auto>();
        }
        public Persona(int pDni, string pNombre)
        {
            Dni = pDni;
            Nombre = pNombre;

        }

        public void AgregarAuto(Auto A)
        {
            if (!ListaAutos.Exists(x => x.Patente == A.Patente))
            {
                ListaAutos.Add(A);
            }
        }
        public int CompareTo(Persona other)
        {
            throw new NotImplementedException();
        }      

     

        public object Clone()
        {
            Persona PersonaClonada = new Persona(Dni,Nombre);
           
            foreach (Auto A in ListaAutos)
            {
                PersonaClonada.AgregarAuto((Auto)A.Clone());
            }

            return PersonaClonada;
        }

        private bool DisposedOk = false;
        public void Dispose()
        {
            DisposedOk = true;
        }
        ~Persona()
        {
            if (!DisposedOk)
            {
                Dispose();
            }
        }
    }
}
