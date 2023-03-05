using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneableComparableDisposableEnumerable
{
    public interface IPersona : ICloneable , IComparable<IPersona>
    {
        int DNI { get; set; }
        string Nombre { get; set; }
    }
}
