using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _14_De_Todo
{
    public abstract class Cliente : ICloneable, IComparable<Cliente>, IEnumerable
    {
        //Id=AR-1234
        //Las primeras dos letras corresponden al codigo de pais del cliente
        public static event EventHandler<NacionalEventArgs> EsNacional;
        private string _Nombre;
        public string Id { get; set; }
        public string Nombre 
        { get { return _Nombre; }
            set 
            {
                if (Id.Substring(0, 2) == "AR")
                {
                    EsNacional?.Invoke(this, new NacionalEventArgs(value));
                }

                _Nombre = value;
            }
        }

        public Cliente()
        {

        }
        public Cliente(string pId,string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }

        public abstract decimal Descuento(decimal Importe);


        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Cliente other) //Ordena por nombre ascendente
        {
            return string.Compare(Nombre, other.Nombre);
        }

        public class IdAsc : IComparer<Cliente>
        {
            public int Compare(Cliente x, Cliente y)
            {
                return string.Compare(x.Id, y.Id);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new IdCliente(Id);
        }
    }

    public class ClienteNacional:Cliente
    {
        public ClienteNacional(string pId, string pNombre):base(pId,pNombre)
        {

        }
        public ClienteNacional()
        {

        }
        public override decimal Descuento(decimal Importe)
        {
            return Importe * 0.20m;
        }
    }
    public class ClienteExtranjero : Cliente
    {
        public ClienteExtranjero(string pId, string pNombre) : base(pId, pNombre)
        {

        }
        public ClienteExtranjero()
        {

        }
        public override decimal Descuento(decimal Importe)
        {
            return Importe * 0.10m;
        }
    }

    public class IdCliente : IEnumerator
    {
        public string Id { get; set; }
        private string _Current;
        bool sigue;
        int c;

        public IdCliente(string pId)
        {
            Id = pId;
        }
        public object Current => _Current;

        public bool MoveNext()
        {
            if (c == 0)
            {
                _Current = Id.Substring(0, 2);
                sigue = true;
                c++;
            }
            else if (c == 1)
            {
                _Current = Id.Substring(3, 4);
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
