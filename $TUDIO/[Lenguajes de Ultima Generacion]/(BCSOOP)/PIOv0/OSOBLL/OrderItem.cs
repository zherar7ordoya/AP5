using System;
using System.ComponentModel;

namespace OSOBLL
{
    public class OrderItem : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion

        string _ProdID;
        int _Quantity;
        double _UnitPrice;
        double _SubTotal;
        public string ProdID
        {
            get { return _ProdID; }
            set { _ProdID = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                Notify("Quantity");
            }
        }
        public double UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }
        public double SubTotal
        {
            get { return _SubTotal; }
        }
        public OrderItem(String productID, double unitPrice, int quantity)
        {
            _ProdID = productID;
            _UnitPrice = unitPrice;
            _Quantity = quantity;
            _SubTotal = _UnitPrice * _Quantity;
        }
        public override string ToString()
        {
            string xml = "<OrderItem";
            xml += " ProductID='" + _ProdID + "'";
            xml += " Quantity='" + _Quantity + "'";
            xml += " />";
            return xml;
        }
    }
}