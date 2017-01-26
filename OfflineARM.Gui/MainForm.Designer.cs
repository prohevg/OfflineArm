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
            this.biOrderAdd = new DevExpress.XtraBars.BarButtonItem();
            this.rpOrders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgOrders = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpExpo = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpHelps = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controller = this.barAndDockingController1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biOrderAdd});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
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
            // biOrderAdd
            // 
            this.biOrderAdd.Caption = "Добавить";
            this.biOrderAdd.Glyph = global::OfflineARM.Gui.GuiResource.add_32x32;
            this.biOrderAdd.Id = 3;
            this.biOrderAdd.Name = "biOrderAdd";
            this.biOrderAdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // rpOrders
            // 
            this.rpOrders.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgOrders});
            this.rpOrders.Name = "rpOrders";
            this.rpOrders.Text = "Заказы";
            // 
            // rpgOrders
            // 
            this.rpgOrders.ItemLinks.Add(this.biOrderAdd);
            this.rpgOrders.Name = "rpgOrders";
            this.rpgOrders.Text = "Действия";
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
            // gcOrders
            // 
            this.gcOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrders.Location = new System.Drawing.Point(0, 144);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(686, 259);
            this.gcOrders.TabIndex = 1;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders});
            // 
            // gvOrders
            // 
            this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNumber,
            this.gcDateCreate,
            this.gcStatus,
            this.gcName});
            this.gvOrders.GridControl = this.gcOrders;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.OptionsView.ShowAutoFilterRow = true;
            this.gvOrders.OptionsView.ShowDetailButtons = false;
            this.gvOrders.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvOrders.OptionsView.ShowGroupPanel = false;
            // 
            // gcNumber
            // 
            this.gcNumber.Caption = "Номер";
            this.gcNumber.FieldName = "Number";
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.Visible = true;
            this.gcNumber.VisibleIndex = 0;
            // 
            // gcDateCreate
            // 
            this.gcDateCreate.Caption = "Дата";
            this.gcDateCreate.FieldName = "DateCreate";
            this.gcDateCreate.Name = "gcDateCreate";
            this.gcDateCreate.Visible = true;
            this.gcDateCreate.VisibleIndex = 1;
            // 
            // gcStatus
            // 
            this.gcStatus.Caption = "Статус";
            this.gcStatus.FieldName = "Status";
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.Visible = true;
            this.gcStatus.VisibleIndex = 2;
            // 
            // gcName
            // 
            this.gcName.Caption = "Наименование";
            this.gcName.FieldName = "Name";
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.gcOrders);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOrders;
        private DevExpress.XtraBars.BarButtonItem biOrderAdd;
        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn gcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
    }
}