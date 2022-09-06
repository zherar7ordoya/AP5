using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardsForm : Form
    {
        //APP-1
        BEL.Giftcard belGiftcard = new BEL.Giftcard();
        BLL.GiftcardInternacional bllGiftcardInternacional = new BLL.GiftcardInternacional();
        BLL.GiftcardNacional bllGiftcardNacional = new BLL.GiftcardNacional();
        BLL.DescuentoCalculado bllDescuentoCalculado = new BLL.DescuentoCalculado();
        List<BEL.GiftcardInternacional> ListaInternacionales = new List<BEL.GiftcardInternacional>();
        List<BEL.GiftcardNacional> ListaNacionales = new List<BEL.GiftcardNacional>();
        List<BEL.DescuentoCalculado> ListaDescuentos = new List<BEL.DescuentoCalculado>();

        #region *--------------------------------------------------=> SINGLETON
        private GiftcardsForm() => InitializeComponent();
        private static GiftcardsForm instancia = null;
        public static GiftcardsForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardsForm();
            return instancia;
        }

        private void AltaGitfcardButton_Click(object sender, EventArgs e)
        {
            GiftcardForm formulario = GiftcardForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK) MessageBox.Show("DialogResult: OK");
        }

        private void GiftcardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        #endregion


        //APP-3
        private void GiftcardsForm_Load(object sender, EventArgs e) => CargaInicial();

        private void CargaInicial()
        {
            this.InternacionalesDataGridView.DataSource = null;
            this.InternacionalesDataGridView.Rows.Clear();
            this.InternacionalesDataGridView.DataSource = bllGiftcardInternacional.Listar();
            this.InternacionalesDataGridView.Columns["Pais"].DisplayIndex = 2;

            this.NacionalesDataGridView.DataSource = null;
            this.NacionalesDataGridView.Rows.Clear();
            this.NacionalesDataGridView.DataSource = bllGiftcardNacional.Listar();
            this.NacionalesDataGridView.Columns["Provincia"].DisplayIndex = 2;

            GiftcardMenorSaldo();
            GiftcardMayorDescuento();
        }


        private void GiftcardMenorSaldo()
        {
            ListaInternacionales = bllGiftcardInternacional.Listar();
            ListaNacionales = bllGiftcardNacional.Listar();

            belGiftcard.Saldo = 999999;

            if (ListaInternacionales != null)
            {
                foreach (BEL.GiftcardInternacional item in ListaInternacionales)
                {
                    if (item.Saldo < belGiftcard.Saldo && item.Saldo != 0) belGiftcard = item;
                }
                InternacionalesMenorSaldoTextBox.Text = $"Gift Card {belGiftcard.Numero} || Saldo: {belGiftcard.Saldo:C}";
            }
            else { InternacionalesMenorSaldoTextBox.Text = "(Sin datos disponibles)"; }

            belGiftcard.Saldo = 999999;

            if (ListaNacionales != null)
            {
                foreach (BEL.GiftcardNacional item in ListaNacionales)
                {
                    if (item.Saldo < belGiftcard.Saldo && item.Saldo != 0) belGiftcard = item;
                }
                NacionalesMenorSaldoTextBox.Text = $"Gift Card {belGiftcard.Numero} || Saldo: {belGiftcard.Saldo:C}";
            }
            else { NacionalesMenorSaldoTextBox.Text = "(Sin datos disponibles)"; }
        }


        private void GiftcardMayorDescuento()
        {
            ListaDescuentos = bllDescuentoCalculado.Listar();
            double iDescuento = 0, nDescuento = 0;
            int iGiftcard = 0, nGiftcard = 0;

            if (ListaDescuentos != null)
            {
                foreach (BEL.DescuentoCalculado item in ListaDescuentos)
                {

                    if (item.Tipo == "Internacional")
                    {
                        if (iDescuento < item.DescuentoOtorgado)
                        {
                            iGiftcard = item.NumeroTarjeta;
                            iDescuento = item.DescuentoOtorgado;
                        }
                    }

                    if (item.Tipo == "Nacional")
                    {
                        if (nDescuento < item.DescuentoOtorgado)
                        {
                            nGiftcard = item.NumeroTarjeta;
                            nDescuento = item.DescuentoOtorgado;
                        }
                    }
                }
                InternacionalesMayorDescuentoTextBox.Text = $"Gift Card: {iGiftcard} || Descuento: {iDescuento:C}";
                NacionalesMayorDescuentoTextBox.Text = $"Gift Card: {nGiftcard} || Descuento: {nDescuento:C}";
            }
            else
            {
                InternacionalesMayorDescuentoTextBox.Text = "(Sin datos disponibles)";
                NacionalesMayorDescuentoTextBox.Text = "(Sin datos disponibles)";
            }
        }

        // *------------------------------------------=> FINALIZA CARGA INICIAL


        BEL.GiftcardInternacional belGiftcardInternacional = new BEL.GiftcardInternacional();
        BLL.GiftcardInternacional lgcGiftcardInternacional = new BLL.GiftcardInternacional();

        private void InternacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            belGiftcardInternacional = (BEL.GiftcardInternacional)this.InternacionalesDataGridView.CurrentRow.DataBoundItem;

            try
            {
                // ELIMINA
                if (e.ColumnIndex == 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Confirma eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (lgcGiftcardInternacional.Eliminar(belGiftcardInternacional) == false) MessageBox.Show("Registro asociado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        else { CargaInicial(); }
                    }
                }

                // EDITA
                if (e.ColumnIndex == 1)
                {
                    GiftcardForm formulario = new GiftcardForm();

                    formulario.CodigoTextBox.Text = belGiftcardInternacional.Codigo.ToString();
                    formulario.CodigoTextBox.Enabled = false;

                    formulario.NumeroTextBox.Text = belGiftcardInternacional.Numero.ToString();
                    formulario.FechaVencimientoDateTimePicker.Value = belGiftcardInternacional.Vencimiento;
                    formulario.RubroComboBox.Text = belGiftcardInternacional.Rubro.ToString();
                    formulario.PaisComboBox.Text = belGiftcardInternacional.Pais.ToString();

                    formulario.ProvinciaComboBox.Text = String.Empty;
                    formulario.ProvinciaComboBox.Enabled = false;

                    DialogResult respuesta = formulario.ShowDialog();
                    if (respuesta == DialogResult.OK) CargaInicial();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }


        BEL.GiftcardNacional belGiftcardNacional = new BEL.GiftcardNacional();
        BLL.GiftcardNacional lgcGiftcardNacional = new BLL.GiftcardNacional();

        private void NacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            belGiftcardNacional = (BEL.GiftcardNacional)this.NacionalesDataGridView.CurrentRow.DataBoundItem;

            try
            {
                // ELIMINA
                if (e.ColumnIndex == 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Confirma eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (lgcGiftcardNacional.Eliminar(belGiftcardNacional) == false) MessageBox.Show("Registro asociado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        else { CargaInicial(); }
                    }
                }

                // EDITA
                if (e.ColumnIndex == 1)
                {
                    GiftcardForm formulario = new GiftcardForm();

                    formulario.CodigoTextBox.Text = belGiftcardNacional.Codigo.ToString();
                    formulario.CodigoTextBox.Enabled = false;

                    formulario.NumeroTextBox.Text = belGiftcardNacional.Numero.ToString();
                    formulario.FechaVencimientoDateTimePicker.Value = belGiftcardNacional.Vencimiento;
                    formulario.RubroComboBox.Text = belGiftcardNacional.Rubro.ToString();
                    formulario.PaisComboBox.Text = belGiftcardNacional.Pais.ToString();
                    formulario.ProvinciaComboBox.Text = belGiftcardNacional.Provincia.ToString();

                    DialogResult respuesta = formulario.ShowDialog();
                    if (respuesta == DialogResult.OK) CargaInicial();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }
    }
}
