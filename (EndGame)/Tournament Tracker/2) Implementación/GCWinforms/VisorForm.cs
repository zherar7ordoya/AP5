using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace GCWinforms
{
    public partial class VisorForm : MaterialForm
    {
        public VisorForm(MaterialSkinManager msm)
        {
            InitializeComponent();

            // --- Material Skin ---------------
            MaterialSkinManager MSManager = msm;
            MSManager.AddFormToManage(this);
            // ---------------------------------
        }
    }
}
