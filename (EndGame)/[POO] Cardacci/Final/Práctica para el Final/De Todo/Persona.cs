using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    public class Persona<T> : ICloneable  ,IComparable<Persona<T>>,IMiInterface
    {
        //declaro el evento
        public event EventHandler MayordeEdad; //evento comun no personalizado
        public event EventHandler<MenordeEdadEventArgs> MenorDeEdad; //EventoPersonalizado
        public T Id { get; set; }
        public string Nombre { get; set; }
        public T Dni { get; set; }
        private int _Edad;

        

        public int Edad
        {
            get { return _Edad; }
            set
            {
                if (value < 0) { throw new Exception("La edad no puede ser negativa"); }
                //Invoco el evento no personalizado
                if (value > 65)
                {
                    MayordeEdad?.Invoke(this, null);
                }
                //Invoco el evento Personalizado
                else if (value < 18)
                {
                    MenorDeEdad?.Invoke(this, new MenordeEdadEventArgs(value));
                }
                _Edad = value; 
            }
        }

        public int Numero { get; set; }
        public string Apellido { get; set; }

        public Persona() {}

        public Persona(string pNombre, T pDni, int pEdad, T pId)
        {
            Nombre = pNombre;
            Dni = pDni;
            Edad = pEdad;
            Id = pId;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        //Uso el Icomparable para ordenar por edad
        public int CompareTo(Persona<T> other)
        {
            if (Edad < other.Edad) return -1;
            else if (Edad > other.Edad) return 1;
            else return 0;
        }

        //Agrego una clase anidad Icomparer para ordenar por Nombre

        public class NombreAsc : IComparer<Persona<T>>
        {
            public int Compare(Persona<T> x, Persona<T> y)
            {
                return string.Compare(x.Nombre, y.Nombre);
            }
        }
        public class NombreDesc : IComparer<Persona<T>>
        {
            public int Compare(Persona<T> x, Persona<T> y)
            {
                return string.Compare(x.Nombre, y.Nombre)*-1;
            }
        }
    }
}
