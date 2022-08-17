using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmdg : Form
    {
        public frmdg()
        {
            InitializeComponent();
        }

        ClsPersona oPersona = new ClsPersona();
        ClsPersona oPersona1 = new ClsPersona();
        ClsPersona oPersona2 = new ClsPersona();
        List<ClsPersona> LstPeronas = new List<ClsPersona>();
        private void frmdg_Load(object sender, EventArgs e)
        {
            oPersona.NOmbre = "Juan";
            oPersona.Apellido = "Perez";
            oPersona.edad = 45;
            LstPeronas.Add(oPersona);

            oPersona1.NOmbre = "Lorena";
            oPersona1.Apellido = "Garcia";
            oPersona1.edad = 25;
            LstPeronas.Add(oPersona1);

            oPersona2.NOmbre = "Daniel";
            oPersona2.Apellido = "Marin";
            oPersona2.edad = 45;
            LstPeronas.Add(oPersona2);

            cargargrilla();
        }

        void cargargrilla()
        {
            uC_dg1.dgGenerica.DataSource = null;
            uC_dg1.dgGenerica.DataSource = LstPeronas;
        }
    }
}
