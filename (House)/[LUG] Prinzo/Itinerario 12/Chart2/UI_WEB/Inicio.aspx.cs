using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI_WEB
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnArrays_Click(object sender, EventArgs e)
        {
            Response.Redirect("Arrays.aspx");
        }

        protected void btnDataView_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataView.aspx");
        }

        protected void btnTabla_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tabla.aspx");
        }

        protected void btnXML_Click(object sender, EventArgs e)
        {
            Response.Redirect("XML.aspx");
        }

        protected void btnImportExport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ImportExport.aspx");
        }

        protected void btnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lista.aspx");
        }
    }
}