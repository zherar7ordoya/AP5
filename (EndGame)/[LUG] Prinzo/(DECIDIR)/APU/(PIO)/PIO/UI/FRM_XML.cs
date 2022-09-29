using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace UI
{
    public partial class FRM_XML : Form
    {
        BE.BE_Auditoria BE_AUDITORIA;


        public FRM_XML()
        {
            InitializeComponent();
            BE_AUDITORIA = new BE.BE_Auditoria();
        }


        private void GenerarXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.Conexion conexion = new DAL.Conexion();
                var desde = DesdeDTP.Value;
                var hasta = HastaDTP.Value;

                DataTable dtabla = new DataTable();
                dtabla = conexion.ConsultaParaReporte(desde, hasta);
                dtabla.TableName = "Consulta";

                dtabla.WriteXml("AUDITORIA.XML");

                AuditoriaDGV.DataSource = null;
                AuditoriaDGV.DataSource = LeerConsultaXML();
                AuditoriaDGV.Columns["ID"].Visible = false;
                AuditoriaDGV.Columns["Total"].DefaultCellStyle.Format = "c";

                CargarComboBox();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private List<BE.BE_Auditoria> LeerConsultaXML()
        {
            List<BE.BE_Auditoria> listado = new List<BE.BE_Auditoria>();
            try
            {
                var consulta = from item
                           in XElement.Load("AUDITORIA.XML").Elements("Consulta")
                               select new BE.BE_Auditoria
                               {
                                   OrdenID = Convert.ToInt32(item.Element("OrdenID").Value),
                                   Fecha = Convert.ToDateTime(item.Element("Fecha").Value),
                                   Empleado = Convert.ToString(item.Element("Empleado").Value),
                                   Producto = Convert.ToString(item.Element("Producto").Value),
                                   Total = Convert.ToDecimal(item.Element("Total").Value)
                               };
                listado = consulta.ToList<BE.BE_Auditoria>();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return listado;
        }


        private void CargarComboBox()
        {
            try
            {
                XmlDocument archivo = new XmlDocument();
                archivo.Load("AUDITORIA.XML");
                XmlNodeList empleados = archivo.SelectNodes("DocumentElement/Consulta/Empleado");
                foreach (XmlNode empleado in empleados)
                {
                    EmpleadoComboBox.Items.Add(empleado.InnerText);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AuditoriaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (AuditoriaDGV.CurrentRow != null)
                {
                    BE_AUDITORIA = (BE.BE_Auditoria)AuditoriaDGV.CurrentRow.DataBoundItem;
                    ProductoTextBox.Text = BE_AUDITORIA.Producto;
                    RendidoTextBox.Text = BE_AUDITORIA.Total.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void EmpleadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AuditoriaDGV.DataSource = null;
                AuditoriaDGV.DataSource = FiltrarPorEmpleado();
                AuditoriaDGV.Columns["ID"].Visible = false;
                AuditoriaDGV.Columns["Total"].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private List<BE.BE_Auditoria> FiltrarPorEmpleado()
        {
            List<BE.BE_Auditoria> listado = new List<BE.BE_Auditoria>();
            try
            {
                var consulta = from item
                               in XElement.Load("AUDITORIA.XML").Elements("Consulta")
                               where (string)item.Element("Empleado") == EmpleadoComboBox.Text
                               select new BE.BE_Auditoria
                               {
                                   OrdenID = Convert.ToInt32(item.Element("OrdenID").Value),
                                   Fecha = Convert.ToDateTime(item.Element("Fecha").Value),
                                   Empleado = Convert.ToString(item.Element("Empleado").Value),
                                   Producto = Convert.ToString(item.Element("Producto").Value),
                                   Total = Convert.ToDecimal(item.Element("Total").Value)
                               };
                listado = consulta.ToList<BE.BE_Auditoria>();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return listado;
        }

        private void PlazaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(RendidoTextBox.Text))
            {
                try
                {
                    bool valida = Regex.IsMatch(PlazaTextBox.Text, "^([0-9]+$)");
                    if (valida)
                    {
                        decimal diferencia = Convert.ToDecimal(RendidoTextBox.Text) - Convert.ToDecimal(PlazaTextBox.Text);
                        DiferenciaTextBox.Text = diferencia.ToString("C");
                    }
                    else { MessageBox.Show("Solo números"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
