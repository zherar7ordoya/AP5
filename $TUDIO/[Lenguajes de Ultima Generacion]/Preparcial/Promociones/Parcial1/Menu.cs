using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace Parcial1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            oBLLTI = new BLLTarjetaInternacional();
            oBLLTN = new BLLTarjetaNacional();
        }
        BLLTarjetaInternacional oBLLTI;
        BLLTarjetaNacional oBLLTN;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes formempleados = new Clientes();
            formempleados.MdiParent = this;
            
            formempleados.Show();
        }

        private void tarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarjetas formtarjetas = new Tarjetas();
            formtarjetas.MdiParent = this;
            formtarjetas.Show();
        }

        private void asignacionYComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignacion formasignacion = new Asignacion();
            formasignacion.MdiParent = this;
            formasignacion.Show();

        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes forminformes = new Informes();
            forminformes.MdiParent = this;
            forminformes.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Chequear fechas de vencimiento
            List<BETarjetaInternacional> listainternacionales = new List<BETarjetaInternacional>();
            List<BETarjetaNacional> listanacionales = new List<BETarjetaNacional>();
            //Lleno la lista de tarjetas
            listainternacionales = oBLLTI.ListarTodo();
            listanacionales = oBLLTN.ListarTodo();
            //Por cada elemento chequeo su fecha de vencimiento
            foreach (BETarjetaInternacional p in listainternacionales)
            {
                if (p.FechaVencimiento < DateTime.Today)
                {
                    p.EnumEstado = BETarjeta.Estado.Vencida;
                    //Se guarda el nuevo estado
                    oBLLTI.Guardar(p);
                }
            }
            foreach (BETarjetaNacional p in listanacionales)
            {
                if (p.FechaVencimiento < DateTime.Today)
                {
                    p.EnumEstado = BETarjeta.Estado.Vencida;
                    //Se guarda el nuevo estado
                    oBLLTN.Guardar(p);
                }
            }

        }
    }
}
