using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class ComprasForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ComprasForm() => InitializeComponent();
        private static ComprasForm instancia = null;
        public static ComprasForm Instancia()
        {
            if (instancia == null) instancia = new ComprasForm();
            return instancia;
        }
        private void ComprasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        // *----------------------------------------------------=> INAUGURACIÓN

        private void ComprasForm_Load(object sender, EventArgs e) => InaugurarForm();

        BLL.Cliente bllCliente = new BLL.Cliente();
        BEL.Cliente belCliente = new BEL.Cliente();

        private void InaugurarForm()
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = bllCliente.Listar();
        }
        
        
        private void ClientesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente cliente = bllCliente.Detallar(belCliente);
            BEL.Giftcard giftcard = new BEL.Giftcard();

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Giftcard item in cliente.Tarjeta)
                {
                    if (item.Estado == "Alta") giftcard = item;
                }
            }

            if (giftcard != null)
            {
                GiftcardTextBox.Text = giftcard.Numero.ToString();
                SaldoTextBox.Text = giftcard.Saldo.ToString();
            }
            else
            {
                LimpiarTextBoxes();
            }
        }


        private void LimpiarTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox box) box.Text = string.Empty;
            }
        }


        BEL.GiftcardInternacional belGiftcardInternacional = new BEL.GiftcardInternacional();
        BEL.GiftcardNacional belGiftcardNacional = new BEL.GiftcardNacional();
        BLL.GiftcardInternacional bllGiftcardInternacional = new BLL.GiftcardInternacional();
        BLL.GiftcardNacional bllGiftcardNacional = new BLL.GiftcardNacional();
        BEL.DescuentoCalculado belDescuento = new BEL.DescuentoCalculado();
        BLL.DescuentoCalculado bllDescuento = new BLL.DescuentoCalculado();

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            BEL.Cliente belClienteAux = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            belCliente = bllCliente.Detallar(belCliente);
            BEL.Giftcard giftcard = new BEL.Giftcard();

            if (belCliente.Tarjeta != null)
            {
                foreach (BEL.Giftcard item in belCliente.Tarjeta)
                {
                    if (item.Estado == "Alta") giftcard = item;
                }
            }

            if (giftcard == null)
            {
                string message = "Cliente sin Gift Card asignada";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error);
                return;
            }

            int compra = Convert.ToInt32(ImporteCompraTextBox.Text);
            int saldo = Convert.ToInt32(SaldoTextBox.Text);

            if (compra > saldo)
            {
                string message = "Saldo insuficiente";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error);
                return;
            }

            List<BEL.GiftcardInternacional> ListaInternacionales = bllGiftcardInternacional.Listar();
            List<BEL.GiftcardNacional> ListaNacionales = bllGiftcardNacional.Listar();

            foreach (BEL.GiftcardInternacional item in ListaInternacionales)
            {
                if (giftcard.Codigo == item.Codigo) belGiftcardInternacional = item;
            }

            foreach (BEL.GiftcardNacional item in ListaNacionales)
            {
                if (giftcard.Codigo == item.Codigo) belGiftcardNacional = item;
            }

            if (belGiftcardInternacional != null)
            {
                belDescuento.DescuentoOtorgado = bllGiftcardInternacional.ObtenerDescuento(compra);
                belDescuento.NumeroTarjeta = belGiftcardInternacional.Numero;
                belDescuento.Tipo = "Internacional";
                bllDescuento.Guardar(belDescuento);
                belGiftcardInternacional.Saldo = belGiftcardInternacional.Saldo - compra;
                if (belGiftcardInternacional.Saldo == 0) belGiftcardInternacional.Estado = "Sin Saldo";
                bllGiftcardInternacional.Guardar(belGiftcardInternacional);
            }
            else if (belGiftcardNacional != null) // Era esto o hacer NULL a belGiftcardNacional...
            {
                belDescuento.DescuentoOtorgado = bllGiftcardNacional.ObtenerDescuento(compra);
                belDescuento.NumeroTarjeta = belGiftcardNacional.Numero;
                belDescuento.Tipo = "Nacional";
                bllDescuento.Guardar(belDescuento);
                belGiftcardNacional.Saldo = belGiftcardNacional.Saldo - compra;
                if (belGiftcardNacional.Saldo == 0) belGiftcardNacional.Estado = "Sin Saldo";
                bllGiftcardNacional.Guardar(belGiftcardNacional);
            }

            MessageBox.Show(
                "Todo correcto",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarTextBoxes();
            InaugurarForm();
        }
    }
}
