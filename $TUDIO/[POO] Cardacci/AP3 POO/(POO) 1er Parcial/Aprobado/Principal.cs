using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace PrimerParcialPOO
{
    public partial class Principal : Form
    {

       
        List<Directivo> listaDirectivos = new List<Directivo>(); //Lista de los directivos
        List<Administrativo> listaAdministrativos = new List<Administrativo>(); //Lista de los administrativos 
        List<Operario> listaOperarios = new List<Operario>(); //Lista de los operarios
        List<Empleado> listaVacia = new List<Empleado>(); //Lista de los empleados
        List<Adelanto> listaAdelantos = new List<Adelanto>(); //Lista de adelantos
        List<Adelanto> listaDeudas = new List<Adelanto>(); //Lista de deudas
        public Principal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Desde aca se hacen las actulizaciones del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            //Estas lines son para que no se puedan elegir varias filas juntas
            dgvEmpleado.MultiSelect = false;
            dgvAdelantos.MultiSelect = false;
            dgvBeneficiarios.MultiSelect = false;

            ///Estas lineas son las que refrescan la grilla
            Enlazar(dgvAdelantos, listaAdelantos);
            Enlazar(dgvEmpleado, listaVacia);
            Enlazar(dgvBeneficiarios, listaDeudas);

            //Estas lineas son las que dejan seleccionada toda la linea de la grilla
            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdelantos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeneficiarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Esta linea hace que en la segunda grilla no salga el legajo del empleado
            dgvAdelantos.Columns["Empleado"].Visible = false;
        }
        /// <summary>
        /// Boton para agregar empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbTodos.Checked == true) //Se comprueba que si esta en todos el checked que no se pueda cargar nada
                {
                    throw new Exception("No puede cargar sin un puesto");
                }
                else
                {
                    string nombre, apellido;
                    int legajo;
                    decimal sueldo;
                    if (rbAdministrativo.Checked == false && rbDirectivo.Checked == false && rbOperario.Checked == false &&
                        rbTodos.Checked == false) //Se asegura que donde se van a cargar hay uno en true por lo menos
                    {
                        throw new Exception("Debe seleccionar un sector");
                    }
                    else
                    {
                        legajo = Convert.ToInt32(Interaction.InputBox("Legajo: ")); //Linea de carga del Legajo
                        Regex rgx = new Regex(@"^[0-9]{4}$"); //Regex para controlar el ingreso de los numeros del legajo
                        if (rgx.IsMatch(legajo.ToString())) //Se comprueba lo ingresado como legajo
                        {
                            foreach (Directivo direc in listaDirectivos) //Bucle que busca si el numero de legajo esta repetido
                            {
                                if(direc.Legajo == legajo) //Condicional que verifica que no se repita el legajo
                                { 
                                    MessageBox.Show("Numero de legajo repetido");
                                    return;
                                }
                            }
                            foreach (Administrativo admin in listaAdministrativos) //Bucle que busca si el numero de legajo esta repetido
                            {
                                if(admin.Legajo == legajo) //Condicional que verifica que no se repita el legajo
                                {
                                    MessageBox.Show("Numero de legajo repetido");
                                    return;
                                }
                            }
                            foreach (Operario oper in listaOperarios) //Bucle que busca si el numero de legajo esta repetido
                            {
                                if (oper.Legajo == legajo) //Condicional que verifica que no se repita el legajo
                                {
                                    MessageBox.Show("Numero de legajo repetido");
                                    return;
                                }
                            }
                            nombre = Interaction.InputBox("Nombre: "); //Linea que carga el nombre
                            apellido = Interaction.InputBox("Apellido: "); //Linea que carga el apellido
                            sueldo = Convert.ToDecimal(Interaction.InputBox("Sueldo: ")); //Linea que carga el sueldo
                            if (rbAdministrativo.Checked == true) //Condicional para cargar los administrativos
                            {
                                listaAdministrativos.Add(new Administrativo(legajo, nombre, apellido, sueldo)); //Se cargan en la lista
                                Enlazar(dgvEmpleado, listaAdministrativos); //Se refresca la grilla con los datos nuevos
                            }
                            else if (rbDirectivo.Checked == true) //Condicional para cargar los directivos
                            {
                                listaDirectivos.Add(new Directivo(legajo, nombre, apellido, sueldo)); //Se cargan en la lista
                                Enlazar(dgvEmpleado, listaDirectivos); //Se refresca la grilla con los datos nuevos
                            }
                            else if (rbOperario.Checked == true) //Condicional para cargar los operarios
                            {
                                listaOperarios.Add(new Operario(legajo, nombre, apellido, sueldo)); //Se cargan en la lista
                                Enlazar(dgvEmpleado, listaOperarios); //Se refresca la grilla con los datos nuevos
                            }
                        }
                        else
                        {
                            throw new Exception("El legajo solo deben ser 4 numeros");
                        }
                        
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Se ocupa de refrescar la grilla
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="lista"></param>
        public void Enlazar(DataGridView dataGridView, Object lista)
        {
            dataGridView.DataSource = null; //Limpia la grilla
            dataGridView.DataSource = lista; //Carga la lista con nuevos valores en la grilla
            dgvAdelantos.Columns["Empleado"].Visible = false; //Hace que en la segunda grilla no aparezca por defecto la columna empleado
        }

        
        /// <summary>
        /// Hace que cuando cambies el radioButton se cambie la lista a la de directivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDirectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDirectivo.Checked == true)
            {
                List<Directivo> auxDirect = new List<Directivo>();
                foreach (Directivo direct in listaDirectivos)
                {
                    auxDirect.Add(direct);
                }
                Enlazar(dgvEmpleado, auxDirect);
            }
        }
        /// <summary>
        ///  Hace que cuando cambies el radioButton se cambie la lista a la de administrativos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdministrativo.Checked == true)
            {
                List<Administrativo> auxAdmin = new List<Administrativo>();
                foreach (Administrativo admin in listaAdministrativos)
                {
                    auxAdmin.Add(admin);
                }
                Enlazar(dgvEmpleado, auxAdmin);
            }
        }
        /// <summary>
        ///  Hace que cuando cambies el radioButton se cambie la lista a la de operarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbOperario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOperario.Checked == true)
            {
                List<Operario> auxOpera = new List<Operario>();
                foreach (Operario operar in listaOperarios)
                {
                    auxOpera.Add(operar);
                }
                Enlazar(dgvEmpleado, auxOpera);
            }
        }
        /// <summary>
        ///  Hace que cuando cambies el radioButton se cambie la lista a que esten todos en la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                List<Empleado> todos = new List<Empleado>();
                foreach (Administrativo administrativo in listaAdministrativos)
                {
                    todos.Add(administrativo);
                }
                foreach (Directivo directivo in listaDirectivos)
                {
                    todos.Add(directivo);
                }
                foreach (Operario operario in listaOperarios)
                {
                    todos.Add(operario);
                }
                List<Empleado> auxtodos = todos.OrderBy(x => x.Legajo).ToList();
                Enlazar(dgvEmpleado, auxtodos); 
            }
        }
        /// <summary>
        /// Boton de agrear adelantos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo;
                List<Adelanto> auxAdel = new List<Adelanto>(); //Lista auxiliar
                codigo = Interaction.InputBox("Ingrese su codigo: "); //Linea por la cual se ingresa el codgio del adelanto
                Regex rgx = new Regex(@"^[0-9]{4}[a-zA-Z]{4}$"); //REgex para verificar los datos ingresados en el codigo
                if (rgx.IsMatch(codigo)) //Condicional que verifica lo ingresado
                {
                    foreach (Adelanto adelantar in listaAdelantos) //Bucle que busca codigos repetidos
                    { 
                        if(adelantar.Codigo == codigo) //Condicional que compara la lista con el nuevo valor ingresado
                        {
                            MessageBox.Show("Numero de codigo repetido");
                            return;
                        }
                    }
                   
                    DateTime otorgamiento = new DateTime(); //variable de timepo
                    DateTime cancelacion = new DateTime(); //variable de timepo
                    decimal impOtorgado = 0, impPagado = 0, beneficio = 0, sueldoAdeudado = 0; //variables decimal
                    otorgamiento = Convert.ToDateTime(Interaction.InputBox("Fecha de otorgamineto: ")); //linea donde se carga la fecha del otrogamiento
                    cancelacion = Convert.ToDateTime(Interaction.InputBox("Fecha de cancelacion: ")); //linea donde se carga la fecha de la cancelacion
                    if(otorgamiento > cancelacion) //Condicional que verifica que el otorgamiento sea antes que la cancelacion
                    {
                        MessageBox.Show("La fecha de cancelacion debe ser posterior a la de otorgamiento");
                        return;
                    }
                    impOtorgado = Convert.ToDecimal(Interaction.InputBox("Importe otorgado: ")); //linea que carga importe otorgado
                    sueldoAdeudado += impOtorgado;

                    listaAdelantos.Add(new Adelanto(codigo, otorgamiento, cancelacion, impOtorgado, impPagado, beneficio, sueldoAdeudado)); //ingresa los nuevos valores a la lista
                    foreach (Adelanto adelan in listaAdelantos) 
                    {
                        auxAdel.Add(adelan); //lista auxiliar
                    }
                    
                    Enlazar(dgvAdelantos, auxAdel); //Se refresca la grilla
                }
                else
                {
                    MessageBox.Show("Codigo invalido, vuelva a intentar");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton que asigna al empleado con la deuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                
                Empleado empleadoSel = dgvEmpleado.SelectedRows[0].DataBoundItem as Empleado; //toma la fila del empleado
                Adelanto adelantoSel = dgvAdelantos.SelectedRows[0].DataBoundItem as Adelanto; //toma la fila del adelanto
                int cont = 0;
                decimal maxAdelanto;
                decimal deudaTotal = 0;

                if (empleadoSel != null || adelantoSel != null) //condicional que asegura que no hallan valores en null
                {
                   if(listaDeudas.Count == 0) //Condicional que permite cargar asignar el primero de la lista de deudas
                    {
                        maxAdelanto = empleadoSel.Sueldo / 2; //calculo del maximo que puede pedir de adelanto
                        if (adelantoSel.ImpOtorgado >= maxAdelanto) //Condicional para verificar el adelanto pedido
                        {
                            MessageBox.Show("Solicito mas dinero del que puede pedir");
                            return;
                        }
                        listaDeudas.Add(new Adelanto(adelantoSel.Codigo, adelantoSel.Otorgamiento, adelantoSel.Cancelacion,
                                        adelantoSel.ImpOtorgado, adelantoSel.ImpPagado, adelantoSel.Beneficio, adelantoSel.SueldoAdeudado, empleadoSel.Legajo)); //se cargan los nuevos valores en la lista
                        
                    }
                    else
                    {
                        foreach (Adelanto adelanto in listaDeudas) //bucle que recorre la lista de duedas
                        {
                            if(adelanto.Codigo == adelantoSel.Codigo) //Condicional que verifica por el codigo que no se repita
                            {
                                throw new Exception("no pueden repetirse los numeros de codigo");
                            }
                            else
                            {
                                maxAdelanto = empleadoSel.Sueldo / 2; //calculo del maximo que puede pedir de adelanto
                                if (adelantoSel.ImpOtorgado >= maxAdelanto) //Condicional para verificar el adelanto pedido
                                {
                                    MessageBox.Show("Solicito mas dinero del que puede pedir");
                                    return;
                                }
                                listaDeudas.Add(new Adelanto(adelantoSel.Codigo, adelantoSel.Otorgamiento, adelantoSel.Cancelacion,
                                                 adelantoSel.ImpOtorgado, adelantoSel.ImpPagado, adelantoSel.Beneficio, adelantoSel.SueldoAdeudado,
                                                 empleadoSel.Legajo)); //se cargan los nuevos valores en la lista


                                foreach (Adelanto adel in listaDeudas) //Bucle que recorre la lista de deudas para que no se puedan pedir mas de 3 adelantos
                                {
                                    
                                    if (empleadoSel.Legajo == adel.Empleado) //Condicional que busca cuantas veces se repite el mismo empleado
                                    {
                                        cont++;
                                        
                                        if (cont == 3)
                                        {
                                            MessageBox.Show("Ya saco todos los adelantos permitidos");
                                        }                                        
                                    }
                                    deudaTotal += adelanto.SueldoAdeudado; //calculo entre el sueldo y el adelanto
                                    if (deudaTotal >= empleadoSel.Sueldo)
                                    {
                                        MessageBox.Show("Ha superado el monto total que puede pedir de adelantos");
                                        listaDeudas.RemoveAt(2); //borra al utlimo puesto que es el que hace que supere el monto
                                        return;
                                    }
                                }
                                
                            }
                        }
                    }                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        /// <summary>
        /// Metodo que permite que con un click se vea las deudas del empleado el la tercer grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Empleado empleadoSel = dgvEmpleado.SelectedRows[0].DataBoundItem as Empleado; //empleado seleccionado

                decimal totalDeuda = 0;
                List<Adelanto> auxDeudas = new List<Adelanto>(); //Lista auxiliar

                foreach (Adelanto adelanto in listaDeudas) //bucle que recorre la lista de deudas
                {
                    if(empleadoSel.Legajo == adelanto.Empleado) //condicional que asegura el legajo del empleado
                    {
                        totalDeuda += adelanto.SueldoAdeudado; //calculo del total de la deuda
                        lblDeudaTotal.Text = totalDeuda.ToString(); //imprime la deuda en un label
                        auxDeudas.Add(adelanto); //agrega los nuevos valores a la lista
                    }                    
                }
                
                Enlazar(dgvBeneficiarios, auxDeudas); //Refresca la grilla
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton que se ocupa del pago de la deuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagoDeuda_Click(object sender, EventArgs e)
        {
            Empleado empleadoSel = dgvEmpleado.SelectedRows[0].DataBoundItem as Empleado; //trae al empleado seleccionado
            decimal porcentaje = 0;
            foreach (Directivo directivo in listaDirectivos) //recorre la lista de los directivos
            {
                if(empleadoSel.Legajo == directivo.Legajo) //busca al directivo por el legajo 
                {
                    porcentaje = 1; //asigna el valor al porcentaje
                }
            }
            foreach (Administrativo administrativo in listaAdministrativos) //recorre la lista de los administrativos
            {
                if(empleadoSel.Legajo == administrativo.Legajo) //busca al administrativo por el legajo
                { 
                    porcentaje = 5; //asigna el valor del porcentaje
                }
            }
            foreach (Operario operario in listaOperarios) //recorre la lista de los operacios
            {
                if(empleadoSel.Legajo == operario.Legajo) //busca por el legajo al adminitratovo
                {
                    porcentaje = 10; //asigna el valor del porcentaje
                }
            }

            List<Adelanto> auxAdelant = new List<Adelanto>(); //lista auxiliar
           
            decimal deudaTotal = 0;
            decimal pagarDeuda = 0;
            decimal deudaPor = 0;
            foreach (Adelanto adelanto in listaDeudas)
            {
                if(adelanto.Empleado == empleadoSel.Legajo)
                {
                    deudaTotal += adelanto.ImpOtorgado; // calcula la dueda total a pagar
                }
                deudaPor = (deudaTotal * porcentaje) / 100; //calcula el porcentaje
                deudaTotal -= deudaPor;
            }
            pagarDeuda = Convert.ToDecimal(Interaction.InputBox("Ingrese el monto a pagar\n Su deuda total con el beneficio es de " + deudaTotal)); // linea que ingresa el monto a pagar
            if(pagarDeuda == deudaTotal)
            {
                MessageBox.Show("Ha pagado todos sus adelantos");
                foreach (Adelanto adelant in listaDeudas) 
                {
                    porcentaje = deudaPor;
                    auxAdelant.Add(new Adelanto(adelant.Codigo, adelant.Otorgamiento, adelant.Cancelacion, adelant.ImpOtorgado,
                    pagarDeuda , porcentaje, 0, adelant.Empleado));  //actualiza los valores de deudas en la lista
                    
                }                
            }
            deudaTotal -= pagarDeuda;
            lblDeudaTotal.Text = deudaTotal.ToString(); //actualiza el label
            Enlazar(dgvBeneficiarios, auxAdelant); //Refresca la grilla con los nuevos valores                   
            listaAdelantos.AddRange(auxAdelant);
            
            Enlazar(dgvAdelantos, listaAdelantos);
            
        }
        /// <summary>
        /// Boton que borra al los empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleadoSel = dgvEmpleado.SelectedRows[0].DataBoundItem as Empleado;
                List<Directivo> auxDirect = new List<Directivo>();
                List<Administrativo> auxAdmin = new List<Administrativo>();
                List<Operario> auxOper = new List<Operario>();

                foreach (Directivo direc in listaDirectivos)
                {
                    auxDirect.Add(direc);
                }

                foreach (Directivo direc in auxDirect)
                {
                    if (empleadoSel.Legajo == direc.Legajo)
                    {
                        listaDirectivos.Remove(direc);
                    }
                }
                Enlazar(dgvEmpleado, listaDirectivos);

                foreach (Administrativo admin in listaAdministrativos)
                {
                    auxAdmin.Add(admin);
                }

                foreach (Administrativo admin in auxAdmin)
                {
                    if (empleadoSel.Legajo == admin.Legajo)
                    {
                        listaAdministrativos.Remove(admin);
                    }
                }
                Enlazar(dgvEmpleado, listaAdministrativos);

                foreach (Operario oper in listaOperarios)
                {
                    auxOper.Add(oper);
                }

                foreach (Operario oper in auxOper)
                {
                    if (empleadoSel.Legajo == oper.Legajo)
                    {
                        listaOperarios.Remove(oper);
                    }
                }
                Enlazar(dgvEmpleado, listaOperarios);
            }
            catch (Exception)
            {

                MessageBox.Show("Debe elegir un item para borrar");
            }
            
        }
        /// <summary>
        /// boton que borra los adelnatos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                Adelanto adelantoSel = dgvAdelantos.SelectedRows[0].DataBoundItem as Adelanto;
                List<Adelanto> auxAdel = new List<Adelanto>();

                foreach (Adelanto adel in listaAdelantos)
                {
                    auxAdel.Add(adel);
                }

                foreach (Adelanto adel in auxAdel)
                {
                    if(adelantoSel.Codigo == adel.Codigo)
                    {
                        listaAdelantos.Remove(adel);
                    }
                }
                Enlazar(dgvAdelantos, listaAdelantos);
            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar algo que borrar");
            }
        }
        /// <summary>
        /// boton que modifica a los empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleadoSel = dgvEmpleado.SelectedRows[0].DataBoundItem as Empleado;
                List<Directivo> auxDirect = new List<Directivo>();
                List<Administrativo> auxAdmin = new List<Administrativo>();
                List<Operario> auxOper = new List<Operario>();

                foreach (Directivo direc in listaDirectivos)
                {
                    auxDirect.Add(direc);
                }

                foreach (Administrativo admin in listaAdministrativos)
                {
                    auxAdmin.Add(admin);
                }

                foreach (Operario oper in listaOperarios)
                {
                    auxOper.Add(oper);
                }

                int legajo;
                string nombre, apellido;
                decimal sueldo;

                foreach (Directivo direc in auxDirect)
                {
                    if(empleadoSel.Legajo == direc.Legajo)
                    {
                        legajo = Convert.ToInt32(Interaction.InputBox("Legajo: " + direc.Legajo));
                        Regex rgx = new Regex(@"^[0-9]{4}$");
                        if (rgx.IsMatch(legajo.ToString()))
                        {
                           
                            foreach (Directivo direct in listaDirectivos)
                            {
                                if (direct.Legajo == legajo)
                                {
                                    MessageBox.Show("Numero de legajo repetido");
                                    return;
                                }
                            }
                                                        }
                            nombre = Interaction.InputBox("Nombre: " + direc.Nombre);
                            apellido = Interaction.InputBox("Apellido: " + direc.Apellido);
                            sueldo = Convert.ToDecimal(Interaction.InputBox("Sueldo: " + direc.Sueldo));
                        listaDirectivos.Remove(direc);
                        listaDirectivos.Add(new Directivo(legajo, nombre, apellido, sueldo));
                        Enlazar(dgvEmpleado, listaDirectivos);
                    }
                }

                foreach (Administrativo admin in auxAdmin)
                {
                    if (empleadoSel.Legajo == admin.Legajo)
                    {
                        legajo = Convert.ToInt32(Interaction.InputBox("Legajo: " + admin.Legajo));
                        Regex rgx = new Regex(@"^[0-9]{4}$");
                        if (rgx.IsMatch(legajo.ToString()))
                        {

                            foreach (Directivo direct in listaDirectivos)
                            {
                                if (direct.Legajo == legajo)
                                {
                                    MessageBox.Show("Numero de legajo repetido");
                                    return;
                                }
                            }
                        }
                        nombre = Interaction.InputBox("Nombre: " + admin.Nombre);
                        apellido = Interaction.InputBox("Apellido: " + admin.Apellido);
                        sueldo = Convert.ToDecimal(Interaction.InputBox("Sueldo: " + admin.Sueldo));
                        listaAdministrativos.Remove(admin);
                        listaAdministrativos.Add(new Administrativo(legajo, nombre, apellido, sueldo));
                        Enlazar(dgvEmpleado, listaAdministrativos);
                    }
                }

                foreach (Operario oper in auxOper)
                {
                    if (empleadoSel.Legajo == oper.Legajo)
                    {
                        legajo = Convert.ToInt32(Interaction.InputBox("Legajo: " + oper.Legajo));
                        Regex rgx = new Regex(@"^[0-9]{4}$");
                        if (rgx.IsMatch(legajo.ToString()))
                        {

                            foreach (Directivo direct in listaDirectivos)
                            {
                                if (direct.Legajo == legajo)
                                {
                                    MessageBox.Show("Numero de legajo repetido");
                                    return;
                                }
                            }
                        }
                        nombre = Interaction.InputBox("Nombre: " + oper.Nombre);
                        apellido = Interaction.InputBox("Apellido: " + oper.Apellido);
                        sueldo = Convert.ToDecimal(Interaction.InputBox("Sueldo: " + oper.Sueldo));
                        listaOperarios.Remove(oper);
                        listaOperarios.Add(new Operario(legajo, nombre, apellido, sueldo));
                        Enlazar(dgvEmpleado, listaOperarios);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar un elemento para modificar");
            }
        }
        /// <summary>
        /// boton que modifica los adelantos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarAdelanto_Click(object sender, EventArgs e)
        {
            Adelanto adelantoSel = dgvAdelantos.SelectedRows[0].DataBoundItem as Adelanto;
            List<Adelanto> auxAdel = new List<Adelanto>();

            foreach (Adelanto adel in listaAdelantos)
            {
                auxAdel.Add(adel);
            }

            foreach (Adelanto adel in auxAdel)
            {
                if (adelantoSel.Codigo == adel.Codigo)
                {
                    string codigo;
                    codigo = Interaction.InputBox("Ingrese su codigo: " + adel.Codigo);
                    Regex rgx = new Regex(@"^[0-9]{4}[a-zA-Z]{4}$");
                    if (rgx.IsMatch(codigo))
                    {
                        foreach (Adelanto adelantar in listaAdelantos)
                        {
                            if (adelantar.Codigo == codigo)
                            {
                                MessageBox.Show("Numero de codigo repetido");
                                return;
                            }
                        }

                        DateTime otorgamiento = new DateTime();
                        DateTime cancelacion = new DateTime();
                        decimal impOtorgado = 0, impPagado = 0, beneficio = 0, sueldoAdeudado = 0;
                        otorgamiento = Convert.ToDateTime(Interaction.InputBox("Fecha de otorgamineto: " + adel.Otorgamiento));
                        cancelacion = Convert.ToDateTime(Interaction.InputBox("Fecha de cancelacion: " + adel.Cancelacion));
                        if (otorgamiento > cancelacion)
                        {
                            MessageBox.Show("La fecha de cancelacion debe ser posterior a la de otorgamiento");
                            return;
                        }
                        impOtorgado = Convert.ToDecimal(Interaction.InputBox("Importe otorgado: " + adel.ImpOtorgado));
                        sueldoAdeudado += impOtorgado;

                        listaAdelantos.Remove(adel);
                        listaAdelantos.Add(new Adelanto(codigo, otorgamiento, cancelacion, impOtorgado, impPagado, beneficio, sueldoAdeudado));
                        
                        Enlazar(dgvAdelantos, listaAdelantos);
                    }
                }
            }

        }   
    }
}
