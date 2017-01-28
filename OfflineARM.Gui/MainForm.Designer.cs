namespace OfflineARM.Gui
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.rpOrders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpExpo = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpHelps = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controller = this.barAndDockingController1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpOrders,
            this.rpExpo,
            this.rpSettings,
            this.rpHelps});
            this.ribbonControl1.Size = new System.Drawing.Size(686, 144);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinName = "Office 2013";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // rpOrders
            // 
            this.rpOrders.Name = "rpOrders";
            this.rpOrders.Text = "Заказы";
            // 
            // rpExpo
            // 
            this.rpExpo.Name = "rpExpo";
            this.rpExpo.Text = "Экспозиция";
            // 
            // rpSettings
            // 
            this.rpSettings.Name = "rpSettings";
            this.rpSettings.Text = "Настройки";
            // 
            // rpHelps
            // 
            this.rpHelps.Name = "rpHelps";
            this.rpHelps.Text = "Помощь";
            // 
            // panelControl
            // 
            this.panelControl.AutoSize = true;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 144);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(686, 259);
            this.panelControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpOrders;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpExpo;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHelps;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraEditors.PanelControl panelControl;
    }
}