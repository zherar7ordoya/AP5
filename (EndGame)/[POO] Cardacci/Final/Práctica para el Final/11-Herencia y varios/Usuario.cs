using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace _11_Herencia_y_varios
{
    public abstract class Usuario : IEnumerable, IComparable<Usuario>
    {
        public event EventHandler MenorEventHandler;
        public event EventHandler<SoyMayorEventArgs> MayorEventHandler;

        // La definición es "protected: solamente el código de la misma class,
        // o bien de una class derivada de esa class, puede acceder al tipo o
        // miembro." Ahora, ¿por qué decidió usar "private protected"?
        // En realidad es "private protected: se puede tener acceso al tipo o
        // miembro mediante tipos derivados del objeto class que se declaran
        // dentro de su ensamblado contenedor."
        private protected int _edad;

        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value < 18) MenorEventHandler?.Invoke(this, null);
                else MayorEventHandler?.Invoke(this, new SoyMayorEventArgs(value));
                value = _edad;
            }
        }

        // ¡Qué manía con los constructores vacíos!
        public Usuario() { }

        public Usuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        /**
         * You use abstract methods to force subclasses to override the method.
         * You use virtual methods to allow subclasses to override the method.
         */
        public abstract decimal CalculaCuota(int p);
        protected virtual int EspacioAsignado() { return 1024; }

        public IEnumerator GetEnumerator()
        {
            return new Saludo(Id, Nombre);
        }

        public int CompareTo(Usuario comparado)
        {
            return string.Compare(Nombre, comparado.Nombre);
        }


        public class NombreDesc : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return string.Compare(x.Nombre, y.Nombre) * -1;
            }
        }
    }


    public class Auto
    {
        public int Id { get; set; }
    }


    public class UsuarioPremium : Usuario, IComparable<Auto>
    {
        public UsuarioPremium(int id, string nombre) : base(id, nombre) { }
        public UsuarioPremium() { }

        // Este método: estaba obligado a sobre-escribirlo
        public override decimal CalculaCuota(int i) { return 100 * i; }

        // Este método: podía o no sobre-escribirlo
        protected override int EspacioAsignado() { return 512; }

        public int CompareTo(Auto auto)
        {
            if (auto.Id > Edad) return 1;
            else if (auto.Id < Edad) return -1;
            else return 0;
        }
    }



    public class Saludo : IEnumerator
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        private string _current;
        public object Current => _current;

        int contador = 0;
        bool continuar = false;

        public Saludo(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public bool MoveNext()
        {
            if (contador == 0)
            {
                _current = ID.ToString();
                continuar = true;
                contador++;
            }
            else if (contador == 1)
            {
                _current = Nombre;
                continuar = true;
                contador++;
            }
            else if (contador == 2)
            {
                _current = "IEnumerator no tiene más que mostrar";
                continuar = true;
                contador++;
            }
            else { Reset(); }

            return continuar;
        }

        public void Reset()
        {
            contador = 0;
            continuar = false;
            _current = string.Empty;
        }
    }
}
