using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Negocio_BLL;

namespace Presentacion_IU
{
    public partial class FrmEquipo : Form
    {
        public FrmEquipo()
        {
            InitializeComponent();
            //intancio la lista de tecnico y equipos en el constructor del form
            LTecnico = new List<BLLClsTecnico>();
            LEquipo = new List<BLLClsEquipo>();
        }

        //defino los objetos
        List<BLLClsTecnico> LTecnico;
        List<BLLClsEquipo> LEquipo;
        BLLClsEquipo oEquipo;
        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            //cargo la lista de tecnicos
            LTecnico.Add(new BLLClsTecnico() { Nombre = "Juan", Apellido = "Perez", DNI = 25234567 });
            LTecnico.Add(new BLLClsTecnico() { Nombre = "Pedro", Apellido = "Lopez", DNI = 23333567 });
            LTecnico.Add(new BLLClsTecnico() { Nombre = "Joaquin", Apellido = "Leguizamon", DNI = 15289067 });
            LTecnico.Add(new BLLClsTecnico() { Nombre = "Arnaldo", Apellido = "Conmebol", DNI = 32456789 });

            //cargo el técnico en load, para cuando cargue el form ya aparezcan los datos del mismo 
            CargarTecnico();

            //vacio lo que se encuentre en el label
            Label14.Text = string.Empty;
        }

        //cargar un combo con una lista
        public void CargarTecnico()
        {
            //lleno al combo con la lista
            comboBox1.DataSource = null;
            // lo limpio paraque me actualice cuando agrego valores a la lista
            comboBox1.DataSource = LTecnico;
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            comboBox1.ValueMember = "DNI";
            //la variable publica de la clase
            comboBox1.DisplayMember = "Apellido";
            comboBox1.Refresh();

        }


        //cargo el datagrid con la lista
        public void CargarEquipoDatagrid()
        {
            this.dataGridEquipo.DataSource = null;
            // lo limpio paraque me actualice cuando agrego valores a la lista
            this.dataGridEquipo.DataSource = LEquipo;
            //propiedad de la grilla para autosize de columnas
            this.dataGridEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridEquipo.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //instancio el objeto equipo en el bloque
            oEquipo = new BLLClsEquipo();
            //asigno los valores en el bloque para el Objeto Equipo
            oEquipo.Nombre = this.TxtNombreEquipo.Text;
            oEquipo.Color = this.TxtColoresEquipo.Text;
            oEquipo.Tecnico = (BLLClsTecnico)comboBox1.SelectedItem;

            //aclaración una vez asignado el técnico debo borrarlo de la lista de técnicos

            foreach (BLLClsTecnico ObjetoTecnico in LTecnico)
            {
                //Si esta lo borro
                if (oEquipo.Tecnico.DNI == ObjetoTecnico.DNI)
                {
                    //borrado por objeto
                    LTecnico.Remove(ObjetoTecnico);
                    break;
                }
            }

            CargarTecnico();

            //agrego el equipo a la lista de equipos
            LEquipo.Add(oEquipo);

            //lo muestro en la grilla de equipos
            CargarEquipoDatagrid();

            //limpio los txt de equipo
            TxtNombreEquipo.Text = string.Empty;
            TxtColoresEquipo.Text = string.Empty;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //defino el jugador
            BLLClsJugador oJugador;

            //depende el tipo de jugador instancio una clase u otra
            if (comboBox2.Text == "Profesional")
            {
                oJugador = new BLLClsProfesional();
            }
            else
            {
                BLLClsPrincipiante oJugadorp = new BLLClsPrincipiante();
                oJugadorp.Rapado = true;
                oJugador = new BLLClsPrincipiante();
                oJugador = oJugadorp;
                
            }
            //asigno los valores
            oJugador.Nombre = TextBox1.Text;
            oJugador.CantidadAmarillas = Convert.ToInt32(TextBox3.Text);
            oJugador.CantidadRojas = Convert.ToInt32(TextBox2.Text);
            oJugador.GolesRealizados = Convert.ToInt32(TextBox4.Text);

            //agrego el jugador al equipo
            oEquipo.ListaJugadores.Add(oJugador);

            Limpiar();
        }

        void Limpiar()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;


        }

        private void dataGridEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oEquipo = (BLLClsEquipo)this.dataGridEquipo.CurrentRow.DataBoundItem;

            dataGridJugadores.DataSource = null;
            //como el objeto Equipo tiene ya su lista de jugadores, la muestro
            dataGridJugadores.DataSource = oEquipo.ListaJugadores;
            //propiedad de la grilla para autosize de columnas
            dataGridJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            dataGridJugadores.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int MaxPtje = 0;
            string MaxNomb = string.Empty;

            foreach (BLLClsEquipo oEquipo in LEquipo)
            {
                if (oEquipo.ObtenerPuntajeEquipo() > MaxPtje)
                {
                    MaxNomb = oEquipo.Nombre;
                    MaxPtje = oEquipo.ObtenerPuntajeEquipo();
                }
            }

            Label14.Text = "El puntaje Maximo fue del equipo " + MaxNomb + " : " + Convert.ToString(MaxPtje);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
