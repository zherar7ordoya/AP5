using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    public class Auto : ICloneable,IEnumerable
    {
        //Declaro un Delegado
        public delegate string MiDelegado(int a); //regresa un string y recibe un entero
      
        public string Marca { get; set; }
        public string Patente { get; set; }
        public int Modelo { get; set; }
        public int IdTitular { get; set; } //Para probar el Join

        public MiDelegado VerificarModelo;

        ///La patente tiene que ser AA123HY 
        ///es decir dos letras 3 numeros 2 letras
        ///

        public Auto() {}    

        public Auto(string pMarca, string pPatente,int pModelo,int pIdTitular)
        {
            Marca = pMarca;
            Patente = pPatente;
            Modelo = pModelo;
            IdTitular = pIdTitular;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public T Retornaalgo<T>(T pParametro)
        {
            
            return pParametro;
        }
        public IEnumerator GetEnumerator()
        {
            return (new PatenteEnumerator(Patente));
        }
    }

    public class PatenteEnumerator : IEnumerator
    {
        public string Patente { get; set; }

        private string _Current="";
        private bool sigue=false;
        private int c=0;
        public object Current
        {
            get { return _Current; }
            set { }
        }

      

        public PatenteEnumerator(string pPatente)
        {
            Patente = pPatente;

        }
        public bool MoveNext()
        {
            if (c == 0)
            {
                _Current = Patente.Substring(0, 2);
                sigue = true;
                c++;

            }
            else if (c == 1)
            {
                _Current = Patente.Substring(2, 3);
                sigue = true;
                c++;

            }
            else if (c == 2)
            {
                _Current = Patente.Substring(5, 2);
                sigue = true;
                c++;

            }
            else
            {
                Reset();

            }

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
