using System;
using System.ComponentModel;

namespace BLLInsumosOficina
{
    public class BLLItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propiedad)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }

        string _idProducto;
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                _cantidad = value;
                Notify("Cantidad");
            }
        }

        double _precio;
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        readonly double _total;
        public double Total
        {
            get { return _total; }
        }

        #region Sobrecarga de constructor a pedido
        public BLLItem() { }
        public BLLItem(String idProducto, double precio, int cantidad)
        {
            _idProducto = idProducto;
            _precio = precio;
            _cantidad = cantidad;
            _total = _precio * _cantidad;
        }
        #endregion

        
        public override string ToString()
        {
            string xml = "<Item";
            xml += " IdProducto='" + _idProducto + "'";
            xml += " Cantidad='" + _cantidad + "'";
            xml += " />";
            return xml;
        }
    }
}