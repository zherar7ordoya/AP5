using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_De_Todo_02
{
    public abstract class Cliente : IPersona,IEnumerable,IDisposable
    {
        public event EventHandler<DniTruchoEventArgs> DniTrucho;
        public delegate string MiDelegado();
        public MiDelegado Del1;
        public Func<int, bool> MiFunc = x => x == 1;
        private int _Dni;
        public int Dni { get { return _Dni; } 
            set
            {
                if (value < 1000)
                {
                    DniTrucho?.Invoke(this, new DniTruchoEventArgs(value));
                }

                _Dni = value;
            }
        }
        public string Nombre { get; set; }

        public string Codigo { get; set; }

        /// <summary>
        /// AAAA-1234
        /// </summary>

        public Cliente()
        {

        }

        public Cliente(int pDni,string pNombre)
        {
            Dni = pDni;
            Nombre = pNombre;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(IPersona other)
        {
            return string.Compare(Nombre, other.Nombre);
        }

        public class DniAsc : IComparer<Cliente>
        {
            public int Compare(Cliente x, Cliente y)
            {
                if (x.Dni > y.Dni)
                {
                    return 1;
                }
                if (x.Dni < y.Dni)
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


        bool _DisposeOk = false;
        
        ~Cliente()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
                Dispose();
            }


        }
        public void Dispose()
        {
            _DisposeOk = true;
        }
        
    }

    public class ClientePremium : Cliente
    {
        public ClientePremium(int pDni, string pNombre):base(pDni,pNombre)
        {

        }
        public ClientePremium()
        {

        }
        public override decimal Cuota()
        {
            return 1000;
        }
    }
    public class ClienteComun : Cliente
    {
        public ClienteComun(int pDni, string pNombre) : base(pDni, pNombre)
        {

        }
        public ClienteComun()
        {

        }
        public override decimal Cuota()
        {
            return 500;
        }
    }

    public class Codigo:IEnumerator
    {
        public string CodigoCliente { get; set; }
        string _Current;
        public object Current => _Current;

        bool sigue;
        int c;

        public Codigo(string pCodigo)
        {
            CodigoCliente = pCodigo;
        }

        public bool MoveNext()
        {
            if (c == 0)
            {
                _Current = CodigoCliente.Substring(0, 4);
                sigue = true;
                c++;
            }
            else if (c == 1)
            {
                _Current = CodigoCliente.Substring(5, 4);
                sigue = true;
                c++;
            }
            else Reset();
            return sigue;
        }

        public void Reset()
        {
            _Current = "";
            c = 0;
            sigue = false;
        }
    }
}
