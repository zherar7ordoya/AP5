using System;

namespace _3__L_
{
    class Radio : Principal
    {
        public Radio(string mensaje) : base(mensaje) { }

        public override void Muestra()
        {
            Console.WriteLine("Desde radio: {0}", mensaje);
        }
    }
}
