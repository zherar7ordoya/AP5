using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscritorioClasico.ClienteGiftcard
{
    public partial class ClienteGiftcardForm : Form
    {
        BEL.Cliente belCliente=new BEL.Cliente();
        BLL.Cliente bllCliente=new BLL.Cliente();

        BEL.GiftcardInternacional belGiftcardInternacional = new BEL.GiftcardInternacional();
        BLL.GiftcardInternacional bllGiftcardInternacional=new BLL.GiftcardInternacional();

        BEL.GiftcardNacional belGiftcardNacional = new BEL.GiftcardNacional();
        BLL.GiftcardNacional bllGiftcardNacional=new BLL.GiftcardNacional();

        // *-------------------------------------------------------=> SINGLETON
        private ClienteGiftcardForm() => InitializeComponent();
        private static ClienteGiftcardForm instancia = null;
        public static ClienteGiftcardForm Instancia()
        {
            if (instancia == null) instancia = new ClienteGiftcardForm();
            return instancia;
        }

        private void ClienteGiftcardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********

        private void ClienteGiftcardForm_Load(object sender, System.EventArgs e) => InaugurarForm();

        private void InaugurarForm()
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = bllCliente.Listar();

            this.InternacionalesDisponiblesDataGridView.DataSource = null;
            this.InternacionalesDisponiblesDataGridView.Rows.Clear();
            this.InternacionalesDisponiblesDataGridView.DataSource = bllGiftcardInternacional.ListarDisponibles();
            this.InternacionalesDisponiblesDataGridView.Columns["Pais"].DisplayIndex = 0;
            this.InternacionalesDisponiblesDataGridView.Columns["Estado"].DisplayIndex = 1;

            this.NacionalesDisponiblesDataGridView.DataSource = null;
            this.NacionalesDisponiblesDataGridView.Rows.Clear();
            this.NacionalesDisponiblesDataGridView.DataSource = bllGiftcardNacional.ListarDisponibles();
            this.NacionalesDisponiblesDataGridView.Columns["Provincia"].DisplayIndex = 0;
            this.NacionalesDisponiblesDataGridView.Columns["Estado"].DisplayIndex = 2;

            LimpiarTextBoxes();
        }

        // *---------------------------------------------------------------=> *

        private void ClientesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente objeto = bllCliente.Detallar(belCliente);
            GiftcardAsignada(objeto);
        }


        public void GiftcardAsignada(BEL.Cliente objeto)
        {
            BEL.Cliente cliente = bllCliente.Detallar(objeto);

            if (cliente.Tarjeta == null) LimpiarTextBoxes();
            else
            {
                if (cliente.Tarjeta[0] is BEL.GiftcardInternacional)
                {
                    foreach (BEL.GiftcardInternacional tarjeta in cliente.Tarjeta)
                    {
                        this.TipoTextBox.Text = "Internacional";
                        this.ProvinciaTextBox.Text = "(Sin asignar)";
                    }
                }
                if (cliente.Tarjeta[0] is BEL.GiftcardNacional)
                {
                    foreach (BEL.GiftcardNacional tarjeta in cliente.Tarjeta)
                    {
                        this.TipoTextBox.Text = "Nacional";
                        this.ProvinciaTextBox.Text = tarjeta.Provincia.ToString();
                    }
                }
                this.CodigoTextBox.Text = cliente.Tarjeta[0].Codigo.ToString();
                this.NumeroTextBox.Text = cliente.Tarjeta[0].Numero.ToString();
                this.FechaVencimientoTextBox.Text = cliente.Tarjeta[0].Vencimiento.ToString();
                this.SaldoTextBox.Text = cliente.Tarjeta[0].Saldo.ToString();
                this.DescuentosTextBox.Text = cliente.Tarjeta[0].Descuento.ToString();
                this.RubroTextBox.Text = cliente.Tarjeta[0].Rubro.ToString();
                this.EstadoTextBox.Text = cliente.Tarjeta[0].Estado.ToString();
                this.PaisTextBox.Text = cliente.Tarjeta[0].Pais.ToString();
            }
        }


        private void LimpiarTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox box) box.Text = string.Empty;
                if (ctrl is GroupBox)
                {
                    foreach (Control txtbox in ctrl.Controls)
                    {
                        if (txtbox is TextBox) txtbox.Text = string.Empty;
                    }
                }
            }
        }

        // *---------------------------------------------------------------=> *

        public List<BEL.GiftcardInternacional> ListarInternacionales(BEL.Cliente objeto)
        {
            List<BEL.GiftcardInternacional> ListaTarjetas = new List<BEL.GiftcardInternacional>();
            BEL.Cliente cliente = bllCliente.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Giftcard tarjeta in cliente.Tarjeta)
                {
                    if (tarjeta is BEL.GiftcardInternacional) ListaTarjetas.Add((BEL.GiftcardInternacional)tarjeta);
                }
            }
            return ListaTarjetas;
        }
        

        public List<BEL.GiftcardNacional> ListarNacionales(BEL.Cliente objeto)
        {
            List<BEL.GiftcardNacional> ListaTarjetas = new List<BEL.GiftcardNacional>();
            BEL.Cliente cliente = bllCliente.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Giftcard tarjeta in cliente.Tarjeta)
                {
                    if (tarjeta is BEL.GiftcardNacional) ListaTarjetas.Add((BEL.GiftcardNacional)tarjeta);
                }
            }
            return ListaTarjetas;
        }

        // *---------------------------------------------------------------=> *

        private void InternacionalesDisponiblesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            belGiftcardInternacional = (BEL.GiftcardInternacional)InternacionalesDisponiblesDataGridView.CurrentRow.DataBoundItem;
            belGiftcardNacional = null;
        }


        private void NacionalesDisponiblesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            belGiftcardNacional = (BEL.GiftcardNacional)NacionalesDisponiblesDataGridView.CurrentRow.DataBoundItem;
            belGiftcardInternacional = null;
        }


        private void DesasociarButton_Click(object sender, EventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente belClienteDetallado = bllCliente.Detallar(belCliente);

            if (TipoTextBox.Text == "Internacional")
            {
                belGiftcardInternacional.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                belGiftcardInternacional.Numero = Convert.ToInt32(NumeroTextBox.Text);
                belGiftcardInternacional.Vencimiento = Convert.ToDateTime(FechaVencimientoTextBox.Text);
                belGiftcardInternacional.Saldo = Convert.ToInt32(SaldoTextBox.Text);
                belGiftcardInternacional.Descuento = Convert.ToInt32(DescuentosTextBox.Text);
                belGiftcardInternacional.Estado = EstadoTextBox.Text;
                belGiftcardInternacional.Rubro = RubroTextBox.Text;
                belGiftcardInternacional.Pais = PaisTextBox.Text;

                bllCliente.DesasociarGiftcardInternacional(belClienteDetallado, belGiftcardInternacional);
                belGiftcardInternacional.Estado = "Baja";
                belGiftcardInternacional.Saldo = 0;
                bllGiftcardInternacional.Guardar(belGiftcardInternacional);

                string message = "Operación correcta";
                string caption = "Información";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Information);
                InaugurarForm();
            }
            else if (TipoTextBox.Text == "Nacional")
            {
                belGiftcardNacional.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                belGiftcardNacional.Numero = Convert.ToInt32(NumeroTextBox.Text);
                belGiftcardNacional.Vencimiento = Convert.ToDateTime(FechaVencimientoTextBox.Text);
                belGiftcardNacional.Saldo = Convert.ToInt32(SaldoTextBox.Text);
                belGiftcardNacional.Descuento = Convert.ToInt32(DescuentosTextBox.Text);
                belGiftcardNacional.Estado = EstadoTextBox.Text;
                belGiftcardNacional.Rubro = RubroTextBox.Text;
                belGiftcardNacional.Pais = PaisTextBox.Text;
                belGiftcardNacional.Provincia = ProvinciaTextBox.Text;

                bllCliente.DesasociarGiftcardNacional(belClienteDetallado, belGiftcardNacional);
                belGiftcardNacional.Estado = "Baja";
                belGiftcardNacional.Saldo = 0;
                bllGiftcardNacional.Guardar(belGiftcardNacional);

                string message = "Operación correcta";
                string caption = "Información";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Information);
                InaugurarForm();
            }
            else
            {
                string message = "Seleccione Gift Card a eliminar";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error);
            }
        }


        private void AsociarButton_Click(object sender, EventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente belClienteDetallado = bllCliente.Detallar(belCliente);

            if (ImporteImputadoTextBox.Text == "")
            {
                MessageBox.Show("Ingrese importe a cargar");
                return;
            }

            if (EsLibre(belClienteDetallado) == false)
            {
                MessageBox.Show("No se puede asignar");
                return;
            }

            if (belGiftcardInternacional == null && belGiftcardNacional == null)
            {
                MessageBox.Show("Seleccione Gift Card a asociar.");
                return;
            }

            if (belGiftcardNacional == null)
            {
                if (belGiftcardInternacional.Estado != "Libre")
                {
                    MessageBox.Show("Tarjeta no disponible");
                    return;
                }
            }

            if (belGiftcardInternacional == null)
            {
                if (belGiftcardNacional.Estado != "Libre")
                {
                    MessageBox.Show("Tarjeta no disponible");
                    return;
                }
            }

            if (belGiftcardNacional == null)
            {
                belGiftcardInternacional.Saldo = Convert.ToInt32(ImporteImputadoTextBox.Text);
                belGiftcardInternacional.Estado = "Activa";
                bllGiftcardInternacional.Guardar(belGiftcardInternacional);
                bllCliente.AsociarGiftcardInternacional(belClienteDetallado, belGiftcardInternacional);

                MessageBox.Show(
                    "Ingreso correcto",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                InaugurarForm();
            }

            if (belGiftcardInternacional == null)
            {

                belGiftcardNacional.Saldo = Convert.ToInt32(ImporteImputadoTextBox.Text);
                belGiftcardNacional.Estado = "Activa";
                bllGiftcardNacional.Guardar(belGiftcardNacional);
                bllCliente.AsociarGiftcardNacional(belClienteDetallado, belGiftcardNacional);

                MessageBox.Show(
                    "Ingreso correcto",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                InaugurarForm();
            }
        }


        #region TEMPORAL (el código es demasiado largo, ¿debiera ser dividido?)
        private bool EsLibre(BEL.Cliente cliente)
        {
            bool respuesta = true;
            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Giftcard Tarj in cliente.Tarjeta)
                {
                    if (Tarj.Estado == "Libre") respuesta = false;
                }
            }
            return respuesta;
        }
        #endregion
    }
}
