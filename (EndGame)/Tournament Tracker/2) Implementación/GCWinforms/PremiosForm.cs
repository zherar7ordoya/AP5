﻿using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace GCWinforms
{
    public partial class PremiosForm : MaterialForm
    {
        public PremiosForm(MaterialSkinManager msm)
        {
            InitializeComponent();

            // --- Material Skin ---------------
            MaterialSkinManager MSManager = msm;
            MSManager.AddFormToManage(this);
            // ---------------------------------
        }
    }
}
