using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_De_todo_03
{
    public class Auto : ICloneable
    {
        public event EventHandler EventoComun;
        public event EventHandler<EventoPersonalizadoEventArgs> EventoPersonalizado;
        private Persona Titular;

        private int _Modelo;
        public Auto()
        {
           
        }
        public string Marca { get; set; }
        public string Patente { get; set; }
        public int Modelo
        {
            get { return _Modelo; }
            set
            {
                if (Modelo < 2000)
                {
                    EventoComun?.Invoke(this, null);
                    EventoPersonalizado?.Invoke(this, new EventoPersonalizadoEventArgs(Patente));
                }

                _Modelo = value;
            }

        }

        public void AgregarTitular(Persona P)
        {
            if (Titular==null)
            {
                Titular = new Persona();
                Titular = P;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
