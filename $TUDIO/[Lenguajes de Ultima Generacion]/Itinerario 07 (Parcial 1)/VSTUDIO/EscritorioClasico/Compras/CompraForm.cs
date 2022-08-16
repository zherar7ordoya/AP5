/**
 * SIN USO.
 */


using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class CompraForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        public CompraForm() => InitializeComponent();
        private static CompraForm instancia = null;
        public static CompraForm Instancia()
        {
            if (instancia == null) instancia = new CompraForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********    }
    }
}
