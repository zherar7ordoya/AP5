using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneableComparableDisposableEnumerable
{
    public abstract class Cliente : IPersona, IEnumerable, IDisposable
    {
        public event EventHandler<DniNoValidoEventArgs> DniNoValidoEventHandler;

        public delegate string DelegadoString();
        public DelegadoString DelegadoMuestraMensaje;
        public Func<int, bool> FuncMuestraMensaje = x => x == 1;

        private int _dni;

        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public int DNI
        {
            get { return _dni; }
            set
            {
                if (value < 1000)
                {
                    DniNoValidoEventHandler?.Invoke(this, new DniNoValidoEventArgs(value));
                }
                _dni = value;
            }
        }


        public Cliente() { }
        public Cliente(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        // La obligación a ICloneable viene de mano de IPersona
        public object Clone()
        {
            // Crea una copia superficial del Object actual
            return MemberwiseClone();
        }

        // La obligación a IComparable viene de mano de IPersona
        public int CompareTo(IPersona otra)
        {
            return string.Compare(Nombre, otra.Nombre);
        }


        public class DniAsc : IComparer<Cliente>
        {
            public int Compare(Cliente x, Cliente y)
            {
                if (x.DNI > y.DNI)
                {
                    return 1;
                }
                if (x.DNI < y.DNI)
                {
                    return -1;
                }
                else return 0;
            }
        }


        public abstract decimal Cuota();

        public IEnumerator GetEnumerator()
        {
            return new Codigo(Codigo);
        }

        bool _descartar = false;

        ~Cliente()
        {
            if (!_descartar)
            {
                // Solo ejecuto Finalize (destructor) si no se ejecutó el Dispose
                Dispose();
            }


        }
        public void Dispose()
        {
            _descartar = true;
        }
    }

    public class ClientePremium : Cliente
    {
        public ClientePremium(int dni, string nombre) : base(dni, nombre) { }
        public ClientePremium() { }
        public override decimal Cuota() { return 1000; }
    }


    public class ClienteComun : Cliente
    {
        public ClienteComun(int dni, string nombre) : base(dni, nombre) { }
        public ClienteComun() { }
        public override decimal Cuota() { return 500; }
    }


    public class Codigo : IEnumerator
    {
        public string AlfaNumerico { get; set; }
        string _current;
        public object Current => _current;
        bool continuar;
        int contador;

        public Codigo(string codigo) { AlfaNumerico = codigo; }

        public bool MoveNext()
        {
            if (contador == 0)
            {
                _current = AlfaNumerico.Substring(0, 4);
                continuar = true;
                contador++;
            }
            else if (contador == 1)
            {
                _current = AlfaNumerico.Substring(5, 4);
                continuar = true;
                contador++;
            }
            else Reset();
            return continuar;
        }

        public void Reset()
        {
            _current = "";
            contador = 0;
            continuar = false;
        }
    }
}
