using Abstract;
using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DetallePresupuesto : Form
    {
        PresupuestarAuto presupuestarAuto;
        BLLRol bllrol;
        public DetallePresupuesto()
        {
            InitializeComponent();
            presupuestarAuto = new PresupuestarAuto();
            bllrol = new BLLRol();
        }
        public Automovil Auto { get; set; }
        public Moto Moto { get; set; }         
        public bool Cambio { get; set; }
        public Desperfecto desperfec { get; set; }
        public Presupuesto presupes { get; set; }
        public decimal TotalRepuestos { get; set; }
        public Composite User { get; set; }
        public Usuario usuario { get; set; }

        private void DetallePresupuesto_Load(object sender, EventArgs e)
        {
            string rolear = "";
            lblCliente.Text = presupes.Nombre + " " + presupes.Apellido;
            if(Cambio == true)
            {
                lblPatente.Text = Auto.Patente;
                lblMarca.Text = Auto.Marca;
                lblModelo.Text = Auto.Modelo;
            }
            else if(Cambio == false)
            {
                lblPatente.Text = Moto.Patente;
                lblMarca.Text = Moto.Marca;
                lblModelo.Text = Moto.Modelo;
            }
            
            txtDesperfectos.ReadOnly = true;
            string s = desperfec.Descripcion;
            s = s.Replace("\n", "\r\n");
            txtDesperfectos.Text = s;
            lblManoDeObra.Text = desperfec.ManoDeObra.ToString();
            lblTotalRepuestos.Text = TotalRepuestos.ToString();
            lblTotalPresupuesto.Text = presupes.Total.ToString();
            foreach(Rol rol in bllrol.ListarTodo())
            {
                if(rol.IdRol == usuario.Rol)
                {
                    rolear = rol.Roll;
                }
            }
            lblusuario.Text = usuario.NombreUsuario + " --- " + rolear;
        }
    }
}
