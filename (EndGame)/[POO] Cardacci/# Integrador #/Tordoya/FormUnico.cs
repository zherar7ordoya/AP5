using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Integrador
{
    public partial class FormUnico : Form
    {
        public FormUnico()
        {
            InitializeComponent();
        }
        List<Persona> listadoPersonas = new List<Persona>();
        List<Auto> listadoAutos = new List<Auto>();

        private void FormUnico_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            /*
            dgvPersonas.SelectionChanged -= new EventHandler(this.dgvPersonas_SelectionChanged);
            dgvPersonas.Rows.Add("Gerardo");
            dgvPersonas.Rows.Add("Rodolfo");
            dgvPersonas.Rows.Add("Tordoya");
            dgvPersonas.ClearSelection();
            dgvPersonas.SelectionChanged += new EventHandler(this.dgvPersonas_SelectionChanged);

            Auto auto = new Auto("GRT 777", "Ford", "Gran Torino", "1972", 1000000);
            auto = null;
            GC.Collect();
            */
        }
        #region PERSONAS
        private void btnAltaPersona_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("Ingrese DNI", "Alta de Persona");
            string nombre = Interaction.InputBox("Ingrese Nombre", "Alta de Persona");
            string apellido = Interaction.InputBox("Ingrese Apellido", "Alta de Persona");
            if (dni != String.Empty &&
               nombre != String.Empty &&
               apellido != String.Empty)
            {
                listadoPersonas.Add(new Persona(dni, nombre, apellido));
                dgvPersonas.Rows.Clear();
                foreach (var x in listadoPersonas)
                {
                    dgvPersonas.Rows.Add(x.Apellido + ", " + x.Nombre, x.DNI);
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void btnBajaPersona_Click(object sender, EventArgs e)
        {
            int indice = dgvPersonas.CurrentRow.Index;
            listadoPersonas[indice] = null;

            listadoPersonas.RemoveAt(indice);
            GC.Collect();
            dgvPersonas.Rows.Clear();

            foreach (var x in listadoPersonas)
            {
                dgvPersonas.Rows.Add(x.Apellido + ", " + x.Nombre, x.DNI);
            }
        }
        private void btnModificacionPersona_Click(object sender, EventArgs e)
        {
            int indice = dgvPersonas.CurrentRow.Index;

            string dni = Interaction.InputBox("Ingrese DNI", "Alta de Persona");
            string nombre = Interaction.InputBox("Ingrese Nombre", "Alta de Persona");
            string apellido = Interaction.InputBox("Ingrese Apellido", "Alta de Persona");

            if (dni != String.Empty &&
                nombre != String.Empty &&
                apellido != String.Empty)
            {
                listadoPersonas[indice] = null;
                listadoPersonas.RemoveAt(indice);

                listadoPersonas.Add(new Persona(dni, nombre, apellido));
                dgvPersonas.Rows.Clear();

                foreach (var x in listadoPersonas)
                {
                    dgvPersonas.Rows.Add(x.Apellido + ", " + x.Nombre, x.DNI);
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int indice = dgvPersonas.CurrentRow.Index;
                decimal total = 0;
                dgvAutosDePersona.Rows.Clear();
                foreach (var x in listadoPersonas[indice].Autos)
                {
                    dgvAutosDePersona.Rows.Add(x.Marca + " " + x.Modelo, x.Precio);
                    total += x.Precio;
                }
                lblTotal.Text = string.Format("{0:C}", total);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region AUTOS
        private void btnAltaAuto_Click(object sender, EventArgs e)
        {
            string patente = Interaction.InputBox("Ingrese Patente", "Alta de Auto");
            string marca = Interaction.InputBox("Ingrese Marca", "Alta de Auto");
            string modelo = Interaction.InputBox("Ingrese Modelo", "Alta de Auto");
            string anio = Interaction.InputBox("Ingrese Año", "Alta de Auto");
            string precio = Interaction.InputBox("Ingrese Precio", "Alta de Auto");
            try
            {
                if (patente != String.Empty &&
                    marca != String.Empty &&
                    modelo != String.Empty &&
                    anio != String.Empty &&
                    precio != String.Empty)
                {
                    listadoAutos.Add(new Auto(patente, marca, modelo, anio, Convert.ToDecimal(precio)));
                    dgvAutos.Rows.Clear();
                    foreach (var x in listadoAutos)
                    {
                        dgvAutos.Rows.Add(x.Marca + " " + x.Modelo, x.Patente);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnBajaAuto_Click(object sender, EventArgs e)
        {
            int indice = dgvAutos.CurrentRow.Index;
            listadoAutos[indice] = null;
            listadoAutos.RemoveAt(indice);
            GC.Collect();

            dgvAutos.Rows.Clear();
            foreach (var x in listadoAutos)
            {
                dgvAutos.Rows.Add(x.Marca + " " + x.Modelo, x.Patente);
            }
        }
        private void btnModificacionAuto_Click(object sender, EventArgs e)
        {
            int indice = dgvAutos.CurrentRow.Index;

            string patente = Interaction.InputBox("Ingrese Patente", "Alta de Auto");
            string marca = Interaction.InputBox("Ingrese Marca", "Alta de Auto");
            string modelo = Interaction.InputBox("Ingrese Modelo", "Alta de Auto");
            string anio = Interaction.InputBox("Ingrese Año", "Alta de Auto");
            string precio = Interaction.InputBox("Ingrese Precio", "Alta de Auto");
            try
            {
                if (patente != String.Empty &&
                    marca != String.Empty &&
                    modelo != String.Empty &&
                    anio != String.Empty &&
                    precio != String.Empty)
                {
                    listadoAutos[indice] = null;
                    listadoAutos.RemoveAt(indice);

                    listadoAutos.Add(new Auto(patente, marca, modelo, anio, Convert.ToDecimal(precio)));
                    dgvAutos.Rows.Clear();

                    foreach (var x in listadoAutos)
                    {
                        dgvAutos.Rows.Add(x.Marca + " " + x.Modelo, x.Patente);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dgvAutos_SelectionChanged(object sender, EventArgs e)
        {
            if (listadoPersonas.Count > 0)
            {
                try
                {
                    int indice = dgvAutos.CurrentRow.Index;
                    string dni = dgvPersonas.CurrentRow.Cells[1].Value.ToString();
                    string duenio = dgvPersonas.CurrentRow.Cells[0].Value.ToString();

                    dgvDatosDeAuto.Rows.Clear();
                    dgvDatosDeAuto.Rows.Add(listadoAutos[indice].Marca);
                    dgvDatosDeAuto.Rows.Add(listadoAutos[indice].Anio);
                    dgvDatosDeAuto.Rows.Add(listadoAutos[indice].Modelo);
                    dgvDatosDeAuto.Rows.Add(listadoAutos[indice].Patente);

                    // Tiene trampa: estas personas no infaliblemente son los dueños.
                    dgvDatosDeAuto.Rows.Add(dni);
                    dgvDatosDeAuto.Rows.Add(duenio);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Ingrese Personas Antes",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        #endregion

        #region COMUNES
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int indice = dgvPersonas.CurrentRow.Index;
            string patente = dgvAutos.CurrentRow.Cells[1].Value.ToString();
            Auto nodo = listadoAutos.Find(x => x.Patente == patente);
            listadoPersonas[indice].Autos.Add(nodo);
            dgvAutosDePersona.Rows.Add(nodo.Marca + " " + nodo.Modelo, nodo.Precio);

            decimal total = 0;
            dgvAutosDePersona.Rows.Clear();
            foreach (var x in listadoPersonas[indice].Autos)
            {
                dgvAutosDePersona.Rows.Add(x.Marca + " " + x.Modelo, x.Precio);
                total += x.Precio;
            }
            lblTotal.Text = string.Format("{0:C}", total);
        }
        #endregion

        private void FormUnico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Salir?",
            "Pregunta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
