namespace GCWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RibbonMenu = new System.Windows.Forms.Ribbon();
            this.RibbonTab1 = new System.Windows.Forms.RibbonTab();
            this.RibbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.RibbonButton1 = new System.Windows.Forms.RibbonButton();
            this.RibbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // RibbonMenu
            // 
            this.RibbonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RibbonMenu.Location = new System.Drawing.Point(0, 0);
            this.RibbonMenu.Minimized = false;
            this.RibbonMenu.Name = "RibbonMenu";
            // 
            // 
            // 
            this.RibbonMenu.OrbDropDown.BorderRoundness = 8;
            this.RibbonMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.RibbonMenu.OrbDropDown.MenuItems.Add(this.RibbonOrbMenuItem1);
            this.RibbonMenu.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.RibbonMenu.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.RibbonMenu.OrbDropDown.Name = "";
            this.RibbonMenu.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.RibbonMenu.OrbDropDown.TabIndex = 0;
            this.RibbonMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.RibbonMenu.Size = new System.Drawing.Size(800, 146);
            this.RibbonMenu.TabIndex = 0;
            this.RibbonMenu.Tabs.Add(this.RibbonTab1);
            this.RibbonMenu.Text = "Menu Ribbon";
            // 
            // RibbonTab1
            // 
            this.RibbonTab1.Name = "RibbonTab1";
            this.RibbonTab1.Panels.Add(this.RibbonPanel1);
            this.RibbonTab1.Text = "Tab 1";
            // 
            // RibbonPanel1
            // 
            this.RibbonPanel1.Items.Add(this.RibbonButton1);
            this.RibbonPanel1.Name = "RibbonPanel1";
            this.RibbonPanel1.Text = "Panel 1";
            // 
            // RibbonButton1
            // 
            this.RibbonButton1.Image = global::GCWinforms.Properties.Resources.MasterDocument;
            this.RibbonButton1.LargeImage = global::GCWinforms.Properties.Resources.MasterDocument;
            this.RibbonButton1.Name = "RibbonButton1";
            this.RibbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton1.SmallImage")));
            this.RibbonButton1.Text = "Button 1";
            // 
            // RibbonOrbMenuItem1
            // 
            this.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.RibbonOrbMenuItem1.Image = global::GCWinforms.Properties.Resources.MasterPageView;
            this.RibbonOrbMenuItem1.LargeImage = global::GCWinforms.Properties.Resources.MasterPageView;
            this.RibbonOrbMenuItem1.Name = "RibbonOrbMenuItem1";
            this.RibbonOrbMenuItem1.SmallImage = global::GCWinforms.Properties.Resources.MasterPageView;
            this.RibbonOrbMenuItem1.Text = "Ribbon Orb 1";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = global::GCWinforms.Properties.Resources.MasterPageCloseEdit;
            this.ribbonOrbMenuItem2.LargeImage = global::GCWinforms.Properties.Resources.MasterPageCloseEdit;
            this.ribbonOrbMenuItem2.Name = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.SmallImage = global::GCWinforms.Properties.Resources.MasterPageCloseEdit;
            this.ribbonOrbMenuItem2.Text = "Ribbon Orb Menu 2";
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.Image")));
            this.ribbonOrbMenuItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.LargeImage")));
            this.ribbonOrbMenuItem3.Name = "ribbonOrbMenuItem3";
            this.ribbonOrbMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.SmallImage")));
            this.ribbonOrbMenuItem3.Text = "Ribbon Orb Item3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RibbonMenu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon RibbonMenu;
        private System.Windows.Forms.RibbonTab RibbonTab1;
        private System.Windows.Forms.RibbonPanel RibbonPanel1;
        private System.Windows.Forms.RibbonButton RibbonButton1;
        private System.Windows.Forms.RibbonOrbMenuItem RibbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem3;
    }
}