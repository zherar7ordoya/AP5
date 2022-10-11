using Menpos.Domain.Models;
using Menpos.Persistence.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menpos.Presentation.UI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.CreatedAt = DateTime.Now;
            empresa.CreatedBy = "JMENDOZAJ";
            empresa.EstablecimientoId = 1;
            empresa.MonedaStandardId = 1;
            empresa.RFC = "ABCDRFSSD";
            empresa.NombreComercial = "Empresa SA DE CV";
            empresa.RazonSocial = "Empresa SA DE CV";


            using (var db = new UnitOfWork(new PosContext()))
            {
                db.Empresas.Add(empresa);
                db.Complete();

            }

        }
    }
}
