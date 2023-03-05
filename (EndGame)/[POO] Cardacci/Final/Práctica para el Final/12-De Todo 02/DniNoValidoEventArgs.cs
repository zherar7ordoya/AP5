using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneableComparableDisposableEnumerable
{
    public class DniNoValidoEventArgs : EventArgs
    {
        public int DNI { get; set; }
        public DniNoValidoEventArgs(int dni) { DNI = dni; }
    }
}
