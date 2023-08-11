using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class OverdraftEventArgs : EventArgs
    {
        public OverdraftEventArgs(decimal amountOverdrafted, string moreInfo)
        {
            AmountOverdrafted = amountOverdrafted;
            MoreInfo = moreInfo;
        }

        public decimal AmountOverdrafted { get; private set; }
        public string MoreInfo { get; private set; }
        public bool CancelTransaction { get; set; } = false;
    }
}
