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
using System.Collections;

namespace Parcial1
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
            oBECliente = new BECliente();
            oBLLCliente = new BLLCliente();
            oBLLTI = new BLLTarjetaInternacional();
            oBLLTN = new BLLTarjetaNacional();
        }
        BECliente oBECliente;
        BLLCliente oBLLCliente;
        BLLTarjetaInternacional oBLLTI;
        BLLTarjetaNacional oBLLTN;
        


        private void Informes_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                //Tarjeta con menor importe
                //Internacional
                var menorimporteI = oBLLTI.ListarTodo().Min(x => x.Saldo);
                var objetomenorimporteI = oBLLTI.ListarTodo().Find(x => x.Saldo == menorimporteI);
                //Nacional
                var menorimporteN = oBLLTN.ListarTodo().Min(x => x.Saldo);
                var objetomenorimporteN = oBLLTN.ListarTodo().Find(x => x.Saldo == menorimporteN);
                //Se comparan ambos objetos para saber cual es el menor de ellos y se muestra en la grid
                if (objetomenorimporteI.Saldo < objetomenorimporteN.Saldo)
                {
                    List<BETarjetaInternacional> aux = new List<BETarjetaInternacional>();
                    aux.Add(objetomenorimporteI);
                    dataGridView3.DataSource = aux;
                }
                else
                {
                    List<BETarjetaNacional> aux = new List<BETarjetaNacional>();
                    aux.Add(objetomenorimporteN);
                    dataGridView3.DataSource = aux;
                }

                //Tarjeta con mayor descuento

                //Internacional
                var mayordescuentoI = oBLLTI.ListarTodo().Max(x => x.DescuentoAcumulado);
                var objetomayordescuentoI = oBLLTI.ListarTodo().Find(x => x.DescuentoAcumulado == mayordescuentoI);
                //Nacional
                var mayordescuentoN = oBLLTN.ListarTodo().Max(x => x.DescuentoAcumulado);
                var objetomayordescuentoN = oBLLTN.ListarTodo().Find(x => x.DescuentoAcumulado == mayordescuentoN);
                //Se comparan ambos objetos para saber cual es el mayor de ellos y se muestra en la grid
                if (objetomayordescuentoI.DescuentoAcumulado > objetomayordescuentoN.DescuentoAcumulado)
                {
                    List<BETarjetaInternacional> aux = new List<BETarjetaInternacional>();
                    aux.Add(objetomayordescuentoI);
                    dataGridView4.DataSource = aux;
                }
                else
                {
                    List<BETarjetaNacional> aux = new List<BETarjetaNacional>();
                    aux.Add(objetomayordescuentoN);
                    dataGridView4.DataSource = aux;
                }

                //b. Todas las tarjetas y con el saldo y los descuentos acumulados.

                List<BETarjetaInternacional> listainter = new List<BETarjetaInternacional>();
                List<BETarjetaNacional> listanacio = new List<BETarjetaNacional>();
                //Se llenan las listas con todas las tarjetas nacionales e internacionales
                listainter = oBLLTI.ListarTodo();
                listanacio = oBLLTN.ListarTodo();
                //Se crean manualmente las columnas del datagrid
                dataGridView1.Columns.Add(0.ToString(), "Codigo");
                dataGridView1.Columns.Add(0.ToString(), "Numero");
                dataGridView1.Columns.Add(0.ToString(), "Saldo");
                dataGridView1.Columns.Add(0.ToString(), "DescuentoAcumulado");
                List<BETarjeta> tarjetas = new List<BETarjeta>();
                foreach (BETarjetaInternacional p in listainter)
                {
                    //Se agregan las tarjetas internacionales al datagrid
                    dataGridView1.Rows.Add(p.Codigo, p.Numero, p.Saldo, p.DescuentoAcumulado);

                }
                foreach (BETarjetaNacional p in listanacio)
                {
                    //Se agregan las tarjetas Nacionales al datagrid
                    dataGridView1.Rows.Add(p.Codigo, p.Numero, p.Saldo, p.DescuentoAcumulado);
                }

                //a.Todos los clientes y la tarjeta que posee cada uno

                //Creo a mano las columnas
                dataGridView2.Columns.Add(0.ToString(), "Codigo");
                dataGridView2.Columns.Add(0.ToString(), "Nombre");
                dataGridView2.Columns.Add(0.ToString(), "Apellido");
                dataGridView2.Columns.Add(0.ToString(), "Codigo Tarjeta");
                dataGridView2.Columns.Add(0.ToString(), "Numero Tarjeta");
                dataGridView2.Columns.Add(0.ToString(), "Saldo");
                dataGridView2.Columns.Add(0.ToString(), "Fecha de Vencimiento");
                dataGridView2.Columns.Add(0.ToString(), "Tipo de Tarjeta");
                //Traigo una lista de clientes junto con sus tarjetas
                List<BECliente> listaclientes = new List<BECliente>();
                listaclientes = oBLLCliente.ListarTodo();
                //Recorro la lista
                foreach (BECliente p in listaclientes)
                {
                    //Pregunto de que tipo es la tarjeta; nacional o internacional, y cargo el datagrid
                    if (p.TarjetaInternacional != null)
                    {
                        dataGridView2.Rows.Add(p.Codigo, p.Nombre, p.Apellido, p.TarjetaInternacional.Codigo, p.TarjetaInternacional.Numero, p.TarjetaInternacional.Saldo, p.TarjetaInternacional.FechaVencimiento.ToShortDateString(), "Internacional");
                    }
                    if (p.TarjetaNacional != null)
                    {
                        dataGridView2.Rows.Add(p.Codigo, p.Nombre, p.Apellido, p.TarjetaNacional.Codigo, p.TarjetaNacional.Numero, p.TarjetaNacional.Saldo, p.TarjetaNacional.FechaVencimiento.ToShortDateString(), "Nacional");
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
