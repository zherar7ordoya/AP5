using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CANCELOS_POO_2P
{
    public partial class Form1 : Form
    {
        #region CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region VARIABLES GLOBALES

        //Instancio la Empresa que es la que maneja las listas de prestamos y clientes
        ClsEmpresa MiEmpresa = new ClsEmpresa();
        //Instancio las clases vista para mostrar las grillas
        ClsVistaGrilla2 ListaVistaGrilla2 = new ClsVistaGrilla2();
        ClsVistaGrillas3a6 ListaVistaGrilla3 = new ClsVistaGrillas3a6();
        ClsVistaGrillas3a6 ListaVistaGrilla4 = new ClsVistaGrillas3a6();
        ClsVistaGrillas3a6 ListaVistaGrilla5 = new ClsVistaGrillas3a6();
        ClsVistaGrillas3a6 ListaVistaGrilla6 = new ClsVistaGrillas3a6();
        ClsVistaGrilla7 ListaVistaGrilla7 = new ClsVistaGrilla7();
        //Variable para simular la fecha actual. La inicializo en la fecha actual del sistema
        DateTime FechaActual = DateTime.Today;

        #endregion

        #region FORMLOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //inicializo el textbox y el label a la FechaActual
            txtFecha.Text = FechaActual.ToShortDateString();
            lblFecha.Text = FechaActual.ToShortDateString();
            //Configuro Las Grillas
            ConfigurarGrilla(Grilla1);
            ConfigurarGrilla(Grilla2);
            ConfigurarGrilla(Grilla3);
            ConfigurarGrilla(Grilla4);
            ConfigurarGrilla(Grilla5);
            ConfigurarGrilla(Grilla6);
            ConfigurarGrilla(Grilla7);
            //Suscribo al Evento Prestamos Vencidos. El desencadenamiento está en la funcion VerificarVencimientos de la clase empresa.
            MiEmpresa.PrestamosVencidos += new EventHandler<PrestamosVencidosEventArgs>(this.FuncionEventoPrestamoVencido);

        }
        #endregion

        #region EVENTO

        private void FuncionEventoPrestamoVencido(object sender, PrestamosVencidosEventArgs e)
        {
            //Instancio un formulario para mostrar la grilla con los Préstamos Vencidos
            //Le paso en el constructor la lista de prestamos vencidos que trae en el parametro e
            FormEvento Form2 = new FormEvento(e.PrestamosVencidos, FechaActual);
            Form2.ShowDialog(); //Muestro el formulario           
        }

        #endregion

        #region GRILLAS

        /// <summary>
        /// Configuro las grillas, colores, ancho de columnas y demás detalles
        /// </summary>
        private void ConfigurarGrilla(DataGridView pD)
        {
            pD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pD.MultiSelect = false;
            pD.EnableHeadersVisualStyles = false; //Anula el estilo visual de Windows
            pD.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff; // Color de la alternancia
            pD.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon; // Encabezado de Columnas
            pD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de Fuente del encabezado
            pD.RowHeadersDefaultCellStyle.BackColor = Color.IndianRed; // Color del encabezado de Fila    
            pD.RowHeadersWidth = 30;
            pD.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Firebrick;
            pD.DefaultCellStyle.SelectionBackColor = Color.Firebrick; // Color de fondo de Selección de la fila
            pD.DefaultCellStyle.SelectionForeColor = Color.White; // Color de la fuente de la fila seleccionada
            pD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // Celdas Autoajustables
            pD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Alineación del Texto
            pD.BackgroundColor = Color.PeachPuff; // Color de Fondo           
        }

        private void MostrarGrilla1() //Muestro la Grilla1
        {
            Grilla1.DataSource = null;
            if (MiEmpresa.RetornaListaClientes().Count() > 0)
            {
                //Recibo una lista de clientes clonados de la empresa.
                Grilla1.DataSource = MiEmpresa.RetornaListaClientes().ToList<ClsCliente>();
            }
        }

        private void MostrarGrilla2() //Muestro Grilla2
        {
            Grilla2.DataSource = null;
            if (ListaVistaGrilla2.RetornaListaVistaGrilla2(MiEmpresa.RetornaClonListaPrestamos()).Count() > 0)
            {
                //Le paso a la grilla una lista vista
                Grilla2.DataSource = ListaVistaGrilla2.RetornaListaVistaGrilla2(MiEmpresa.RetornaClonListaPrestamos()).ToList<ClsVistaGrilla2>();
                //Nombres de las columnas
                Grilla2.Columns[2].HeaderText = "Plazo Meses";
                Grilla2.Columns[4].HeaderText = "Monto Interés";
                Grilla2.Columns[5].HeaderText = "Total a Retornar";
            }
        }

        private void MostrarGrilla3() //Muestro Grilla3
        {
            Grilla3.DataSource = null;
            if (MiEmpresa.RetornaPrestamosNoPagados().Count > 0)
            {
                //Le paso a la grilla una lista vista
                Grilla3.DataSource = ListaVistaGrilla3.RetornaListaVistaGrillas3a6(MiEmpresa.RetornaPrestamosNoPagados()).ToList<ClsVistaGrillas3a6>();
               //Nombres de las columnas
                Grilla3.Columns[4].HeaderText = "Interés";
            }
        }

        private void MostrarGrilla4() //Muestro Grilla4
        {
            Grilla4.DataSource = null;
            if (MiEmpresa.RetornaPrestamosPagados().Count > 0)
            {
                //Le paso a la grilla una lista vista
                Grilla4.DataSource = ListaVistaGrilla4.RetornaListaVistaGrillas3a6(MiEmpresa.RetornaPrestamosPagados()).ToList<ClsVistaGrillas3a6>();
                //Nombres de las columnas
                Grilla4.Columns[4].HeaderText = "Interés";
            }
        }

        private void MostrarGrilla5() //Muestro Grilla5
        {
            Grilla5.DataSource = null;
            try
            {
                //Primero obtengo el cliente original seleccionado
                ClsCliente C = new ClsCliente();
                C = MiEmpresa.RetornaCliente(Grilla1.SelectedRows[0].DataBoundItem as ClsCliente);
                if (C.RetornaPrestamosNoPagadosCliente().Count > 0)
                {
                    //Le paso a la grilla una lista Vista
                    Grilla5.DataSource = ListaVistaGrilla5.RetornaListaVistaGrillas3a6(C.RetornaPrestamosNoPagadosCliente()).ToList<ClsVistaGrillas3a6>();
                    Grilla5.Columns[4].HeaderText = "Interés";
                }
            }
            catch (Exception) { }
        }

        private void MostrarGrilla6() //Muestro Grilla6
        {
            Grilla6.DataSource = null;
            try
            {
                //Primero obtengo el cliente original seleccionado
                ClsCliente C = new ClsCliente();
                C = MiEmpresa.RetornaCliente(Grilla1.SelectedRows[0].DataBoundItem as ClsCliente);
                if (C.RetornaPrestamosPagadosCliente().Count > 0)
                {
                    //Le paso a la grilla una lista vista
                    Grilla6.DataSource = ListaVistaGrilla6.RetornaListaVistaGrillas3a6(C.RetornaPrestamosPagadosCliente()).ToList<ClsVistaGrillas3a6>();
                    Grilla6.Columns[4].HeaderText = "Interés";
                }
            }
            catch (Exception) { }
        }

        private void MostrarGrilla7() //Muestro Grilla7
        {
            Grilla7.DataSource = null;
            try
            {
                //Primero obtengo el cliente original seleccionado
                ClsCliente C = new ClsCliente();
                C = MiEmpresa.RetornaCliente(Grilla1.SelectedRows[0].DataBoundItem as ClsCliente);
                if (C.RetornaPrestamosVencidosCliente(FechaActual).Count > 0)
                {
                   //Le paso a la grilla una lista vista
                    Grilla7.DataSource = ListaVistaGrilla7.RetornaListaVistaGrilla7((C.RetornaPrestamosVencidosCliente(FechaActual)), FechaActual).ToList<ClsVistaGrilla7>();
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Actualiza las grillas 5 6 y 7 según se desplace por las celdas de la grilla1
        /// </summary>
        private void Grilla1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostrarGrilla5();
            MostrarGrilla6();
            MostrarGrilla7();
        }

        /// <summary>
        /// Actualiza Todas las grillas a la vez
        /// </summary>
        private void ActualizarGrillas()
        {
            MostrarGrilla1();
            MostrarGrilla2();
            MostrarGrilla3();
            MostrarGrilla4();
            MostrarGrilla5();
            MostrarGrilla6();
            MostrarGrilla7();
        }

        #endregion

        #region ABM PRESTAMO

        private void btnAltaPrestamo_Click(object sender, EventArgs e) //Alta de Prestamo
        {
            try
            {
                //Pregunto por el tipo de prestamo
                string Tipo = Interaction.InputBox("Tipo de Préstamo\n\n" +
                    "Seleccione la opción deseada:\n\n" +
                    "1-Pesos\n" +
                    "2-Dólares", "Alta Préstamo", "1");
                //Verifico que se seleccione una opción valida, caso contrario salta una excepcion
                if (Tipo != "1" && Tipo != "2") { throw new Exception("Opción inválida"); }
                //Pregunto por el ID. Sugiero un codigo generado automaticamente, pero este puede ser cambiado por el usuario.
                string Id = Interaction.InputBox("ID Prestamo: \n\n" +
                    "El Id autogenerado puede cambiarse por el deseado.\n" +
                    "Luego será validado.", "Alta Préstamo", GenerarCodigo());
                //Si se ingresan letras minúsculas lo paso a mayuscuala
                Id=Id.ToUpper();
                //Preunto por el Capital, verificando que sea del formato correcto
                double Capital;
                try { Capital = Convert.ToDouble(Interaction.InputBox("Capital solicitado: ", "Alta Préstamo", "1000")); }
                catch (Exception) { throw new Exception("Formato incorrecto"); }
                //Pregunto por la Tasa, validando el formato.
                double Tasa;
                try { Tasa = Convert.ToDouble(Interaction.InputBox("T.N.A\n\nTasa Nominal Anual", "Alta Préstamo", "15")); }
                catch (Exception) { throw new Exception("Formato incorrecto"); }
                //Pregunto por el plazo en meses. Validando el formato.
                int Plazo;
                try { Plazo = Convert.ToInt32(Interaction.InputBox("Plazo en cantidad de meses: ", "Alta Préstamo", "3")); }
                catch (Exception) { throw new Exception("Formato incorrecto"); }
                //Pregunto por la fecha de adjudicacion.
                DateTime FechaAdjudicacion;
                try { FechaAdjudicacion = Convert.ToDateTime(Interaction.InputBox("Fecha de Adjudicación ", "Alta Préstamo", FechaActual.ToShortDateString())); }
                catch (Exception) { throw new Exception("Formato de fecha incorrecto"); }
               
                if (Tipo == "1")
                {
                    //Si se trata de un prestamo en pesos instancio un Prestamo en pesos
                    ClsPrestamoPesos PP = new ClsPrestamoPesos();
                    //Cargo el Id
                    PP.IdPrestamo = Id;

                    //Recorro con un foreach el objeto credo con el Id, donde se valida en el MoveNext(). Usando la interface IEnumerable y
                    //IEnumerator. Lo uso solo para demostrar el uso de la Interface IEnumerable IEnumerator
                    foreach (string s in PP) { }
                    //Si no saltó ninguna exception en el iterador quiere decir que el ID está ok y sigo cargando los datos.
                    PP.CapitalSolicitado = Capital;
                    PP.TasaAnual = Tasa;
                    PP.Plazo = Plazo;
                    PP.FechaAdjudicacion = FechaAdjudicacion;
                    PP.FechaDevolucion = FechaAdjudicacion.AddMonths(Plazo);
                    PP.Pagado = false;
                    //Doy de alta el prestamo en la Empresa
                    MiEmpresa.AltaPrestamo(PP);                                    
                    //Actualizo grillas
                    MostrarGrilla2();
                    MostrarGrilla3();
                    MostrarGrilla4();
                }
                else
                {
                    //Si es un prestamo en dolares instancio un prestamo en dolares
                    ClsPrestamoDolares PD = new ClsPrestamoDolares();
                    PD.IdPrestamo = Id;
                    //Recorro con un foreach el objeto credo con el Id, donde se valida en el MoveNext(). Usando la interface IEnumerable y
                    //IEnumerator. Lo uso solo para demostrar el uso de la Interface IEnumerable IEnumerator
                    foreach (string s in PD) { }
                    //Si no saltó ninguna exception en el iterador quiere decir que el ID está ok y sigo cargando los datos.
                    PD.CapitalSolicitado = Capital;
                    PD.TasaAnual = Tasa;
                    PD.Plazo = Plazo;
                    PD.FechaAdjudicacion = FechaAdjudicacion;
                    PD.FechaDevolucion = FechaAdjudicacion.AddMonths(Plazo);
                    PD.Pagado = false;
                    //Agrego el Prestamo a la empresa
                    MiEmpresa.AltaPrestamo(PD);                                            
                    //Actualizo grillas correspondientes
                    MostrarGrilla2();
                    MostrarGrilla3();
                    MostrarGrilla4();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBajaPrestamo_Click(object sender, EventArgs e) //Baja Prestamo
        {
            try
            {
                //Obtengo un Prestamo del tipo Vista de la grilla2. Si no hay préstamos salta una exception
                ClsVistaGrilla2 vP = new ClsVistaGrilla2();
                try { vP = Grilla2.SelectedRows[0].DataBoundItem as ClsVistaGrilla2; }
                catch (Exception) { throw new Exception("No hay préstamos"); }

                //no permito que se de de baja un préstamo asignado a un cliente
                if (MiEmpresa.RetornaPrestamo(vP).RetornaCliente().Dni != null)
                {
                    throw new Exception("No se puede dar de baja un préstamo asignado a un cliente.\n\n" +
                            "Solo es posible dar de baja préstamos NO asignados.");
                }
                //Confirmo la baja con una pregunta
                var pregunta = MessageBox.Show("Está seguro que quiere dar de baja el préstamo seleccionado?\n\n" +
                    "Esta situación es irreversible", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    //Doy de baja el prestamo en la empresa
                    MiEmpresa.BajaPrestamo(vP);
                    //Actualizo grillas
                    MostrarGrilla2();
                    MostrarGrilla3();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModPrestamo_Click(object sender, EventArgs e) //Modificar Préstamo
        {
            try
            {
                //Obtengo un Prestamo del tipo Vista de la grilla2
                ClsVistaGrilla2 vP = new ClsVistaGrilla2();
                try { vP = Grilla2.SelectedRows[0].DataBoundItem as ClsVistaGrilla2; }
                catch (Exception) { throw new Exception("No hay préstamos"); }
                //Obtengo un clon del Prestamo original
                ClsPrestamo P = (ClsPrestamo)MiEmpresa.RetornaPrestamo(vP).Clone();
                //No permito que se modifique un prestamo pagado
                if (P.Pagado == true)
                {
                    throw new Exception("No se puede modificar un préstamo pagado.\n\n" +
                        "Forma parte del histórico de datos.");
                }
                //No permito modificar un prestamo asignado y vencido
                if (P.RetornaCliente().Dni != null && P.Vencido == true)
                {
                    throw new Exception("No se puede modificar un préstamo asignado y vencido.\n\n" +
                        "Forma parte del histórico de datos.");
                }
                //Modifico los datos permitidos
                try { P.CapitalSolicitado = Convert.ToDouble(Interaction.InputBox("Capital solicitado: ", "Alta Préstamo", P.CapitalSolicitado.ToString())); }
                catch (Exception) { throw new Exception("Formato incorrecto"); }

                try { P.TasaAnual = Convert.ToDouble(Interaction.InputBox("T.E.A\n\nTasa Efectiva Anual", "Alta Préstamo", P.TasaAnual.ToString())); }
                catch (Exception) { throw new Exception("Formato incorrecto"); }

                try { P.Plazo = Convert.ToInt32(Interaction.InputBox("Plazo en cantidad de meses: ", "Alta Préstamo", P.Plazo.ToString())); }
                catch (Exception) { throw new Exception("Formato incorrecto"); }

                try { P.FechaAdjudicacion = Convert.ToDateTime(Interaction.InputBox("Fecha de Adjudicación ", "Alta Préstamo", P.FechaAdjudicacion.ToShortDateString())); }
                catch (Exception) { throw new Exception("Formato de fecha incorrecto"); }

                //Actualizo la fecha de devolucion
                P.FechaDevolucion = P.FechaAdjudicacion.AddMonths(P.Plazo);
                //Modifico el Prestamo
                MiEmpresa.ModificarPrestamo(P);

                //Actualizo grillas
                MostrarGrilla2();
                MostrarGrilla3();
                MostrarGrilla4();
                MostrarGrilla5();
                MostrarGrilla6();
                MostrarGrilla7();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region ABM CLIENTE

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Cargo los datos del cliente
                string Nombre = Interaction.InputBox("Nombre: ", "Alta Cliente");
                string Apellido = Interaction.InputBox("Apellido: ", "Alta Cliente");
                string Dni = Interaction.InputBox("Dni:\n\n (Dni autogenerado para facilitar las pruebas,\n\n" +
                    "Puede cambiarse por el deseado)", "Alta Cliente", GenerarDni());
                //Instancio un cliente
                ClsCliente C = new ClsCliente();
                //Le paso los datos ingresados
                C.Nombre = Nombre;
                C.Apellido = Apellido;
                C.Dni = Dni;
                //Si está todo ok se da de alta el cliente en la Empresa
                MiEmpresa.AltaCliente(C);
                //Actualizo grillas
                ActualizarGrillas();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtengo el Cliente de la grilla
                ClsCliente C = new ClsCliente();
                try { C = Grilla1.SelectedRows[0].DataBoundItem as ClsCliente; }
                catch (Exception) { throw new Exception("No hay Clientes"); }
                //Obtengo el cliente original
                ClsCliente Cli = MiEmpresa.RetornaCliente(C);

                //Si el cliente tiene préstamos pagados o vencidos
                // no se puede dar de baja.
                //Ya que los datos forman parte del histórico de préstamos

                if (Cli.RetornaPrestamosPagadosCliente().Count > 0 || Cli.RetornaPrestamosVencidosCliente(FechaActual).Count() > 0)
                {
                    throw new Exception("No se puede dar de baja un cliente que posee préstamos pagados o vencidos.\n\n" +
                        "Forman parte del histórico.");
                }

                //Ahora pregunto si tiene créditos no pagados
                if (Cli.RetornaPrestamosNoPagadosCliente().Count() > 0)
                {
                    var Pregunta = MessageBox.Show("El cliente que desea dar de baja posee préstamos asignados aún no pagados.\n\n" +
                        "Si lo da de baja se desasignarán los préstamos y estos podrán asignarse a otro cliente.\n\n" +
                        "Esta situación es irreversible.\n\n" +
                        "Aun quiere dar de baja el cliente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Pregunta == DialogResult.Yes)
                    {
                        //Si presiona Si procedo a dar de baja los titulares de cada prestamo asignado al cliente
                        foreach (ClsPrestamo P in Cli.RetornaPrestamosNoPagadosCliente())
                        {
                            MiEmpresa.RetornaPrestamoOriginal(P).DesasignarCliente();
                        }
                        //Doy de baja el cliente
                        MiEmpresa.BajaCliente(C);
                        //Actualizo grillas
                        ActualizarGrillas();
                    }
                }
                //Si no tiene prestamos, igualmente confirmo con una pregunta antes de darlo de baja.
                else
                {
                    var Pregunta = MessageBox.Show("Desea dar de baja el cliente " + C.Apellido + ", " + C.Nombre + " ?\n\n" +
                        "Esta situación es irreversible."
                       , "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Pregunta == DialogResult.Yes)
                    {
                        //Doy de baja el cliente
                        MiEmpresa.BajaCliente(C);
                        //Actualizo grillas
                        ActualizarGrillas();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtengo el Cliente clonado de la grilla 1
                ClsCliente C = new ClsCliente();
                try {C = Grilla1.SelectedRows[0].DataBoundItem as ClsCliente; }
                catch (Exception) { throw new Exception("No hay Clientes"); }

                //Modifico los datos en el CLON
                C.Nombre = Interaction.InputBox("Nombre: ", "Modificar Cliente", C.Nombre);
                C.Apellido = Interaction.InputBox("Apellido: ", "Modificar Cliente", C.Apellido);

                //La empresa se encarga de modificar el cliente original

                MiEmpresa.ModificarCliente(C);
                //Actualizo grillas
                ActualizarGrillas();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region ASIGNACIONES DESASIGNACIONES Y PAGOS DE PRESTAMO

        private void btnAsignarPrestamo_Click(object sender, EventArgs e) //Asignar Prestamo
        {
            try
            {
                //Obtengo un Prestamo del tipo Vista de la grilla2
                ClsVistaGrilla2 vP = new ClsVistaGrilla2();
                try { vP = Grilla2.SelectedRows[0].DataBoundItem as ClsVistaGrilla2; }
                catch (Exception) { throw new Exception("No hay préstamos"); }
                //Obtengo el Prestamo original
                ClsPrestamo P = MiEmpresa.RetornaPrestamo(vP);

                //Obtengo el Cliente Clon de la grilla
                ClsCliente CClon = new ClsCliente();
                try {CClon = Grilla1.SelectedRows[0].DataBoundItem as ClsCliente; }
                catch (Exception) {throw new Exception("No hay Clientes"); }

                //Obtengo el cliente original
                ClsCliente Cli = MiEmpresa.RetornaCliente(CClon);

                //Chequeo que el préstamo no tenga Cliente asignado
                if (P.RetornaCliente().Dni != null)
                {
                    throw new Exception("Este préstamo ya está asignado a un cliente.");
                }
                //Cheque que no esté vencido
                if (P.FechaDevolucion < FechaActual)
                {
                    throw new Exception("Este préstamo está vencido y no se puede asignar.");
                }             

                //Asigno el Cliente original al prestamo
                P.AsignarCliente(Cli);
                //Asigno el prestamo al cliente
                Cli.AsignarPrestamo(P);
                //Actualizo grillas
                MostrarGrilla2();
                MostrarGrilla5();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDesasignarPrestamo_Click(object sender, EventArgs e) //Desasignar Prestamo
        {
            try
            {
                ClsPrestamo P;
                //Obtengo el Prestamo original de la grilla 5 que quiero desasignar
                try { P = MiEmpresa.RetornaPrestamo(Grilla5.SelectedRows[0].DataBoundItem as ClsVistaGrillas3a6); }
                catch (Exception) { throw new Exception("No hay préstamos para desasignar"); }

                var pregunta = MessageBox.Show("Está seguro que quiere desasignar el préstamo seleccionado \n\n" +
                    "que actualmente se encuentra asignado a:\n\n " + P.RetornaCliente().Apellido + ", " + P.RetornaCliente().Nombre +
                    " ?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    //Obtengo el titular del prestamo
                    ClsCliente C = P.RetornaCliente();
                    //Desasigno el cliente del prestamo
                    P.DesasignarCliente();                  
                    //Desasigno el prestamo del cliente
                    C.DesasignarPrestamo(P);
                    //Actualizo las grillas
                    MostrarGrilla2();
                    MostrarGrilla5();
                    MostrarGrilla7();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPagarPrestamo_Click(object sender, EventArgs e) //Pagar Prestamo
        {
            try
            {
                ClsPrestamo P;
                //Obtengo el Prestamo de la grilla 5 que quiero pagar
                try { P = MiEmpresa.RetornaPrestamo(Grilla5.SelectedRows[0].DataBoundItem as ClsVistaGrillas3a6); }
                catch (Exception) { throw new Exception("No hay préstamos para pagar"); }

                //Si el prestamo está vencido no puedo pagarlo
                if (P.FechaDevolucion < FechaActual)
                {
                    throw new Exception("No se puede pagar un préstamo vencido.\n\nEl préstamo ha sido pasado a legales.");
                }
                //Cargo una fecha de pago que tiene que estar entre las fechas de asjudicacion y de devolucion.
                DateTime FechaDevolucion;
                try { FechaDevolucion = Convert.ToDateTime(Interaction.InputBox("Ingrese fecha de pago: \n\n" +
                    "Fecha de Adjudicación: "+P.FechaAdjudicacion.ToShortDateString() +"\n\n" +
                    "Fecha de Vencimiento: "+P.FechaDevolucion.ToShortDateString(), "Pagar crédito",P.FechaDevolucion.ToShortDateString())); }
                catch (Exception)
                { throw new Exception("Formato de fecha incorrecto"); }
                //Si la fecha está fuera de los limites Adjudicacion-Devolucion salta una excepcion
                if (FechaDevolucion < P.FechaAdjudicacion || FechaDevolucion > P.FechaDevolucion)
                {
                    throw new Exception("La fecha de pago debe estar entre la Fecha de Adjudicación y Fecha de Vencimiento del Préstamo.\n\n" +
                        "En este caso debe estar entre " + P.FechaAdjudicacion.ToShortDateString() + " y " +
                        P.FechaDevolucion.ToShortDateString() + "\n\n" +
                        "Por favor ingrese otra fecha.");
                }
                //Calculo los dias de interes
                int dias = (FechaDevolucion - P.FechaAdjudicacion).Days;
                //Pregunto si deseo pagar el credito y muestro los dias de interés que se computarán.
                var pregunta = MessageBox.Show("Al pagar el préstamo antes del vencimiento se recalcularan los intereses al día de pago.\n\n" +

                    "En este caso se computará " + dias + "  día/s de interés\n\n" +

                    "Quiere pagar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Si la respuesta es si continuo.
                if (pregunta == DialogResult.Yes)
                {
                    //Pago el prestamo. Le paso por referencua el Prestamo y la fecha de pago
                    MiEmpresa.PagarPrestamo(P, FechaDevolucion);
                    //Actualizo grillas
                    MostrarGrilla3();
                    MostrarGrilla4();
                    MostrarGrilla5();
                    MostrarGrilla6();
                }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}
        }

        private void btnDeshacerPago_Click(object sender, EventArgs e) //Deshacer Pago
        {
            try
            {
                ClsPrestamo P;
                //Obtengo el Prestamo de la grilla 6 que quiero deshacer el pago
                try { P = MiEmpresa.RetornaPrestamo(Grilla6.SelectedRows[0].DataBoundItem as ClsVistaGrillas3a6); }
                catch (Exception) { throw new Exception("No hay préstamos pagados."); }

                var pregunta = MessageBox.Show("Al deshacer el pago  se recalcularan los intereses al plazo total del credito.\n\n" +

                   "Si el credito está vencido no podrá volver a pagarse."  + "\n\n" +

                   "Quiere deshacer el pago?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    //Marco el prestamo como NO pagado
                    P.Pagado = false;
                    //Sobreescribo la fecha de devolucion con la del plazo total del prestamo
                    P.FechaDevolucion = P.FechaAdjudicacion.AddMonths(P.Plazo);
                    //Actualizo grillas
                    MostrarGrilla3();
                    MostrarGrilla4();
                    MostrarGrilla5();
                    MostrarGrilla6();
                    MostrarGrilla7();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } 

        #endregion

        #region FUNCIONES AUXILIARES

        /// <summary>
        /// Verifica los limites de fecha inferior y superior. En caso de exceder los limites
        /// Se encarga de disparar una excepcion.
        /// </summary>
        private void VerificarLimitesFecha(DateTime pFecha)
        {
            if (pFecha < Convert.ToDateTime("01/01/1900") || pFecha > Convert.ToDateTime("31/12/2100"))
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                throw new FechaException(pFecha);
            }
        }

        /// <summary>
        /// Este método es solo para facilitar el ingreso de los datos. Y no tener que cargar un Id distinto cada vez.
        /// Se puede cambiar por otro en el inputbox. 
        /// De todas maneras luego será validado.
        /// </summary>
        private string GenerarCodigo()
        {
            string codigo = "";
            Random rnd = new Random();
            for (int i = 1; i <= 4; i++)
            {
                codigo += (char)rnd.Next('A', 'Z');
            }
            codigo += "-";
            int num1 = (int)rnd.Next(100000, 999999);
            codigo += num1.ToString();

            codigo = codigo.ToUpper();
            return codigo;
        }

        /// <summary>
        /// Este método es solo para facilitar el ingreso de los datos. Y no tener que cargar un DNI cada vez
        /// </summary>
        private string GenerarDni()
        {
            string Dni = "";
            Random rnd = new Random();
            int num1 = (int)rnd.Next(10000000, 60999999);
            Dni = num1.ToString();
            return Dni;
        }

        /// <summary>
        /// Botón que abre un formulario con información sobre el programa.
        /// </summary>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Informacion info = new Informacion();
            info.ShowDialog();
        }

        #endregion

        #region MODIFICAR FECHA

        //Botón Modificar Fecha
        private void btnModFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime NuevaFecha;
                //Valido que la fecha del textbox tenga el formato correcto
                try { NuevaFecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception)
                {
                    txtFecha.Text = FechaActual.ToShortDateString();
                    throw new Exception("Formato incorrecto de Fecha");
                }           
                //Verifico que la fecha ingresada está dentro de los limites
                VerificarLimitesFecha(NuevaFecha);
                //Si está todo ok confirmo la fecha actual
                FechaActual = NuevaFecha;
                //La muestro en el TextBox y en el Label
                txtFecha.Text = FechaActual.ToShortDateString();
                lblFecha.Text = FechaActual.ToShortDateString();              
                //Actualizo grillas
                MostrarGrilla7();
                //Chequeo los vencimientos
                MiEmpresa.VerificarVencimientos(FechaActual);
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
        }

        //Boton que suma años
        private void btnSumarAños_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha;
                try { Fecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception) { throw new Exception("Formato incorrecto de fecha"); }

                Fecha = Fecha.AddYears(1);
                VerificarLimitesFecha(Fecha);
                txtFecha.Text = Fecha.ToShortDateString();
                FechaActual = Fecha;
                lblFecha.Text = FechaActual.ToShortDateString();
                MostrarGrilla7();
                MiEmpresa.VerificarVencimientos(FechaActual);            
            }
            catch (Exception ex)
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                MessageBox.Show(ex.Message);
            }
        }

        //Boton que suma meses
        private void btnSumarMeses_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha;
                try { Fecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception) { throw new Exception("Formato incorrecto de fecha"); }
                Fecha = Fecha.AddMonths(1);
                VerificarLimitesFecha(Fecha);
                txtFecha.Text = Fecha.ToShortDateString();
                FechaActual = Fecha;
                lblFecha.Text = FechaActual.ToShortDateString();
                MostrarGrilla7();
                MiEmpresa.VerificarVencimientos(FechaActual);               
            }
            catch (Exception ex)
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                MessageBox.Show(ex.Message);
            }

        }

        //Boton que suma días
        private void btnSumarDias_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha;
                try { Fecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception) { throw new Exception("Formato incorrecto de fecha"); }
                Fecha = Fecha.AddDays(1);
                VerificarLimitesFecha(Fecha);
                txtFecha.Text = Fecha.ToShortDateString();
                FechaActual = Fecha;
                lblFecha.Text = FechaActual.ToShortDateString();
                MostrarGrilla7();
                MiEmpresa.VerificarVencimientos(FechaActual);              
            }
            catch (Exception ex)
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                MessageBox.Show(ex.Message);
            }
        }

        //Boton que resta días
        private void btnRestarDias_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha;
                try { Fecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception) { throw new Exception("Formato incorrecto de fecha"); }
                Fecha = Fecha.AddDays(-1);
                VerificarLimitesFecha(Fecha);
                txtFecha.Text = Fecha.ToShortDateString();
                FechaActual = Fecha;
                lblFecha.Text = FechaActual.ToShortDateString();
                MostrarGrilla7();
                MiEmpresa.VerificarVencimientos(FechaActual);              
            }
            catch (Exception ex)
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                MessageBox.Show(ex.Message);
            }

        }

        //Boton que resta meses
        private void btnRestarMeses_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha;
                try { Fecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception) { throw new Exception("Formato incorrecto de fecha"); }
                Fecha = Fecha.AddMonths(-1);
                VerificarLimitesFecha(Fecha);
                txtFecha.Text = Fecha.ToShortDateString();
                FechaActual = Fecha;
                lblFecha.Text = FechaActual.ToShortDateString();
                MostrarGrilla7();
                MiEmpresa.VerificarVencimientos(FechaActual);              
            }
            catch (Exception ex)
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                MessageBox.Show(ex.Message);
            }
        }

        //Boton que resta años
        private void btnRestarAños_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha;
                try { Fecha = Convert.ToDateTime(txtFecha.Text); }
                catch (Exception) { throw new Exception("Formato incorrecto de fecha"); }
                Fecha = Fecha.AddYears(-1);
                VerificarLimitesFecha(Fecha);
                txtFecha.Text = Fecha.ToShortDateString();
                FechaActual = Fecha;
                lblFecha.Text = FechaActual.ToShortDateString();
                MostrarGrilla7();
                MiEmpresa.VerificarVencimientos(FechaActual);              
            }
            catch (Exception ex)
            {
                txtFecha.Text = FechaActual.ToShortDateString();
                MessageBox.Show(ex.Message);
            }
        }

        //Evento para cuando se presiona la tecla enter en el textbox
        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {              
                try
                {
                    DateTime NuevaFecha;
                    try { NuevaFecha = Convert.ToDateTime(txtFecha.Text); }
                    catch (Exception)
                    {
                        txtFecha.Text = FechaActual.ToShortDateString();
                        throw new Exception("Formato incorrecto de Fecha");
                    }
                    //Verifico los limutes
                    VerificarLimitesFecha(NuevaFecha);
                    //Si está ok actualizo la fecha
                    FechaActual = NuevaFecha;
                    txtFecha.Text = FechaActual.ToShortDateString();
                    lblFecha.Text = FechaActual.ToShortDateString();
                    //Actualizo las grillas
                    MostrarGrilla7();
                    //Verifico vencimientos
                    MiEmpresa.VerificarVencimientos(FechaActual);                  
                }
                catch (Exception ex) {MessageBox.Show(ex.Message);  }
            }
        }

        #endregion
     
    }
}
