using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstract;
using BE;
using BLL;

namespace UI
{
    public partial class PresupuestarAuto : Form
    {
        public PresupuestarAuto()
        {
            InitializeComponent();
            auto = new Automovil();
            moto = new Moto();
            presupuesto = new Presupuesto();
            desperfecto = new Desperfecto();
            repuesto = new Repuesto();
            desperfectoRepuesto = new DesperfectoRepuesto();

            bllauto = new BLLAutomovil();
            bllmoto = new BLLMoto();
            bllvehiculo = new BLLVehiculo();
            bllpresupuesto = new BLLPresupuesto();
            blldesperfecto = new BLLDesperfecto();
            bllrepuesto = new BLLRepuesto();
            blldr = new BLLDesperfectoRepuesto();

            rdgv = new RefreshDgv();
        }

        Automovil auto;
        Moto moto;
        Presupuesto presupuesto;
        Desperfecto desperfecto;
        Repuesto repuesto;
        DesperfectoRepuesto desperfectoRepuesto;

        BLLAutomovil bllauto;
        BLLMoto bllmoto;
        BLLVehiculo bllvehiculo;
        BLLPresupuesto bllpresupuesto;
        BLLDesperfecto blldesperfecto;
        BLLRepuesto bllrepuesto;
        BLLDesperfectoRepuesto blldr;

        RefreshDgv rdgv;

        public bool User { get; set; }
        public Usuario usuario { get; set; }

        public List<Repuesto> repuestoList = new List<Repuesto>();
        public List<Desperfecto> desperList = new List<Desperfecto>();
        public List<Presupuesto> presuList = new List<Presupuesto>();


        private void PresupuestarAuto_Load(object sender, EventArgs e)
        {
            foreach (Automovil.Tipo a in Enum.GetValues(typeof(Automovil.Tipo)))
            {
                cbTipo.Items.Add(a.ToString());
            }

            foreach (Repuesto r in bllrepuesto.ListarTodo())
            {
                cbListaRepuestos.Items.Add(r.NombreRepuesto);
            }

            dgvDatosVehiculos.MultiSelect = false;
            dgvDatosVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuestoCliente.MultiSelect = false;
            dgvPresupuestoCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesperfecto.MultiSelect = false;
            dgvDesperfecto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepuestos.MultiSelect = false;
            dgvRepuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosMotos.MultiSelect = false;
            dgvDatosMotos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            rdgv.Refresh(dgvPresupuestoCliente, bllpresupuesto.ListarTodo());
            rdgv.Refresh(dgvDatosVehiculos, ListaAutos());
            rdgv.Refresh(dgvDesperfecto, blldesperfecto.ListarTodo());
            rdgv.Refresh(dgvDatosMotos, ListaMotos());

            Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
            dgvRepuestos.Enabled = true;
            
          
            
            if(User == true)
            {
                rbMotos.Checked = true;
                dgvRepuestos.Enabled = true;
                foreach (DesperfectoRepuesto res in blldr.ListarTodo())
                {
                    if (res.IdDesperfecto == desperfectoAux.Id)
                    {
                        foreach (Repuesto repuestin in bllrepuesto.ListarTodo())
                        {
                            if (res.IdRepuesto == repuestin.Id)
                            {
                                repuestoList.Add(repuestin);
                            }
                        }
                    }
                }
                rdgv.Refresh(dgvRepuestos, repuestoList);
            }
            else if(User == false)
            {
                rbAutos.Checked = true;
                dgvRepuestos.Enabled = true;
                foreach (DesperfectoRepuesto res in blldr.ListarTodo())
                {
                    if (res.IdDesperfecto == desperfectoAux.Id)
                    {
                        foreach (Repuesto repuestin in bllrepuesto.ListarTodo())
                        {
                            if (res.IdRepuesto == repuestin.Id)
                            {
                                repuestoList.Add(repuestin);
                            }
                        }
                    }
                }
                rdgv.Refresh(dgvRepuestos, repuestoList);
            }
            ArmarDgv();
            rbAutos.Visible = false;
            rbMotos.Visible = false;
        }

        #region ABM Vehiculo
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAutos.Checked == true)
                {
                    if (txtMarca.Text != string.Empty && txtModelo.Text != string.Empty && txtPatente.Text != string.Empty
                        && cbTipo.Text != string.Empty && cbPuertas.Text != string.Empty)
                    {
                        Automovil autoAux = new Automovil(txtMarca.Text, txtModelo.Text, txtPatente.Text);

                        bllvehiculo.Guardar(autoAux);

                        int idVehiculoAux = 0;
                        string elegido = cbTipo.SelectedItem.ToString();
                        foreach (Vehiculo vehi in bllvehiculo.ListarTodoAuto())
                        {
                            if (vehi.Patente == txtPatente.Text)
                            {
                                idVehiculoAux = vehi.Id;
                            }
                        }
                        auto = new Automovil(idVehiculoAux, (Automovil.Tipo)Enum.Parse(typeof(Automovil.Tipo), elegido),
                                             int.Parse(cbPuertas.SelectedItem.ToString()));

                        bllauto.Guardar(auto);
                        VaciarDatos();
                        rdgv.Refresh(dgvDatosVehiculos, ListaAutos());
                        ArmarDgv();
                        MessageBox.Show("Se cargaron correctamente\n los datos del vehiculo con patente\n " + autoAux.Patente);
                    }
                    else
                    {
                        MessageBox.Show("Deben estar completos todos los campos");
                    }
                }
                else if (rbMotos.Checked == true)
                {
                    int idVehiculoAux = 0;
                    if (txtMarca.Text != string.Empty && txtModelo.Text != string.Empty && txtPatente.Text != string.Empty
                        && txtCilindrada.Text != string.Empty)
                    {
                        Moto motoAux = new Moto(txtMarca.Text, txtModelo.Text, txtPatente.Text);

                        bllvehiculo.Guardar(motoAux);

                        foreach (Vehiculo vehi in bllvehiculo.ListarTodoMoto())
                        {
                            if (vehi.Patente == txtPatente.Text)
                            {
                                idVehiculoAux = vehi.Id;
                            }
                        }
                        moto = new Moto(int.Parse(idVehiculoAux.ToString()), txtCilindrada.Text);

                        bllmoto.Guardar(moto);
                        VaciarDatos();
                        dgvDatosVehiculos.DataSource = null;
                        rdgv.Refresh(dgvDatosMotos, ListaMotos());
                        ArmarDgv();
                        MessageBox.Show("Se cargaron correctamente\n los datos del vehiculo con patente\n " + motoAux.Patente);
                    }
                    else
                    {
                        MessageBox.Show("Deben estar completos todos los campos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAutos.Checked == true)
                {
                    Automovil autitoAux = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                    if (txtMarca.Text != string.Empty && txtModelo.Text != string.Empty && txtPatente.Text != string.Empty
                        && cbTipo.Text != string.Empty && cbPuertas.Text != string.Empty)
                    {
                        Automovil autoAux = new Automovil(autitoAux.IdVehiculo, txtMarca.Text, txtModelo.Text, txtPatente.Text);

                        bllvehiculo.Modificar(autoAux);

                        int idVehiculoAux = 0;
                        string elegido = cbTipo.SelectedItem.ToString();
                        foreach (Vehiculo vehi in bllvehiculo.ListarTodoAuto())
                        {
                            if (vehi.Patente == txtPatente.Text)
                            {
                                idVehiculoAux = vehi.Id;
                            }
                        }
                        auto = new Automovil(autitoAux.Id, idVehiculoAux, (Automovil.Tipo)Enum.Parse(typeof(Automovil.Tipo), elegido),
                                             int.Parse(cbPuertas.SelectedItem.ToString()));

                        bllauto.Modificar(auto);
                        VaciarDatos();
                        rdgv.Refresh(dgvDatosVehiculos, ListaAutos());
                        ArmarDgv();
                        MessageBox.Show("Se modificaron correctamente\n los datos del vehiculo con patente\n " + autoAux.Patente);
                    }
                    else
                    {
                        MessageBox.Show("Deben estar completos todos los campos");
                    }
                }
                else if (rbMotos.Checked == true)
                {
                    Moto motitoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                    int idVehiculoAux = 0;
                    if (txtMarca.Text != string.Empty && txtModelo.Text != string.Empty && txtPatente.Text != string.Empty
                        && txtCilindrada.Text != string.Empty)
                    {
                        Moto motoAux = new Moto(motitoAux.IdVehiculo, txtMarca.Text, txtModelo.Text, txtPatente.Text);

                        bllvehiculo.Modificar(motoAux);

                        foreach (Vehiculo vehi in bllvehiculo.ListarTodoMoto())
                        {
                            if (vehi.Patente == txtPatente.Text)
                            {
                                idVehiculoAux = vehi.Id;
                            }
                        }
                        moto = new Moto(motitoAux.Id, int.Parse(idVehiculoAux.ToString()), txtCilindrada.Text);

                        bllmoto.Modificar(moto);
                        VaciarDatos();
                        dgvDatosVehiculos.DataSource = null;
                        rdgv.Refresh(dgvDatosMotos, ListaMotos());
                        ArmarDgv();
                        MessageBox.Show("Se modificaron correctamente\n los datos del vehiculo con patente\n " + motoAux.Patente);
                    }
                    else
                    {
                        MessageBox.Show("Deben estar completos todos los campos");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if(rbAutos.Checked == true)
                {
                    Automovil autoAuxId = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                    Automovil autoAux = new Automovil(autoAuxId.IdVehiculo, txtMarca.Text, txtModelo.Text, txtPatente.Text);
                    bllvehiculo.Borrar(autoAux);
                    bllauto.Borrar(autoAuxId);
                    ListaAutos().Remove(autoAuxId);
                    rdgv.Refresh(dgvDatosVehiculos, ListaAutos());
                    ArmarDgv();
                    VaciarDatos();
                    MessageBox.Show("Se borro correctamente");
                }
                else if(rbMotos.Checked == true)
                {
                    Moto motoAuxId = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                    Moto autoMoto = new Moto(motoAuxId.IdVehiculo, txtMarca.Text, txtModelo.Text, txtPatente.Text);
                    bllvehiculo.Borrar(autoMoto);
                    bllmoto.Borrar(motoAuxId);
                    ListaMotos().Remove(motoAuxId);
                    rdgv.Refresh(dgvDatosMotos, ListaMotos());
                    ArmarDgv();
                    VaciarDatos();
                    MessageBox.Show("Se borro correctamente");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ABM Presupuesto
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAutos.Checked == true)
                {
                    Automovil autoAux = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                    if (txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtEmail.Text != string.Empty)
                    {
                        presupuesto = new Presupuesto(txtNombre.Text, txtApellido.Text, txtEmail.Text, 0, autoAux.IdVehiculo);

                        bllpresupuesto.Guardar(presupuesto);

                        foreach (Presupuesto pres in bllpresupuesto.ListarTodo())
                        {
                            if (autoAux.IdVehiculo == pres.IdVehiculo)
                            {
                                presuList.Add(pres);
                            }
                        }


                        rdgv.Refresh(dgvPresupuestoCliente, presuList);
                        ArmarDgv();
                        VaciarDatos();
                        MessageBox.Show("Se cargaron los datos del cliente correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Se deben de completar los 3 campos del cliente");
                    }
                }
                else if (rbMotos.Checked == true)
                {
                    Moto motoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                    if (txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtEmail.Text != string.Empty)
                    {
                        presupuesto = new Presupuesto(txtNombre.Text, txtApellido.Text, txtEmail.Text, 0, motoAux.IdVehiculo);

                        bllpresupuesto.Guardar(presupuesto);
                        foreach (Presupuesto pres in bllpresupuesto.ListarTodo())
                        {
                            if (motoAux.IdVehiculo == pres.IdVehiculo)
                            {
                                presuList.Add(pres);
                            }
                        }


                        rdgv.Refresh(dgvPresupuestoCliente, presuList);
                        ArmarDgv();
                        VaciarDatos();
                        MessageBox.Show("Se cargaron los datos del cliente correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Se deben de completar los 3 campos del cliente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
            try
            {
                if (rbAutos.Checked == true)
                {
                    Automovil autoAux = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                    if (txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtEmail.Text != string.Empty)
                    {
                        presupuesto = new Presupuesto(presupuestoAux.Id, txtNombre.Text, txtApellido.Text, txtEmail.Text, 0, autoAux.IdVehiculo);

                        bllpresupuesto.Modificar(presupuesto);


                        foreach (Presupuesto pres in bllpresupuesto.ListarTodo())
                        {
                            if (autoAux.IdVehiculo == pres.IdVehiculo)
                            {
                                var ind = presuList.IndexOf(presupuestoAux);
                                presuList.RemoveAt(ind);
                                presuList.Insert(ind, presupuesto);
                            }
                        }

                        rdgv.Refresh(dgvPresupuestoCliente, presuList);
                        ArmarDgv();
                        VaciarDatos();
                        MessageBox.Show("Se modificaron los datos del cliente correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Se deben de completar los 3 campos del cliente");
                    }
                }
                else if (rbMotos.Checked == true)
                {
                    Moto motoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                    if (txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtEmail.Text != string.Empty)
                    {
                        presupuesto = new Presupuesto(presupuestoAux.Id, txtNombre.Text, txtApellido.Text, txtEmail.Text, 0, motoAux.IdVehiculo);
                        bllpresupuesto.Modificar(presupuesto);

                        foreach (Presupuesto pres in bllpresupuesto.ListarTodo())
                        {
                            if (motoAux.IdVehiculo == pres.IdVehiculo)
                            {
                                var ind = presuList.IndexOf(presupuestoAux);
                                presuList.RemoveAt(ind);
                                presuList.Insert(ind, presupuesto);
                            }
                        }

                        rdgv.Refresh(dgvPresupuestoCliente, presuList);

                        ArmarDgv();
                        VaciarDatos();
                        MessageBox.Show("Se modificaron los datos del cliente correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Se deben de completar los 3 campos del cliente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
                bllpresupuesto.Borrar(presupuestoAux);
                presuList.Remove(presupuestoAux);
                rdgv.Refresh(dgvPresupuestoCliente, presuList);
                ArmarDgv();
                VaciarDatos();
                MessageBox.Show("Se borraron los datos del cliente correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ABM Desperfecto
        private void btnCargarDesperfecto_Click(object sender, EventArgs e)
        {
            Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
            List<Desperfecto> auxDesper = new List<Desperfecto>();

            try
            {
                if (txtDescripcion.Text != string.Empty && txtManoDeObra.Text != string.Empty && txtTiempo.Text != string.Empty)
                {
                    if (presupuestoAux != null)
                    {
                        desperfecto = new Desperfecto(presupuestoAux.Id, txtDescripcion.Text, decimal.Parse(txtManoDeObra.Text),
                                          int.Parse(txtTiempo.Text));


                        blldesperfecto.Guardar(desperfecto);
                        if (dgvRepuestos.Rows.Count != 0)
                        {
                            foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                            {
                                if (desper.IdPresupuesto == presupuestoAux.Id && desper.Descripcion == txtDescripcion.Text &&
                                   desper.ManoDeObra == decimal.Parse(txtManoDeObra.Text) && desper.Tiempo == int.Parse(txtTiempo.Text))
                                {
                                    desperList.Add(desper);
                                    foreach (Repuesto repues in bllrepuesto.ListarTodo())
                                    {
                                        foreach (Repuesto res in repuestoList)
                                        {
                                            if (repues.NombreRepuesto == res.NombreRepuesto)
                                            {
                                                desperfectoRepuesto = new DesperfectoRepuesto(desper.Id, res.Id);
                                                blldr.Guardar(desperfectoRepuesto);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (rbAutos.Checked == true)
                        {


                            foreach (Presupuesto pres in presuList)
                            {
                                foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                                {
                                    if (pres.Id == desper.IdPresupuesto)
                                    {
                                        auxDesper.Add(desper);
                                    }
                                }
                            }
                        }
                        else if (rbMotos.Checked == true)
                        {


                            foreach (Presupuesto pres in presuList)
                            {
                                foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                                {
                                    if (pres.Id == desper.IdPresupuesto)
                                    {
                                        auxDesper.Add(desper);
                                    }
                                }
                            }

                        }

                        rdgv.Refresh(dgvDesperfecto, auxDesper);
                        ArmarDgv();
                        MessageBox.Show("Se ha cargado correctamente");
                        VaciarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Debe tener seleccionado un cliente para asignarle al desperfecto");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarDesperfecto_Click(object sender, EventArgs e)
        {
            Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
            Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
            List<Desperfecto> auxDesper = new List<Desperfecto>();
            try
            {
                if (txtDescripcion.Text != string.Empty && txtManoDeObra.Text != string.Empty && txtTiempo.Text != string.Empty)
                {
                    if (presupuestoAux != null)
                    {
                        desperfecto = new Desperfecto(desperfectoAux.Id, presupuestoAux.Id, txtDescripcion.Text, decimal.Parse(txtManoDeObra.Text),
                                          int.Parse(txtTiempo.Text));


                        blldesperfecto.Modificar(desperfecto);
                        if (dgvRepuestos.Rows.Count != 0)
                        {
                            foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                            {
                                if (desper.IdPresupuesto == presupuestoAux.Id && desper.Descripcion == txtDescripcion.Text &&
                                   desper.ManoDeObra == decimal.Parse(txtManoDeObra.Text) && desper.Tiempo == int.Parse(txtTiempo.Text))
                                {
                                    desperList.Add(desper);

                                    foreach (DesperfectoRepuesto desre in blldr.ListarTodo())
                                    {
                                        if (desperfectoAux.Id == desre.IdDesperfecto)
                                        {
                                            blldr.Borrar(desre);
                                        }
                                    }
                                    foreach (Repuesto res in repuestoList)
                                    {
                                        desperfectoRepuesto = new DesperfectoRepuesto(desperfectoAux.Id, res.Id);
                                        blldr.Guardar(desperfectoRepuesto);
                                    }
                                }
                            }
                        }

                        if (rbAutos.Checked == true)
                        {
                            foreach (Presupuesto pres in presuList)
                            {
                                foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                                {
                                    if (pres.Id == desper.IdPresupuesto)
                                    {
                                        auxDesper.Add(desper);
                                    }
                                }
                            }
                        }
                        else if (rbMotos.Checked == true)
                        {


                            foreach (Presupuesto pres in presuList)
                            {
                                foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                                {
                                    if (pres.Id == desper.IdPresupuesto)
                                    {
                                        auxDesper.Add(desper);
                                    }
                                }
                            }
                        }

                        rdgv.Refresh(dgvDesperfecto, auxDesper);
                        ArmarDgv();
                        MessageBox.Show("Se ha modificado correctamente");
                        VaciarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Debe tener seleccionado un cliente para asignarle al desperfecto");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarDesperfecto_Click(object sender, EventArgs e)
        {
            Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
            try
            {
                blldesperfecto.Borrar(desperfectoAux);
                foreach (DesperfectoRepuesto desres in blldr.ListarTodo())
                {
                    if (desperfectoAux.Id == desres.IdDesperfecto)
                    {
                        blldr.Borrar(desres);
                    }
                }
                desperList.Remove(desperfectoAux);
                rdgv.Refresh(dgvDesperfecto, desperList);
                ArmarDgv();
                MessageBox.Show("Se ha borrado correctamente");
                VaciarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Auxiliares
        public void VaciarDatos()
        {
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtPatente.Text = string.Empty;
            cbTipo.Text = string.Empty;
            cbPuertas.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtManoDeObra.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            cbListaRepuestos.Text = string.Empty;
            txtCilindrada.Text = string.Empty;
            dgvRepuestos.DataSource = null;
        }

        public List<Automovil> ListaAutos()
        {
            List<Automovil> autoAux = new List<Automovil>();

            foreach (Automovil a in bllauto.ListarTodo())
            {
                foreach (Vehiculo b in bllvehiculo.ListarTodoAuto())
                    if (a.IdVehiculo == b.Id)
                    {
                        auto = new Automovil(a.Id, a.IdVehiculo, a.TipoM, a.CantidadPuertas, b.Marca, b.Modelo, b.Patente);
                        autoAux.Add(auto);
                    }
            }
            return autoAux;
        }

        public List<Moto> ListaMotos()
        {
            List<Moto> motoAux = new List<Moto>();

            foreach (Moto m in bllmoto.ListarTodo())
            {
                foreach (Vehiculo b in bllvehiculo.ListarTodoMoto())
                {
                    if (m.IdVehiculo == b.Id)
                    {
                        moto = new Moto(m.Id, m.IdVehiculo, b.Marca, b.Modelo, b.Patente, m.Cilindrada);
                        motoAux.Add(moto);
                    }
                }
            }
            return motoAux;
        }

        public void ArmarDgv()
        {
            if (dgvDatosVehiculos.Rows.Count != 0)
            {
                dgvDatosVehiculos.Columns["Id"].Visible = false;
                dgvDatosVehiculos.Columns["IdVehiculo"].Visible = false;
            }

            if (dgvDatosMotos.Rows.Count != 0)
            {
                dgvDatosMotos.Columns["Id"].Visible = false;
                dgvDatosMotos.Columns["IdVehiculo"].Visible = false;
            }

            if (dgvPresupuestoCliente.Rows.Count != 0)
            {
                dgvPresupuestoCliente.Columns["Id"].Visible = false;
                dgvPresupuestoCliente.Columns["IdVehiculo"].Visible = false;
                dgvPresupuestoCliente.Columns["Total"].Visible = false;
            }

            if (dgvDesperfecto.Rows.Count != 0)
            {
                dgvDesperfecto.Columns["Id"].Visible = false;
                dgvDesperfecto.Columns["IdPresupuesto"].Visible = false;
            }

            if (dgvRepuestos.Rows.Count != 0)
            {
                dgvRepuestos.Columns["Id"].Visible = false;
            }
        }

        private void cbListaRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dgvRepuestos.Rows.Count != 0)
            {
                dgvRepuestos.DataSource = null;
                if (cbListaRepuestos.SelectedItem != null)
                {
                    foreach (Repuesto res in bllrepuesto.ListarTodo())
                    {
                        if (cbListaRepuestos.SelectedItem.ToString() == res.NombreRepuesto)
                        {
                            repuestoList.Add(res);
                        }
                    }
                }
            }
            else
            {
                if (cbListaRepuestos.SelectedItem != null)
                {
                    foreach (Repuesto res in bllrepuesto.ListarTodo())
                    {
                        if (cbListaRepuestos.SelectedItem.ToString() == res.NombreRepuesto)
                        {
                            repuestoList.Add(res);
                        }
                    }
                }
            }
            rdgv.Refresh(dgvRepuestos, repuestoList);
            ArmarDgv();
        }      

        private void btnGenerarPresupuesto_Click(object sender, EventArgs e)
        {

            Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
            Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
            
           



            List<Repuesto> resList = new List<Repuesto>();


            decimal totalRepuestos = 0;
            foreach (DesperfectoRepuesto desres in blldr.ListarTodo())
            {
                if (desperfectoAux.Id == desres.IdDesperfecto)
                {
                    foreach (Repuesto repuesto in bllrepuesto.ListarTodo())
                    {
                        if (desres.IdRepuesto == repuesto.Id)
                        {
                            totalRepuestos += repuesto.PrecioRepuesto;
                            resList.Add(repuesto);
                        }
                    }
                }
            }

            decimal totalparcial = ((totalRepuestos + (desperfectoAux.Tiempo * 130.00m) + desperfectoAux.ManoDeObra) * 10.00m) / 100.00m;
            decimal totalPresupuesto = totalRepuestos + (desperfectoAux.Tiempo * 130.00m) + desperfectoAux.ManoDeObra + totalparcial;
            
            presupuesto = new Presupuesto(presupuestoAux.Id, presupuestoAux.Nombre, presupuestoAux.Apellido,
            presupuestoAux.Email, totalPresupuesto, presupuestoAux.IdVehiculo);

            bllpresupuesto.Modificar(presupuesto);

            DetallePresupuesto dp = new DetallePresupuesto();
            dp.usuario = usuario;
            dp.TotalRepuestos = totalRepuestos;
            dp.presupes = presupuesto;
            dp.desperfec = desperfectoAux;

            if (rbAutos.Checked == true)
            {
                Automovil autoAuxId = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                dp.Auto = autoAuxId;
                dp.Cambio = true;
            }
            else if (rbMotos.Checked == true)
            {
                Moto motoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                dp.Moto = motoAux;
                dp.Cambio = false;
            }
            dp.Show();
        }

        private void rbAutos_CheckedChanged(object sender, EventArgs e)
        {
            VaciarDatos();
            presuList.Clear();
            desperList.Clear();
            lblCantidadPuertas.Visible = true;
            lblTipoVehiculo.Visible = true;
            lblCilindrada.Visible = false;
            lblPresupuestador.Text = "Presupuestador de Autos";
            txtCilindrada.Visible = false;
            cbTipo.Visible = true;
            cbPuertas.Visible = true;
            dgvDatosVehiculos.Visible = true;
            dgvDatosMotos.Visible = false;

            foreach (Automovil auto in bllauto.ListarTodo())
            {
                foreach (Presupuesto presu in bllpresupuesto.ListarTodo())
                {
                    if (auto.IdVehiculo == presu.IdVehiculo)
                    {
                        presuList.Add(presu);
                    }
                }
            }

            foreach (Presupuesto pres in presuList)
            {
                foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                {
                    if (pres.Id == desper.IdPresupuesto)
                    {
                        desperList.Add(desper);
                    }
                }
            }

            rdgv.Refresh(dgvDesperfecto, desperList);
            rdgv.Refresh(dgvPresupuestoCliente, presuList);
            rdgv.Refresh(dgvDatosVehiculos, ListaAutos());
            ArmarDgv();
        }

        private void rbMotos_CheckedChanged(object sender, EventArgs e)
        {
            presuList.Clear();
            desperList.Clear();
            VaciarDatos();

            lblCantidadPuertas.Visible = false;
            lblTipoVehiculo.Visible = false;
            lblCilindrada.Visible = true;
            lblPresupuestador.Text = "Presupuestador de Motos";
            txtCilindrada.Visible = true;
            cbTipo.Visible = false;
            cbPuertas.Visible = false;
            dgvDatosMotos.Visible = true;
            dgvDatosVehiculos.Visible = false;

            foreach (Moto moto in bllmoto.ListarTodo())
            {
                foreach (Presupuesto presu in bllpresupuesto.ListarTodo())
                {
                    if (moto.IdVehiculo == presu.IdVehiculo)
                    {
                        presuList.Add(presu);
                    }
                }
            }

            foreach (Presupuesto pres in presuList)
            {
                foreach (Desperfecto desper in blldesperfecto.ListarTodo())
                {
                    if (pres.Id == desper.IdPresupuesto)
                    {
                        desperList.Add(desper);
                    }
                }
            }

            rdgv.Refresh(dgvDesperfecto, desperList);
            rdgv.Refresh(dgvPresupuestoCliente, presuList);
            rdgv.Refresh(dgvDatosMotos, ListaMotos());

            ArmarDgv();
        }

        
        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            VaciarDatos();
        }
        #endregion

        #region DGV Click
        private void dgvDatosVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
                Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
                Automovil autoAux = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                bool activarDesperfectos = false;

                if (rbAutos.Checked == true)
                {
                    txtMarca.Text = autoAux.Marca;
                    txtModelo.Text = autoAux.Modelo;
                    txtPatente.Text = autoAux.Patente;
                    cbPuertas.Text = autoAux.CantidadPuertas.ToString();
                    cbTipo.Text = autoAux.TipoM.ToString();

                    int cont = 0;

                    foreach (Presupuesto presus in presuList)
                    {
                        if (autoAux.IdVehiculo == presus.IdVehiculo)
                        {
                            presupuestoAux = presus;
                            txtNombre.Text = presus.Nombre;
                            txtApellido.Text = presus.Apellido;
                            txtEmail.Text = presus.Email;
                            dgvPresupuestoCliente.Rows[cont].Selected = true;
                            activarDesperfectos = true;
                        }


                        cont++;
                    }
                }

                int cont1 = 0;
                foreach (Desperfecto des in desperList)
                {
                    if (activarDesperfectos == true)
                    {
                        if (des.IdPresupuesto == presupuestoAux.Id)
                        {
                            repuestoList.Clear();
                            string s = des.Descripcion;
                            s = s.Replace("\n", "\r\n");
                            txtDescripcion.Text = s;
                            txtManoDeObra.Text = des.ManoDeObra.ToString();
                            txtTiempo.Text = des.Tiempo.ToString();
                            foreach (DesperfectoRepuesto res in blldr.ListarTodo())
                            {
                                if (res.IdDesperfecto == des.Id)
                                {
                                    foreach (Repuesto repuestin in bllrepuesto.ListarTodo())
                                    {
                                        if (res.IdRepuesto == repuestin.Id)
                                        {
                                            repuestoList.Add(repuestin);
                                        }
                                    }
                                }
                                rdgv.Refresh(dgvRepuestos, repuestoList);
                                ArmarDgv();
                            }
                            dgvDesperfecto.Rows[cont1].Selected = true;
                        }
                    }

                    cont1++;
                }
            }
            catch (Exception)
            {

               
            }

            
        }
        private void dgvDatosMotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
                Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
                Moto motoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                bool activarDesperfectos = false;

                if (rbMotos.Checked == true)
                {
                    txtMarca.Text = motoAux.Marca;
                    txtModelo.Text = motoAux.Modelo;
                    txtPatente.Text = motoAux.Patente;
                    txtCilindrada.Text = motoAux.Cilindrada;

                    int contx = 0;
                    foreach (Presupuesto presusx in presuList)
                    {
                        if (motoAux.IdVehiculo == presusx.IdVehiculo)
                        {
                            presupuestoAux = presusx;
                            txtNombre.Text = presusx.Nombre;
                            txtApellido.Text = presusx.Apellido;
                            txtEmail.Text = presusx.Email;
                            dgvPresupuestoCliente.Rows[contx].Selected = true;
                            activarDesperfectos = true;
                        }
                        contx++;
                    }
                }

                int cont1 = 0;
                foreach (Desperfecto des in desperList)
                {
                    if (activarDesperfectos == true)
                    {
                        if (des.IdPresupuesto == presupuestoAux.Id)
                        {
                            repuestoList.Clear();
                            string s = des.Descripcion;
                            s = s.Replace("\n", "\r\n");
                            txtDescripcion.Text = s;
                            txtManoDeObra.Text = des.ManoDeObra.ToString();
                            txtTiempo.Text = des.Tiempo.ToString();
                            foreach (DesperfectoRepuesto res in blldr.ListarTodo())
                            {
                                if (res.IdDesperfecto == des.Id)
                                {
                                    foreach (Repuesto repuestin in bllrepuesto.ListarTodo())
                                    {
                                        if (res.IdRepuesto == repuestin.Id)
                                        {
                                            repuestoList.Add(repuestin);
                                        }
                                    }
                                }
                                rdgv.Refresh(dgvRepuestos, repuestoList);
                                ArmarDgv();
                            }

                            dgvDesperfecto.Rows[cont1].Selected = true;
                        }
                    }
                    cont1++;
                }
            }
            catch (Exception)
            {

               
            }
            
        }

        private void dgvPresupuestoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;
                Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;

                txtNombre.Text = presupuestoAux.Nombre;
                txtApellido.Text = presupuestoAux.Apellido;
                txtEmail.Text = presupuestoAux.Email;

                int cont = 0;
                if (rbAutos.Checked == true)
                {
                    Automovil autoAux = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                    foreach (Automovil auto in bllauto.ListarTodo())
                    {
                        if (presupuestoAux.IdVehiculo == auto.IdVehiculo)
                        {
                            autoAux = auto;
                            foreach (Vehiculo vehiculo in bllvehiculo.ListarTodoAuto())
                            {
                                if (vehiculo.Id == auto.IdVehiculo)
                                {
                                    txtMarca.Text = vehiculo.Marca;
                                    txtModelo.Text = vehiculo.Modelo;
                                    txtPatente.Text = vehiculo.Patente;
                                }
                            }
                            cbPuertas.Text = autoAux.CantidadPuertas.ToString();
                            cbTipo.Text = autoAux.TipoM.ToString();
                            dgvDatosVehiculos.Rows[cont].Selected = true;
                        }
                        cont++;
                    }
                }
                else if (rbMotos.Checked == true)
                {
                    Moto motoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                    foreach (Moto moto in bllmoto.ListarTodo())
                    {
                        if (presupuestoAux.IdVehiculo == moto.IdVehiculo)
                        {
                            motoAux = moto;
                            foreach (Vehiculo vehiculo in bllvehiculo.ListarTodoMoto())
                            {
                                if (vehiculo.Id == moto.IdVehiculo)
                                {
                                    txtMarca.Text = vehiculo.Marca;
                                    txtModelo.Text = vehiculo.Modelo;
                                    txtPatente.Text = vehiculo.Patente;
                                }
                            }
                            txtCilindrada.Text = motoAux.Cilindrada;
                            dgvDatosMotos.Rows[cont].Selected = true;
                        }
                        cont++;
                    }
                }

                int cont1 = 0;
                foreach (Desperfecto des in desperList)
                {
                    if (des.IdPresupuesto == presupuestoAux.Id)
                    {
                        repuestoList.Clear();
                        string s = des.Descripcion;
                        s = s.Replace("\n", "\r\n");
                        txtDescripcion.Text = s;
                        txtManoDeObra.Text = des.ManoDeObra.ToString();
                        txtTiempo.Text = des.Tiempo.ToString();
                        foreach (DesperfectoRepuesto res in blldr.ListarTodo())
                        {
                            if (res.IdDesperfecto == des.Id)
                            {
                                foreach (Repuesto repuestin in bllrepuesto.ListarTodo())
                                {
                                    if (res.IdRepuesto == repuestin.Id)
                                    {
                                        repuestoList.Add(repuestin);
                                    }
                                }
                            }
                            rdgv.Refresh(dgvRepuestos, repuestoList);
                            ArmarDgv();
                        }

                        dgvDesperfecto.Rows[cont1].Selected = true;
                    }

                    cont1++;
                }
            }
            catch (Exception)
            {

            }

            
        }

        private void dgvDesperfecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Desperfecto desperfectoAux = (Desperfecto)dgvDesperfecto.SelectedRows[0].DataBoundItem;
                Presupuesto presupuestoAux = (Presupuesto)dgvPresupuestoCliente.SelectedRows[0].DataBoundItem;

                dgvRepuestos.Enabled = true;

                repuestoList.Clear();
                string s = desperfectoAux.Descripcion;
                s = s.Replace("\n", "\r\n");
                txtDescripcion.Text = s;
                txtManoDeObra.Text = desperfectoAux.ManoDeObra.ToString();
                txtTiempo.Text = desperfectoAux.Tiempo.ToString();
                foreach (DesperfectoRepuesto res in blldr.ListarTodo())
                {
                    if (res.IdDesperfecto == desperfectoAux.Id)
                    {
                        foreach (Repuesto repuestin in bllrepuesto.ListarTodo())
                        {
                            if (res.IdRepuesto == repuestin.Id)
                            {
                                repuestoList.Add(repuestin);
                            }
                        }
                    }
                }
                rdgv.Refresh(dgvRepuestos, repuestoList);
                ArmarDgv();


                int cont = 0;
                foreach (Presupuesto presus in presuList)
                {
                    if (desperfectoAux.IdPresupuesto == presus.Id)
                    {
                        presupuestoAux = presus;
                        txtNombre.Text = presus.Nombre;
                        txtApellido.Text = presus.Apellido;
                        txtEmail.Text = presus.Email;
                        dgvPresupuestoCliente.Rows[cont].Selected = true;
                    }
                    cont++;
                }

                int cont1 = 0;
                int cont2 = 0;
                if (rbAutos.Checked == true)
                {
                    Automovil autoAux = (Automovil)dgvDatosVehiculos.SelectedRows[0].DataBoundItem;
                    foreach (Automovil auto in bllauto.ListarTodo())
                    {
                        if (presupuestoAux.IdVehiculo == auto.IdVehiculo)
                        {
                            autoAux = auto;
                            foreach (Vehiculo vehiculo in bllvehiculo.ListarTodoAuto())
                            {
                                if (vehiculo.Id == auto.IdVehiculo)
                                {
                                    txtMarca.Text = vehiculo.Marca;
                                    txtModelo.Text = vehiculo.Modelo;
                                    txtPatente.Text = vehiculo.Patente;
                                }
                            }
                            cbPuertas.Text = autoAux.CantidadPuertas.ToString();
                            cbTipo.Text = autoAux.TipoM.ToString();
                            dgvDatosVehiculos.Rows[cont1].Selected = true;
                        }
                        cont1++;
                    }
                }
                else if (rbMotos.Checked == true)
                {
                    Moto motoAux = (Moto)dgvDatosMotos.SelectedRows[0].DataBoundItem;
                    foreach (Moto moto in bllmoto.ListarTodo())
                    {
                        if (presupuestoAux.IdVehiculo == moto.IdVehiculo)
                        {
                            motoAux = moto;
                            foreach (Vehiculo vehiculo in bllvehiculo.ListarTodoMoto())
                            {
                                if (vehiculo.Id == moto.IdVehiculo)
                                {
                                    txtMarca.Text = vehiculo.Marca;
                                    txtModelo.Text = vehiculo.Modelo;
                                    txtPatente.Text = vehiculo.Patente;
                                }
                            }
                            txtCilindrada.Text = motoAux.Cilindrada;
                            dgvDatosMotos.Rows[cont2].Selected = true;
                        }
                        cont2++;
                    }
                }
            }
            catch (Exception)
            {

            }

            
        }

        private void dgvRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                Repuesto repuestoAux = (Repuesto)dgvRepuestos.SelectedRows[0].DataBoundItem;
                DialogResult result = MessageBox.Show("Desea borrar el repuesto " + repuestoAux.NombreRepuesto + " de la lista", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DesperfectoRepuesto desres in blldr.ListarTodo())
                    {
                        if (desres.IdRepuesto == repuestoAux.Id)
                        {
                            blldr.Borrar(desres);
                            repuestoList.Remove(repuestoAux);
                        }
                        else
                        {
                            repuestoList.Remove(repuestoAux);
                        }
                    }
                }
                rdgv.Refresh(dgvRepuestos, repuestoList);
                ArmarDgv();
            }
            catch (Exception)
            {

            }
            
        }
        #endregion

        #region cambios Texto
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == string.Empty)
            {
                repuestoList.Clear();
            }

        }

        private void txtManoDeObra_TextChanged(object sender, EventArgs e)
        {
            if (txtManoDeObra.Text == string.Empty)
            {
                repuestoList.Clear();
            }

        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            if (txtTiempo.Text == string.Empty)
            {
                repuestoList.Clear();
            }

        }
        #endregion
    }
}
