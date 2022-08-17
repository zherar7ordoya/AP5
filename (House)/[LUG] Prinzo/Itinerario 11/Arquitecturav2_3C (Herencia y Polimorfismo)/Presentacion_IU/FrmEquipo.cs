using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio_BLL;
using BE;

namespace Presentacion_IU
{
    public partial class FrmEquipo : Form
    {
        public FrmEquipo()
        {
            InitializeComponent();
            //intancio la lista de tecnico y equipos en el constructor del form
            LBETecnico = new List<BEClsTecnico>();
            LBEEquipo = new List<BEClsEquipo>();
        }

        //defino los objetos
        List<BEClsTecnico> LBETecnico;
        List<BEClsEquipo> LBEEquipo;
        BEClsEquipo oBEEquipo;
        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            //cargo la lista de tecnicos
            LBETecnico.Add(new BEClsTecnico() { Nombre = "Juan", Apellido = "Perez", DNI = 25234567 });
            LBETecnico.Add(new BEClsTecnico() { Nombre = "Pedro", Apellido = "Lopez", DNI = 23333567 });
            LBETecnico.Add(new BEClsTecnico() { Nombre = "Joaquin", Apellido = "Leguizamon", DNI = 15289067 });
            LBETecnico.Add(new BEClsTecnico() { Nombre = "Arnaldo", Apellido = "Conmebol", DNI = 32456789 });

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
            comboBox1.DataSource = LBETecnico;
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
            this.dataGridEquipo.DataSource = LBEEquipo;
            //propiedad de la grilla para autosize de columnas
            this.dataGridEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridEquipo.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //instancio el objeto equipo en el bloque
            oBEEquipo = new BEClsEquipo();
            //asigno los valores en el bloque para el Objeto Equipo
            oBEEquipo.Nombre = this.TxtNombreEquipo.Text;
            oBEEquipo.Color = this.TxtColoresEquipo.Text;
            oBEEquipo.Tecnico = (BEClsTecnico)comboBox1.SelectedItem;

            //aclaración una vez asignado el técnico debo borrarlo de la lista de técnicos

            foreach (BEClsTecnico ObjetoTecnico in LBETecnico)
            {
                //Si esta lo borro
                if (oBEEquipo.Tecnico.DNI == ObjetoTecnico.DNI)
                {
                    //borrado por objeto
                    LBETecnico.Remove(ObjetoTecnico);
                    break;
                }
            }

            CargarTecnico();

            //agrego el equipo a la lista de equipos
            LBEEquipo.Add(oBEEquipo);

            //lo muestro en la grilla de equipos
            CargarEquipoDatagrid();

            //limpio los txt de equipo
            TxtNombreEquipo.Text = string.Empty;
            TxtColoresEquipo.Text = string.Empty;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //defino el jugador
            BEClsJugador oJugador;

            //depende el tipo de jugador instancio una clase u otra
            if (comboBox2.Text == "Profesional")
            {
                oJugador = new BEClsProfesional();
            }
            else
            {
                BEClsPrincipiante oJugadorp = new BEClsPrincipiante();
                oJugadorp.Rapado = true;
                oJugador = new BEClsPrincipiante();
                oJugador = oJugadorp;
                
            }
            //asigno los valores
            oJugador.Nombre = TextBox1.Text;
            oJugador.CantidadAmarillas = Convert.ToInt32(TextBox3.Text);
            oJugador.CantidadRojas = Convert.ToInt32(TextBox2.Text);
            oJugador.GolesRealizados = Convert.ToInt32(TextBox4.Text);

            //agrego el jugador al equipo
            oBEEquipo.ListaJugadores.Add(oJugador);

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
            oBEEquipo = (BEClsEquipo)this.dataGridEquipo.CurrentRow.DataBoundItem;

            dataGridJugadores.DataSource = null;
            //como el objeto Equipo tiene ya su lista de jugadores, la muestro
            dataGridJugadores.DataSource = oBEEquipo.ListaJugadores;
            //propiedad de la grilla para autosize de columnas
            dataGridJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            dataGridJugadores.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int MaxPtje = 0;
            string MaxNomb = string.Empty;

            BLLClsEquipo oBLLEquipo = new BLLClsEquipo();

            foreach (BEClsEquipo oBEEquipo in LBEEquipo)
            {
                if (oBLLEquipo.ObtenerPuntajeEquipo(oBEEquipo) > MaxPtje)
                {
                    MaxNomb = oBEEquipo.Nombre;
                    MaxPtje = oBLLEquipo.ObtenerPuntajeEquipo(oBEEquipo);
                }
            }

            Label14.Text = "El puntaje Maximo fue del equipo " + MaxNomb + " : " + Convert.ToString(MaxPtje);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
