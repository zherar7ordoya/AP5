namespace _5__D_
{
    class Producto
    {
        private string nombre;
        private int tipo;
        private double costo;

        public Producto(string nombre, int tipo, double costo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.costo = costo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public double Costo { get => costo; set => costo = value; }

        public override string ToString()
        {
            string tipoAtexto = string.Empty;

            switch (tipo)
            {
                case 0:
                    tipoAtexto = "Alimento";
                    break;
                case 1:
                    tipoAtexto = "Medicina";
                    break;
                case 2:
                    tipoAtexto = "Ropa";
                    break;
                default:
                    break;
            }
            return string.Format("{0}, tipo {1}, costo ${2}", nombre, tipoAtexto, costo);
        }

    }
}
