using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_2
{
    public class Request
    {
        #region PROPIEDADES
        string _requestor;
        int _priority;
        DateTime _date;
        public string Requestor
        {
            get { return _requestor; }
            set { _requestor = value; }
        }
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region CONSTRUCTORES
        public Request(
            string requestor, 
            int priority, 
            DateTime date
            )
        {
            this.Requestor = requestor;
            this.Priority = priority;
            this.Date = date;
        }
        #endregion

        #region ANULACIONES
        public override string ToString() { return String.Format(
            $"{this.Requestor}," +
            $"{this.Priority}," +
            $"{this.Date}"
            ); }
        #endregion
    }
}