using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;


namespace GCWinforms
{
    public partial class CampeonatosForm : MaterialForm
    {
        public CampeonatosForm(MaterialSkinManager msm)
        {
            InitializeComponent();

            // --- Material Skin ---------------
            MaterialSkinManager MSManager = msm;
            MSManager.AddFormToManage(this);
            // ---------------------------------
        }
    }
}
