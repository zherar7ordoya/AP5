using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public interface IAlimento
    {
        string Nombre { get; }
        string FechaInstancia { get; }
        string HoraInstancia { get; }
    }
}