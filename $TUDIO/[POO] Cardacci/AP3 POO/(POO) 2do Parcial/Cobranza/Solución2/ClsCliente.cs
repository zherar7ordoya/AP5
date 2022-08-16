using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsCliente : ICloneable , IDisposable
    {
        #region CAMPOS

        //Lista de préstamos del Cliente
        private List<ClsPrestamo> ListaPrestamosCliente;
        //Campos que requieren validación en el set
        private string _Nombre;
        private string _Apellido;
        private string _Dni;

        #endregion

        #region PROPIEDADES

        public string Nombre
        {
            get {return _Nombre; }
            set
            {   
                //Valido que no sean cadenas vacias ni demasiado cortas con excepciones personalizadas
                if (value == "") { throw new CadenaVaciaException("Nombre"); }
                else if (value.Length < 3) { throw new CadenaCortaException(value, "Nombre"); }
                else if (value.Length > 30) { throw new CadenaLargaException(value, "Nombre",30); }
                else { _Nombre = value; }
            }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set
            {
                //Valido que no sean cadenas vacias ni demasiado cortas con excepciones personalizadas
                if (value == "") { throw new CadenaVaciaException("Apellido"); }
                else if (value.Length < 3) { throw new CadenaCortaException(value, "Apellido"); }
                else if (value.Length > 30) { throw new CadenaLargaException(value, "Apellido",30); }
                else { _Apellido = value; }
            }
        }
        public string Dni
        {
            get { return _Dni; }
            set
            {
                //valido que el DNI sea numérico. No valido cantidad minima de caracteres para facilitar la entrada de datos.
                foreach (char c in value)
                {
                    if (!char.IsNumber(c))  {throw new Exception("El Dni debe ser numérico."); }
                    else if (value.Length > 8) { throw new CadenaLargaException(value, "Dni",8); }
                    else  { _Dni = value; }
                }                   
            }
        }
        
    #endregion

        #region CONSTRUCTORES

        //Constructor sin parámetros para instanciar la lista de prestamos
        public ClsCliente()
        {
            ListaPrestamosCliente = new List<ClsPrestamo>();
        }

        //Constructor con parámetros
        public ClsCliente(string pNombre, string pApellido, string pDni)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Dni = pDni;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Metodo para asignar un préstamo a un cliente.
        /// Utilizo una expresión LAMBDA para evitar asignar prestamos repetidos
        /// </summary>
        public void AsignarPrestamo(ClsPrestamo pP)
        {
            if (!ListaPrestamosCliente.Exists(x => x.IdPrestamo == pP.IdPrestamo))
            {
                ListaPrestamosCliente.Add(pP);
            }
            else
            {
                throw new Exception("El Préstamo ya esá asignado a este cliente.");
            }           
        }

        /// <summary>
        /// Metodo para desasignar un préstamo a un cliente.
        /// Utilizo una expresión LAMBDA para verificar por Codigo de Prestamo
        /// </summary>
        public void DesasignarPrestamo(ClsPrestamo pP)
        {
            ListaPrestamosCliente.Remove(ListaPrestamosCliente.Find(x => x.IdPrestamo == pP.IdPrestamo));
        }

        /// <summary>
        /// Retorna los prestamos no pagados del cliente.
        /// Utilizo LINQ para filtrar la lista.
        /// Clono la lista para mantener el encapsulamiento.
        /// </summary>
        public List<ClsPrestamo> RetornaPrestamosNoPagadosCliente()
        {
            List<ClsPrestamo> LP = new List<ClsPrestamo>();
            var V = from P in ListaPrestamosCliente where P.Pagado == false select P;
            foreach (ClsPrestamo P in V)
            {
                LP.Add((ClsPrestamo)P.Clone());
            }
            return LP;
        }

        /// <summary>
        /// Retorna los prestamos pagados del cliente.
        /// Utilizo LINQ para filtrar la lista.
        /// Clono la lista para mantener el encapsulamiento.
        /// </summary>
        public List<ClsPrestamo> RetornaPrestamosPagadosCliente()
        {
            List<ClsPrestamo> LP = new List<ClsPrestamo>();
            var V = from P in ListaPrestamosCliente where P.Pagado == true select P;
            foreach (ClsPrestamo P in V)
            {
                LP.Add((ClsPrestamo)P.Clone());
            }
            return LP;
        }

        /// <summary>
        /// Retorna los prestamos vencidos del cliente.
        /// Recibo por referencia la fecha actual
        /// Utilizo LINQ para filtrar la lista.
        /// Clono la lista para mantener el encapsulamiento.
        /// </summary>
        public List<ClsPrestamo> RetornaPrestamosVencidosCliente(DateTime pFechaActual)
        {
            List<ClsPrestamo> LP = new List<ClsPrestamo>();
            //Me fijo si está vencido comparando las fechas actuales y de devolucion.
            var V = from P in ListaPrestamosCliente where (P.FechaDevolucion<pFechaActual&&P.Pagado==false) select P;
            foreach (ClsPrestamo P in V)
            {
                LP.Add((ClsPrestamo)P.Clone());
            }
            return LP;
        }

        //Implementacion de ICLoneable. Hago una clonación superficial
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        #region DESTRUCTOR - DISPOSE

        bool _DisposeOk = false;
        ~ClsCliente()
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
