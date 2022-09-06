using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Listas2
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        List<ClsCliente> LcliInformes = new List<ClsCliente>();
        double MontoTotalDebito = 0;
        double MontoTotalCredito = 0;

        ClsCliente oCliInfo = new ClsCliente();
        private void frmInformes_Load(object sender, EventArgs e)
        {
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oCliInfo.Informar = CalcularFDPDebito;
        }


        void CalcularFDPDebito(List<ClsCliente> Lcli)
        {
           
            foreach (ClsCliente item in Lcli)
            {
                if (item.oFPago.Forma == "Debito")
                {
                    foreach (ClsPaquete item2 in item.LPaquetes)
                    { MontoTotalDebito += item2.Abono; }
                }
            }
            label2.Text = MontoTotalDebito.ToString();
        
        }

        void CalcularFDCredito(List<ClsCliente> Lcli)
        {

            foreach (ClsCliente item in Lcli)
            {
                if (item.oFPago.Forma == "Credito")
                {
                    foreach (ClsPaquete item2 in item.LPaquetes)
                    { MontoTotalCredito += item2.Abono; }
                }
            }
            label2.Text = MontoTotalCredito.ToString();

        }


        void CalcularTotal(List<ClsCliente> Lcli)
        {

            foreach (ClsCliente item in Lcli)
            {
                if (item.oFPago.Forma == "Credito")
                {
                    foreach (ClsPaquete item2 in item.LPaquetes)
                    { MontoTotalCredito += item2.Abono; }
                }
            }

            foreach (ClsCliente item in Lcli)
            {
                if (item.oFPago.Forma == "Debito")
                {
                    foreach (ClsPaquete item2 in item.LPaquetes)
                    { MontoTotalDebito += item2.Abono; }
                }
            }

            double Total = MontoTotalCredito + MontoTotalDebito;
            label2.Text = Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oCliInfo.Informar(frmClientePack.LsClientes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oCliInfo.Informar = CalcularFDCredito;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oCliInfo.Informar = CalcularTotal;
        }
    }
}
