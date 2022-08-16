using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsEmpresa: IDisposable
    {
        #region EVENTO

        public event EventHandler<PrestamosVencidosEventArgs> PrestamosVencidos; //Defino el Evento

        #endregion

        #region CAMPOS

        //Lista de Clientes de la Empresa
        private List<ClsCliente> ListaClientesEmpresa;
        //Lista de Prestamos de la Empresa
        private List<ClsPrestamo> ListaPrestamosEmpresa;
        //Lista usada para guardar los prestamos que vencen en el día para ser mostrados por el evento
        private List<ClsPrestamo> ListaEventoPrestamosVencidos;

        #endregion       

        #region CONSTRUCTORES

        //Constructor vacío donde instancio las tres listas
        public ClsEmpresa()
        {
            ListaClientesEmpresa = new List<ClsCliente>();
            ListaPrestamosEmpresa = new List<ClsPrestamo>();
            ListaEventoPrestamosVencidos = new List<ClsPrestamo>();
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Método para dar de alta un Prestamo. Se guarda en la lista de prestamos de la empresa.
        /// Se verifica que el ID no se repita mediante una expresión Lambda.
        /// Caso contrario se devuelve una exception personalizada.
        /// </summary>
        public void AltaPrestamo(ClsPrestamo pP)
        {
            if (!ListaPrestamosEmpresa.Exists(x => x.IdPrestamo == pP.IdPrestamo))
            {
                ListaPrestamosEmpresa.Add(pP);
            }
            else
            {
                throw new Exception("El ID " + pP.IdPrestamo + " ya existe");
            }

        }

        /// <summary>
        /// Método para dar de baja un préstamo.
        /// Recibe por referencia una Préstamo del Tipo Vista.
        /// Obtengo el objeto original por medio de una expresión LAMBDA
        /// </summary>
        public void BajaPrestamo(ClsVistaGrilla2 pVP)
        {
            ListaPrestamosEmpresa.Remove(ListaPrestamosEmpresa.Find(x => x.IdPrestamo == pVP.Id));
        }

        /// <summary>
        /// Método para modificar un préstamo.
        /// Recibe por referencia una Préstamo Clonado.
        /// Obtengo el objeto original por medio de una expresión LAMBDA
        /// </summary>
        public void ModificarPrestamo(ClsPrestamo pP)
        {
            ClsPrestamo P = ListaPrestamosEmpresa.Find(x => x.IdPrestamo == pP.IdPrestamo);
            P.CapitalSolicitado = pP.CapitalSolicitado;
            P.FechaAdjudicacion = pP.FechaAdjudicacion;
            P.FechaDevolucion = pP.FechaDevolucion;
            P.Plazo = pP.Plazo;
            P.TasaAnual = pP.TasaAnual;          
        }

        /// <summary>
        /// Método para dar de alta un Cliente. Se guarda en la lista de Clientes de la empresa.
        /// Se verifica que el DNI no se repita mediante una expresión Lambda.
        /// Caso contrario se devuelve una exception personalizada.
        /// </summary>
        public void AltaCliente(ClsCliente pC)
        {
            if (!ListaClientesEmpresa.Exists(x => x.Dni == pC.Dni))
            {
                ListaClientesEmpresa.Add(pC);
            }
            else
            {
                throw new Exception("El Dni " + pC.Dni + " ya existe");
            }
        }

        /// <summary>
        /// Método para dar de Baja un Cliente. Se borra de la lista de clientes
        /// de la empresa, buscando el cliente original mediante una expresion LAMBDA
        /// </summary>
        public void BajaCliente(ClsCliente pC)
        {
            ListaClientesEmpresa.Remove(ListaClientesEmpresa.Find(x => x.Dni == pC.Dni));
        }

        /// <summary>
        /// Método para modificar un Cliente. Se obtiente
        /// el cliente original mediante una expresion LAMBDA y modifico Nombre o Apellido
        /// </summary>
        public void ModificarCliente(ClsCliente pC)
        {
            ClsCliente C = ListaClientesEmpresa.Find(x => x.Dni == pC.Dni);
            C.Nombre = pC.Nombre;
            C.Apellido = pC.Apellido;
        }

        /// <summary>
        /// Método usado para retornar la lista de préstamos de la empresa.
        /// Se retorna una lista clonada para mantener el acoplamiento.
        /// </summary>
        public List<ClsPrestamo> RetornaClonListaPrestamos()
        {
            //En este metodo voy clonando la lista a medida que itero con el foreach.
            //Ya la clase CLsPrestamo implementa ICloneable
            List<ClsPrestamo> ListaClonPrestamos = new List<ClsPrestamo>();
            foreach(ClsPrestamo P in ListaPrestamosEmpresa)
            {
                ListaClonPrestamos.Add((ClsPrestamo)P.Clone());
            }
            return ListaClonPrestamos;
        }

        /// <summary>
        /// Método usado para retornar la lista de clientes de la empresa.
        /// Se retorna una lista clonada para mantener el acoplamiento.
        /// Como variante utilizo LINQ para retornar la lista.
        /// </summary>
        public List<ClsCliente> RetornaListaClientes()
        {
            List<ClsCliente> LC = new List<ClsCliente>();
            //Selecciono todos los clientes que están en la lista de clientes de la empresa.
            var V = from C in ListaClientesEmpresa select C;
            foreach (ClsCliente Cli in V)
            {
                LC.Add(Cli);
            }
            //En este caso para ejemplificar el uso de generics
            //clono la lista con el metodo generico ClonarLista en la clase ClonaLista
            //Le paso el tipo de lista a clonar entre <> y el nombre de la lista. En este caso LC

           return ClonaLista<ClsCliente>.ClonarLista(LC);
            
        }

        /// <summary>
        /// Método usado para retornar la lista de préstamos NO pagados.
        /// Se retorna una lista clonada para mantener el acoplamiento.
        /// Utilizo LINQ para filtrar la lista.
        /// </summary>
        public List<ClsPrestamo> RetornaPrestamosNoPagados()
        {
            List<ClsPrestamo> LP = new List<ClsPrestamo>();
            //Solo se agregan a la lista los préstamos NO Pagados.
            var V = from P in ListaPrestamosEmpresa where P.Pagado == false select P;
            foreach(ClsPrestamo P in V)
            {
                LP.Add((ClsPrestamo)P.Clone());
            }
            return LP;
        }

        /// <summary>
        /// Método usado para retornar la lista de préstamos pagados.
        /// Se retorna una lista clonada para mantener el acoplamiento.
        /// Utilizo LINQ para filtrar la lista.
        /// </summary>
        public List<ClsPrestamo> RetornaPrestamosPagados()
        {
            List<ClsPrestamo> LP = new List<ClsPrestamo>();
            //Solo se agregan a la lista los préstamos NO Pagados.
            var V = from P in ListaPrestamosEmpresa where P.Pagado == true select P;
            foreach (ClsPrestamo P in V)
            {
                LP.Add((ClsPrestamo)P.Clone());
            }
            return LP;
        }

        /// <summary>
        /// Método usado para retornar un Prestamo en particular.
        /// Recibe como referencia un Préstamo pero del Tipo ClsVistaGrilla2
        /// Utilizo expresión LAMBDA para encontrar el prestamo original.
        /// </summary>
        public ClsPrestamo RetornaPrestamo(ClsVistaGrilla2 pVP)
        {
            return ListaPrestamosEmpresa.Find(x => x.IdPrestamo == pVP.Id);
        }

        /// <summary>
        /// Método usado para retornar un Prestamo en particular.
        /// Recibe como referencia un Préstamo pero del Tipo ClsVistaGrilla3a6
        /// Utilizo expresión LAMBDA para encontrar el prestamo original.
        /// </summary>    
        public ClsPrestamo RetornaPrestamo(ClsVistaGrillas3a6 pP) //Sobrecargo el método
        {
            return ListaPrestamosEmpresa.Find(x => x.IdPrestamo == pP.Id);
        }

        /// <summary>
        /// Método usado para retornar un Prestamo en particular.
        /// Recibe como referencia un Préstamo.
        /// Utilizo expresión LAMBDA para encontrar el prestamo original.
        /// </summary>
        public ClsPrestamo RetornaPrestamoOriginal(ClsPrestamo pP)
        {
            return ListaPrestamosEmpresa.Find(x => x.IdPrestamo == pP.IdPrestamo);
        }

        /// <summary>
        /// Método usado para retornar un Cliente en particular.
        /// Recibe como referencia un Cliente que está clonado en la Grilla.
        /// Utilizo expresión LAMBDA para encontrar el Cliente original.
        /// </summary>
        public ClsCliente RetornaCliente(ClsCliente pC)
        {
            return ListaClientesEmpresa.Find(x => x.Dni == pC.Dni);
        }

        /// <summary>
        /// Método usado para verificar cuales son los préstamos que vencieron
        /// al modificar la fecha actual. Es el encargado de invocar el evento
        /// de ser necesario
        /// </summary>
        public void VerificarVencimientos(DateTime pFechaActual)
        {
            //Vacio la lista de prestamos que voy a mostrar en el evento
            ListaEventoPrestamosVencidos.Clear();
            foreach(ClsPrestamo P in ListaPrestamosEmpresa)
            {
                //Solo me fijo los vencimientos de los prestamos que no fueron pagados
                if (P.Pagado == false)
                {
                    //Si el prestamo vence
                    if (P.FechaDevolucion < pFechaActual)
                    {
                        P.Vencido = true;
                        ListaEventoPrestamosVencidos.Add(P);
                    }
                    else
                    {
                        P.Vencido = false;
                    }
                }                                 
            }
            //Si la lista tiene algún préstamo realizo la invocación del evento.
            if (ListaEventoPrestamosVencidos.Count() > 0)
            {
                PrestamosVencidos?.Invoke(this, new PrestamosVencidosEventArgs(ListaEventoPrestamosVencidos));
            }          
        }

        /// <summary>
        /// //Metodo para pagar el prestamo.
        /// Sobreescribo la fecha de devolucion con la fecha de pago y lo marco como pagado.
        /// </summary>
        public void PagarPrestamo(ClsPrestamo pP, DateTime pFecha)
        {
            ClsPrestamo P = ListaPrestamosEmpresa.Find(x => x.IdPrestamo == pP.IdPrestamo);
            P.FechaDevolucion = pFecha;
            P.Pagado = true;
        }

        #endregion

        #region DESTRUCTOR Y DISPOSE

        bool _DisposeOk = false;
        ~ClsEmpresa()
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
