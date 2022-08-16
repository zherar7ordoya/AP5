using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_De_Todo_02
{
    public interface IPersona : ICloneable , IComparable<IPersona>
    {
        int Dni { get; set; }
        string Nombre { get; set; }
    }
}
