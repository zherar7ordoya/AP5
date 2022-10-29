using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace GCWinforms
{
    public partial class Formulario : MaterialForm
    {
        public Formulario(MaterialSkinManager msm)
        {
            InitializeComponent();

            // --- Material Skin ---------------
            MaterialSkinManager MSManager = msm;
            MSManager.AddFormToManage(this);
            // ---------------------------------
        }
    }
}
