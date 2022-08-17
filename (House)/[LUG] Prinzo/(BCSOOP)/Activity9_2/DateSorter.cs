using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_2
{
    public class DateSorter : IComparer<Request>
    {
        public int Compare(Request request1, Request request2) { return request1.Date.CompareTo(request2.Date); }
    }
}
