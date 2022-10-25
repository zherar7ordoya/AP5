using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace GCWinforms
{
    public partial class PremiosForm : MaterialForm
    {
        private readonly MaterialSkinManager MSManager;
        public PremiosForm()
        {
            InitializeComponent();

            // Material Skin para Winforms
            MSManager = MaterialSkinManager.Instance;
            MSManager.AddFormToManage(this);
            MSManager.Theme = MaterialSkinManager.Themes.LIGHT;
            MSManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }
    }
}
