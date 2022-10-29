using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace GCWinforms
{
    public partial class TableroForm : MaterialForm
    {
        public TableroForm(MaterialSkinManager msm)
        {
            InitializeComponent();

            // --- Material Skin ---------------
            MaterialSkinManager MSManager = msm;
            MSManager.AddFormToManage(this);
            // ---------------------------------
        }
    }
}
