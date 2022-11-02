using BEL;
using System;

namespace BLL
{
    public class Procesador : IProcesador
    {
        public Modelo AgregarCodigo(Modelo modelo)
        {
            Random rnd = new Random();
            modelo.Codigo = rnd.Next(1, 101);
            return modelo;
        }
    }
}
