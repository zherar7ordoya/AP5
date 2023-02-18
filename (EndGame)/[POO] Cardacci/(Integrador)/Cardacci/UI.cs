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

namespace Integrador
{
    public partial class UI : Form
    {
        #region VARIABLES DE CLASE, CONSTRUCTOR Y LOAD ------------------------

        readonly Concesionario _concesionario;
        readonly VistaAuto _vista_auto;

        public UI()
        {
            InitializeComponent();
            _concesionario = new Concesionario();
            _vista_auto = new VistaAuto();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            ActualizaDatagridview(
                PersonaListadoDgv,
                _concesionario.RetornaListaPersonas());
            ActualizaDatagridview(
                AutoListadoDgv,
                _concesionario.RetornaListaAutos());
            ActualizaDatagridview(
                PersonaAutosDgv,
                _concesionario.RetornaListaAutos());
        }

        #endregion


        // ABM PERSONA --------------------------------------------------------
        private void PersonaAgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //todo validar DNI
                string _dni = Interaction.InputBox("DNI: ");
                _concesionario.AgregaPersona(new Persona(_dni, Interaction.InputBox("Nombre: "), Interaction.InputBox("Apellido: ")));

                ActualizaDatagridview(
                    PersonaListadoDgv,
                    _concesionario.RetornaListaPersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void PersonaBorrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que haya datods para borrar
                if (PersonaListadoDgv.Rows.Count > 0)
                {
                    // Se le pasa a BorrarPpersona del concesionario La persona seleccionado en el grilla 1
                    _concesionario.BorraPersona(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona);

                    ActualizaDatagridview(
                        PersonaListadoDgv,
                        _concesionario.RetornaListaPersonas());
                }
                else
                { throw new Exception("No hay nada que borrar !!!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void PersonaModificarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay algo para modificar
                if (PersonaListadoDgv.Rows.Count > 0)
                {
                    // Obtiene la persona seleccionada en la grilla 1

                    // Si la persona en distinta de nulo se procede a la modificación
                    if (PersonaListadoDgv.SelectedRows[0].DataBoundItem is Persona _persona)
                    {
                        // Se modifica el nombre
                        _persona.Nombre = Interaction.InputBox("Nombre: ", "Modificando Persona ...", _persona.Nombre);
                        // Se modifica el apellido
                        _persona.Apellido = Interaction.InputBox("Apellido: ", "Modificando Persona ...", _persona.Apellido);
                        // Se envía a ModificarPersona del concesionario la persona seleccionada en la grilla 
                        // con el estado actualizado
                        _concesionario.ModificaPersona(_persona);

                        // Opción Básica
                        ActualizaDatagridview(
                            PersonaListadoDgv,
                            _concesionario.RetornaListaPersonas());
                        // Opción con LinQ
                        ActualizaDatagridview(
                            PersonaListadoDgv,
                            _vista_auto.ObjetoVistaAuto(_concesionario.RetornaListaAutos()));
                        // Opción con Clase Vista
                        ActualizaDatagridview(
                            AutoDetallesDgv,
                            _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
                    }
                    else { throw new Exception("La persona que intenta modificar en null"); }
                }
                else { throw new Exception("No existe persona para modificar !!!"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        // ABM AUTO -----------------------------------------------------------
        private void AutoAgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //todo validar PATENTE
                string _auxpatente = Interaction.InputBox("Patente: ");
                _concesionario.AgregaAuto(new Auto(
                    _auxpatente,
                    Interaction.InputBox("Marca"),
                    Interaction.InputBox("Modelo"),
                    Interaction.InputBox("Año"),
                    decimal.Parse(Interaction.InputBox("Precio"))));

                // Opción Básica
                ActualizaDatagridview(
                    AutoListadoDgv,
                    _concesionario.RetornaListaAutos());

                // --- TIENE ERROR --------------------------------------------
                // Opción con LinQ
                //ActualizaDatagridview(AutoListadoDgv, _vista_auto.ObjetoVistaAuto(_concesionario.RetornaListaAutos()));
                // ------------------------------------------------------------

                //Opción con Clase Vista
                ActualizaDatagridview(
                    AutoDetallesDgv,
                    _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void AutoBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se controla que el la grilla 2 haya algo para borrar
                if (AutoListadoDgv.Rows.Count > 0)
                {

                    // Se envía el Auto seleccionado en la grilla 2 a BorrarAuto del concesionario
                    _concesionario.BorraAuto(AutoListadoDgv.SelectedRows[0].DataBoundItem as Auto);

                    // Opción Básica
                    ActualizaDatagridview(
                        AutoListadoDgv,
                        _concesionario.RetornaListaAutos());
                    // Opción con LinQ
                    ActualizaDatagridview(
                        AutoListadoDgv,
                        _vista_auto.ObjetoVistaAuto(_concesionario.RetornaListaAutos()));
                    // Opción con Clase Vista
                    ActualizaDatagridview(
                        AutoDetallesDgv,
                        _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
                }
                else
                { throw new Exception("No hay nada que borrar !!!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AutoModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay algún auto que modificar en la grilla 2
                if (AutoListadoDgv.Rows.Count > 0)
                {
                    // Se obtiene el auto seleccionado en la grilla 2
                    Auto _auxAuto = AutoListadoDgv.SelectedRows[0].DataBoundItem as Auto;
                    if (_auxAuto != null)
                    {
                        // Se actualiza el estado del auto
                        _auxAuto.Marca = Interaction.InputBox("Marca: ", "Modificando Auto ...", _auxAuto.Marca);
                        _auxAuto.Modelo = Interaction.InputBox("Modelo: ", "Modificando Auto ...", _auxAuto.Modelo);
                        _auxAuto.Axo = Interaction.InputBox("Año: ", "Modificando Auto ...", _auxAuto.Axo);
                        _auxAuto.Precio = decimal.Parse(Interaction.InputBox("Precio: ", "Modificando Auto ...", _auxAuto.Precio.ToString()));

                        // Se llama a ModificarAuto del concesionario
                        _concesionario.ModificaAuto(_auxAuto);

                        ActualizaDatagridview(
                            AutoListadoDgv,
                            _concesionario.RetornaListaAutos());
                        ActualizaDatagridview(
                            PersonaAutosDgv,
                            _concesionario.ListaAutosDePersona(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona));

                        // Opción con Clase Vista
                        ActualizaDatagridview(
                            AutoDetallesDgv,
                            _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
                        // Opción con LinQ
                        ActualizaDatagridview(
                            AutoDetallesDgv,
                            _vista_auto.ObjetoVistaAuto(_concesionario.RetornaListaAutos()));

                        ActualizaPrecioTotal();
                    }
                    else { throw new Exception("El auto que intenta modificar en null"); }
                }
                else { throw new Exception("No existe auto para modificar !!!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        // ASIGNAR Y DESASIGNAR AUTO ------------------------------------------
        private void AutoAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se envía a Asignar auto del concesionario la Persona seleccionada en la grilla 1
                // y el auto seleccionado en la grilla 2
                Persona _persona = PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona;
                Auto _auto = AutoListadoDgv.SelectedRows[0].DataBoundItem as Auto;

                _concesionario.AsignaAuto(_persona, _auto);

                ActualizaDatagridview(
                    PersonaAutosDgv,
                    _concesionario.ListaAutosDePersona(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona));
                // Opción con LinQ
                ActualizaDatagridview(
                    AutoDetallesDgv,
                    _vista_auto.ObjetoVistaAuto(_concesionario.RetornaListaAutos()));
                // Opción con Clase Vista
                ActualizaDatagridview(
                    AutoDetallesDgv,
                    _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void AutoDesasignar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se envia a QuitarAutoAsignado del concesionario:
                // 1. La persona seleccionada en la grilla 1 (Esto también se puede ubicar tomando el auto
                // seleccionado en la grilla 3 y consultandole por su dueño). 
                // 2. El auto seleccionado en la grilla 3.
                _concesionario.DesasignaAuto(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona, PersonaAutosDgv.SelectedRows[0].DataBoundItem as Auto);

                ActualizaDatagridview(
                    PersonaAutosDgv,
                    _concesionario.ListaAutosDePersona(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona));
                // Opción con Clase Vista
                ActualizaDatagridview(
                    AutoDetallesDgv,
                    _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
                // Opción con LinQ
                ActualizaDatagridview(
                    AutoDetallesDgv,
                    _vista_auto.ListaVistaAuto(_concesionario.RetornaListaAutos()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        // --- Métodos de Apoyo -----------------------------------------------
        private void ActualizaPrecioTotal()
        {
            decimal _total = 0;
            List<Auto> _la = _concesionario.ListaAutosDePersona(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona);
            if (_la.Count > 0)
            {
                foreach (Auto _a in _la)
                {
                    _total += _a.Precio;
                }
            }
            AutoTotalLbl.Text = _total.ToString();
        }


        void ActualizaDatagridview(DataGridView pDGV, object pObject)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pObject;
        }


        // --- Eventos --------------------------------------------------------
        private void PersonaListadoDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ActualizaDatagridview(
                    PersonaAutosDgv,
                    _concesionario.ListaAutosDePersona(PersonaListadoDgv.SelectedRows[0].DataBoundItem as Persona));
                ActualizaPrecioTotal();
            }
            catch (Exception) { }
        }


        private void PersonaAutosDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ActualizaPrecioTotal();
        }

    }
}
