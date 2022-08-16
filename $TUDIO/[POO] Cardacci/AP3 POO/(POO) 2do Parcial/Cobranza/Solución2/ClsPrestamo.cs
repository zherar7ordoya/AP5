using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public abstract class ClsPrestamo : ICloneable, IEnumerator, IEnumerable, IDisposable
    {
        #region CAMPOS
        //Titular del 'Préstamo
        private ClsCliente ClientePrestamo;
        //Campos que requieren validaciones en el setter
        private double _CapitalSolicitado;
        private double _TasaAnual;
        private int _Plazo;
        private DateTime _FechaAdjudicacion;

        //Variables para el IEnumerator
        string _Current = ""; 
        static int c=0; 
        bool r = false;

        #endregion

        #region PROPIEDADES
        public string IdPrestamo { get; set; }
        public double CapitalSolicitado 
        { 
            get { return _CapitalSolicitado; } 
            set
            {
                //valido que no sean valores negativos
                //Para usar GENERICS, tengo una excepcion personalizada que puede recibir cualquier tipo
                //que sea struct. Un double, un int etc. En este caso le paso un double
                if (value < 0) { throw new NegativoException<double>(value); }
                //Valido monto maximo
                else if(value > 999999999) { throw new Exception("El Capital solicitado no puede superar 999.999.999"); }
                else { _CapitalSolicitado = value; }
            }
        }
        public double TasaAnual
        {
            get { return _TasaAnual; }
            set
            {
                //valido que no sean valores negativos
                //Para usar GENERICS, tengo una excepcion personalizada que puede recibir cualquier tipo
                //que sea struct. Un double, u int etc.
                if (value < 0) { throw new NegativoException<double>(value); }
                //Valido tasa maximo
                else if (value > 200) { throw new Exception("La TNA no puede superar el 200% Anual"); }
                else { _TasaAnual = value; }
            }
        }
        public int Plazo
        {
            get { return _Plazo; }
            set
            {
                //valido que no sean valores negativos. En este caso le paso como parametro un entero a la excepcion.
                if (value < 0) { throw new NegativoException<int>(value); }
                //Valido plazo maximo
                else if (value > 480) { throw new Exception("El plazo no puede superar los 480 meses"); }
                else { _Plazo = value; }
            }
        }
        public DateTime FechaAdjudicacion
        {
            get { return _FechaAdjudicacion; }
            set
            { DateTime FechaMinima = Convert.ToDateTime("01/01/1900");
                DateTime FechaMaxima = Convert.ToDateTime("31/12/2100");
                if (value < FechaMinima || value>FechaMaxima) { throw new FechaException(value); }
                _FechaAdjudicacion = value;
            }
        }
        public DateTime FechaDevolucion { get; set; }
        public bool Pagado { get; set; }
        public bool Vencido { get; set; }

        

        #endregion

        #region CONSTRUCTORES

        //Constructor sin parámetros para instanciar el titular e inicializar variables
        public ClsPrestamo()
        {
            ClientePrestamo = new ClsCliente();
            Pagado = false;
            Vencido = false;
        }

        //Constructor con parámetros
        public ClsPrestamo(string pIdPrestamo, double pCapitalSolicitado, double pTasa, int pPlazo, DateTime pFechaAdjudicacion, DateTime pFechaDevolucion, bool pPagado)
        {
            IdPrestamo = pIdPrestamo;
            CapitalSolicitado = pCapitalSolicitado;
            TasaAnual = pTasa;
            Plazo = pPlazo;
            FechaAdjudicacion = pFechaAdjudicacion;
            FechaDevolucion = pFechaDevolucion;
            Pagado = pPagado;
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Método para asignar un Titular al préstamo
        /// </summary>
        public void AsignarCliente(ClsCliente C)
        {
            ClientePrestamo = C;
        }

        /// <summary>
        /// Método para desasignar un Titular al préstamo
        /// </summary>
        public void DesasignarCliente()
        {
            ClientePrestamo = new ClsCliente(); 
        }

        /// <summary>
        /// Método polimórfico Interés. Calcula el interés simple o compuesto según el caso.
        /// </summary>
        public abstract double Interes();

        /// <summary>
        /// Método polimórfico Gasto Administrativo. Calcula el gasto según el caso. 2% o 3%
        /// </summary>
        public abstract double GastoAdministrativo();

        /// <summary>
        /// Metodo para calcular el Seguro obligatorio. Es común a todos los préstamos
        /// </summary>
        public double Seguro()
        {
            return CapitalSolicitado * 0.01;
        }

        /// <summary>
        /// Metodo para calcular dinero Total a retornar. Es común a todos los préstamos
        /// </summary>
        public double TotalaRetornar()
        {
            return CapitalSolicitado + Interes() + GastoAdministrativo() + Seguro();
        }
       
        /// <summary>
        /// Método que retorna el Titular del préstamo
        /// </summary>
        public ClsCliente RetornaCliente()
        {
            return ClientePrestamo;
        }

        /// <summary>
        /// Método de Clonación superficial del Préstamo
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //Devuelve el _Current para el Enumerator
        public object Current => _Current;

        //Implemento la interface IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this; //retorno este mismo objeto
        }

        //Implemento el MoveNext del IEnumerator y aprovecho para validar el código del prestamo
        public bool MoveNext()
        {
            // Primero verifico que la cadena tenga la longitud correspondiente
            if (IdPrestamo.Length != 11) { throw new Exception("El Id debe tener 11 caracteres"); }
            //La primer pasada verifico que sean 4 letras
            if (c == 0)
            {
                _Current = IdPrestamo.Substring(0, 4);
                foreach (char c in _Current)
                {
                    if (!char.IsLetter(c))
                    {
                        //Antes de disparar la exception hago el reset del IEnumerator
                        Reset();
                        throw new Exception("Los primeros 4 caracteres del código deben ser letras.");
                    }
                }
                r = true; c++;                      
            }
            //La segunda pasada verifico que sea un guión
            else if (c == 1)
            {
                _Current = IdPrestamo.Substring(4, 1);
                if (_Current != "-")
                {
                    //Antes de disparar la exception hago el reset del IEnumerator
                    Reset();
                    throw new Exception("El quinto caracter debe ser un guión");
                }
                r = true; c++;                            
            }
            //La tercer pasada verifico que sean 6 números.
            else if (c == 2)
            {
                _Current = IdPrestamo.Substring(5, 6);
                foreach (char c in _Current)
                {
                    if (!char.IsNumber(c))
                    {
                        //Antes de disparar la exception hago el reset del IEnumerator
                        Reset();
                        throw new Exception("Los últimos 6 caracteres del código deben ser números.");
                    }
                }
                r = true; c++;              
            }
            //hago el Reset()
            else { Reset(); }
            return r;
        }

        //Implemento el Reset del IEnumerator
        public void Reset()
        {
            c = 0;
            r = false;
            _Current = "";
        }

        #endregion

        #region DESTRUCTOR Y DISPOSE

        bool _DisposeOk = false;
        ~ClsPrestamo()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
            }
        }
        public void Dispose()
        {
            _DisposeOk = true;
        }

        #endregion

    }
}
