using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace _11_Herencia_y_varios
{
      public abstract class Usuario: IEnumerable,IComparable<Usuario>
    {
        public event EventHandler SoyMenor;
        public event EventHandler<SoyMayorEventArgs> SoyMayor;
        private protected int _Edad;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad
        {
            get
            {
                return _Edad;
            }
            set
            {
                if (value < 18)
                {
                    SoyMenor?.Invoke(this, null);
                }
                else
                {
                    SoyMayor?.Invoke(this, new SoyMayorEventArgs(value));
                }
                value = _Edad;
            }
        }
        public Usuario()
        {

        }

        public Usuario(int pId, string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }
        public abstract decimal CalculaCuota(int p);
        protected virtual int EspacioAsignado()
        {
            return 1024;
        }

        public IEnumerator GetEnumerator()
        {
            return new Hola(Id, Nombre);
        }

        public int CompareTo(Usuario other)
        {
            return string.Compare(Nombre,other.Nombre);
        }

        public class NombreDesc : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return string.Compare(x.Nombre, y.Nombre) * -1;
            }
        }
    }

    public class UserPremiun : Usuario,IComparable<Auto> 
    {
        public UserPremiun(int pId, string pNombre) : base(pId,pNombre)
        {}
        public UserPremiun()
        {

        }
        public override decimal CalculaCuota(int p)
        {
            return 100 * p;
        }

        //public new int EspacioAsignado() ///Sombreado
        //{
        //    return 512;

        //}
        protected override int EspacioAsignado()
        {
            return 512;
        }

        public int CompareTo(Auto A)
        {
            if (A.Id> Edad) return 1;
            else if (A.Id < Edad) return -1;
            else return 0;
        }
    }
    public  class Hola:IEnumerator
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        private string _Current;
        public object Current => _Current;

        int c = 0;
        bool sigue = false;

        public Hola(int pId,string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }

        public bool MoveNext()
        {
            if (c == 0)
            {
                _Current = Id.ToString();
                sigue = true;
                c++;
            }
            else if (c == 1)
            {
                _Current = Nombre;
                sigue = true;
                c++;
            }
            else if (c == 2)
            {
                _Current = "Se acabó";
                sigue = true;
                c++;
            }
            else { Reset(); }
            return sigue;
        }

        public void Reset()
        {
            c = 0;
            sigue = false;
            _Current = "";
        }
    }
}
