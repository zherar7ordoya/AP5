using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPracticoOrientador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
       
        //Instanciacion de clases en objetos
        Auto _auto;
        Persona _persona;
        Propietario _propietario;
        Poosedores _poosedor = new Poosedores();
        Vinculo _vinculo = new Vinculo();
        CargaAuto _cargaAuto = new CargaAuto();
        CargaPersona _cargaPersona = new CargaPersona();
        //Listas de uso
        List<Auto> autos = new List<Auto>();
        public List<Persona> personas = new List<Persona>();
        List<Propietario> propietarios = new List<Propietario>();
        List<Propietario> propPoose = new List<Propietario>();

        public void EnlazarPersona(List<Persona> personas)
        {
            dgvPersona.DataSource = null;
            dgvPersona.DataSource = personas;
        }
        /// <summary>
        /// Metodo que enlaza la lista autos con el datagridview
        /// </summary>
        /// <param name="autos"></param>
        public void EnlazarAuto(List<Auto> autos)
        {
            dgvAuto.DataSource = null;
            dgvAuto.DataSource = autos;
        }
        /// <summary>
        /// Metodo que enlaza la lista propietarios con el datagridview
        /// </summary>
        /// <param name="propietarios"></param>
        public void EnlazarPropietario(List<Propietario> propietarios)
        {
            _vinculo.dgvPropietario.DataSource = null;
            _vinculo.dgvPropietario.DataSource = propietarios;
            _vinculo.dgvPropietario.Columns["Precio"].Visible = false;

        }
        /// <summary>
        /// Metodo que enlaza la lista de cada propietario con auto con el datagridview
        /// </summary>
        /// <param name="propietarios"></param>
        public void EnlazarPoosedor(List<Propietario> propietarios)
        {
            _poosedor.dgvPoosedores.DataSource = null;
            _poosedor.dgvPoosedores.DataSource = propietarios;
        }

        /// <summary>
        /// Metodo para el evento de carga de autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargharAuto_Click(object sender, EventArgs e)
        {
            _cargaAuto.ShowDialog();
            _auto = new Auto(_cargaAuto.txtPatente.Text, _cargaAuto.txtMarca.Text, _cargaAuto.txtModelo.Text, Convert.ToString(_cargaAuto.ano), _cargaAuto.precio);
            autos.Add(_auto);
            EnlazarAuto(autos);
            _cargaAuto.Borrar();
        }
        /// <summary>
        /// Metodo para el evento de carga de personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarPersona_Click(object sender, EventArgs e)
        {
            _cargaPersona.ShowDialog();
            _persona = new Persona(Convert.ToString(_cargaPersona.dni), _cargaPersona.txtNombre.Text, _cargaPersona.txtApellido.Text);
            personas.Add(_persona);
            EnlazarPersona(personas);
            _cargaPersona.Borrar();
            
        }
        /// <summary>
        /// Metodo para el evento de borrado de personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                Persona per = (Persona)dgvPersona.SelectedRows[0].DataBoundItem;
                personas.Remove(per);
                EnlazarPersona(personas);
                //GC.SuppressFinalize(this);
               
            }
            catch
            {
                MessageBox.Show("Falta seleccionar un elemento para borrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// Metodo para el evento de borrado de autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                Auto aut = (Auto)dgvAuto.SelectedRows[0].DataBoundItem;
                autos.Remove(aut);
                EnlazarAuto(autos);
            }
            catch
            {
                MessageBox.Show("Falta seleccionar un elemento para borrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        /// <summary>
        /// Metodo para el evento de modificado de personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                Persona personita = (Persona)dgvPersona.SelectedRows[0].DataBoundItem;
                var indice = personas.IndexOf(personita);
                _cargaPersona.txtDni.Text = personita.Dni;
                _cargaPersona.txtApellido.Text = personita.Apellido;
                _cargaPersona.txtNombre.Text = personita.Nombre;
                _cargaPersona.ShowDialog();
                _persona = new Persona(_cargaPersona.txtDni.Text, _cargaPersona.txtNombre.Text, _cargaPersona.txtApellido.Text);
                personas.RemoveAt(indice);
                personas.Insert(indice, _persona);
                EnlazarPersona(personas);
            }
            catch
            {
                MessageBox.Show("Falta seleccionar un elemento para ser modificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        /// <summary>
        /// Metodo para el evento de modificado de autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                Auto autito = (Auto)dgvAuto.SelectedRows[0].DataBoundItem;
                var indice = autos.IndexOf(autito);
                _cargaAuto.txtPatente.Text = autito.Patente;
                _cargaAuto.txtMarca.Text = autito.Marca;
                _cargaAuto.txtModelo.Text = autito.Modelo;
                _cargaAuto.txtAno.Text = autito.Ano;
                _cargaAuto.txtPrecio.Text = Convert.ToString(autito.Precio);
                _cargaAuto.ShowDialog();
                _auto = new Auto(_cargaAuto.txtPatente.Text, _cargaAuto.txtMarca.Text, _cargaAuto.txtModelo.Text, _cargaAuto.txtAno.Text, decimal.Parse(_cargaAuto.txtPrecio.Text));
                autos.RemoveAt(indice);
                autos.Insert(indice, _auto);
                EnlazarAuto(autos);
            }
            catch
            {
                MessageBox.Show("Falta seleccionar un elemento para ser modificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        /// <summary>
        /// Metodo para el evento donde se asignan las personas a los autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                _persona = (Persona)dgvPersona.SelectedRows[0].DataBoundItem;
                _auto = (Auto)dgvAuto.SelectedRows[0].DataBoundItem;
                _propietario = new Propietario(_auto.Marca, _auto.Ano, _auto.Modelo, _auto.Patente, _persona.Dni, _persona.Apellido + " " +_persona.Nombre, _auto.Precio);
                propietarios.Add(_propietario);
                EnlazarPropietario(propietarios);
                MessageBox.Show("Se asigno exisotasemente","Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception)
            {
                MessageBox.Show("Hay que asignar un propietario y un vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        /// <summary>
        /// Metodo del evento que muestra el formulario vinculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVistaPropietario_Click(object sender, EventArgs e)
        {
            
             _vinculo.ShowDialog();
        }
        /// <summary>
        /// Metodo del evento cuando se hace doble click sobre alguna persona del datagridview
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            String valor = "";
            String valor1 = "";
            valor = dgvPersona.Rows[dgvPersona.CurrentRow.Index].Cells[0].Value.ToString();
            valor1 = dgvPersona.Rows[dgvPersona.CurrentRow.Index].Cells[1].Value.ToString();
            if (propPoose != null)
            {
                propPoose.Clear();
            }
            _poosedor.lblnombre.Text = valor1;
            foreach (var propetario in propietarios)
            {
                if(valor == propetario.Dni)
                {
                    total = total + propetario.Precio;
                    propPoose.Add(propetario);                   
                    EnlazarPoosedor(propPoose);
                }
                
            }
            _poosedor.lblValor.Text = total.ToString();
           
            _poosedor.ShowDialog();
        }

    }
    

}
