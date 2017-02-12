namespace OfflineARM.View.Views.Orders
{
    partial class OrderPartSpecificView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpSpecific = new System.Windows.Forms.TableLayoutPanel();
            this.tpSpecificDevideTree = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTableDevided = new System.Windows.Forms.TableLayoutPanel();
            this.tbChoiseFeatures = new DevExpress.XtraTab.XtraTabControl();
            this.tpOrderFeatures = new DevExpress.XtraTab.XtraTabPage();
            this.gcNomenclatureFeatures = new OfflineARM.View.Controls.GridControlWrapper();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpExpositionFeatures = new DevExpress.XtraTab.XtraTabPage();
            this.gcExposition = new OfflineARM.View.Controls.GridControlWrapper();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lcOrderHeader = new DevExpress.XtraEditors.LabelControl();
            this.gcOrderSpecifications = new OfflineARM.View.Controls.GridControlWrapper();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.treeList = new OfflineARM.View.Controls.TreeListWrapper();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tlpSpecific.SuspendLayout();
            this.tpSpecificDevideTree.SuspendLayout();
            this.tlpTableDevided.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChoiseFeatures)).BeginInit();
            this.tbChoiseFeatures.SuspendLayout();
            this.tpOrderFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomenclatureFeatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tpExpositionFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcExposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderSpecifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSpecific
            // 
            this.tlpSpecific.ColumnCount = 3;
            this.tlpSpecific.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSpecific.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.Controls.Add(this.tpSpecificDevideTree, 1, 1);
            this.tlpSpecific.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpecific.Location = new System.Drawing.Point(0, 0);
            this.tlpSpecific.Name = "tlpSpecific";
            this.tlpSpecific.RowCount = 3;
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.Size = new System.Drawing.Size(721, 505);
            this.tlpSpecific.TabIndex = 2;
            // 
            // tpSpecificDevideTree
            // 
            this.tpSpecificDevideTree.ColumnCount = 2;
            this.tpSpecificDevideTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tpSpecificDevideTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tpSpecificDevideTree.Controls.Add(this.tlpTableDevided, 1, 0);
            this.tpSpecificDevideTree.Controls.Add(this.treeList, 0, 0);
            this.tpSpecificDevideTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSpecificDevideTree.Location = new System.Drawing.Point(23, 23);
            this.tpSpecificDevideTree.Name = "tpSpecificDevideTree";
            this.tpSpecificDevideTree.RowCount = 1;
            this.tpSpecificDevideTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpSpecificDevideTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tpSpecificDevideTree.Size = new System.Drawing.Size(675, 459);
            this.tpSpecificDevideTree.TabIndex = 0;
            // 
            // tlpTableDevided
            // 
            this.tlpTableDevided.ColumnCount = 1;
            this.tlpTableDevided.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTableDevided.Controls.Add(this.tbChoiseFeatures, 0, 0);
            this.tlpTableDevided.Controls.Add(this.lcOrderHeader, 0, 1);
            this.tlpTableDevided.Controls.Add(this.gcOrderSpecifications, 0, 2);
            this.tlpTableDevided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTableDevided.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlpTableDevided.Location = new System.Drawing.Point(180, 3);
            this.tlpTableDevided.Name = "tlpTableDevided";
            this.tlpTableDevided.RowCount = 3;
            this.tlpTableDevided.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTableDevided.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTableDevided.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTableDevided.Size = new System.Drawing.Size(492, 453);
            this.tlpTableDevided.TabIndex = 1;
            // 
            // tbChoiseFeatures
            // 
            this.tbChoiseFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChoiseFeatures.Location = new System.Drawing.Point(3, 3);
            this.tbChoiseFeatures.Name = "tbChoiseFeatures";
            this.tbChoiseFeatures.SelectedTabPage = this.tpOrderFeatures;
            this.tbChoiseFeatures.Size = new System.Drawing.Size(486, 195);
            this.tbChoiseFeatures.TabIndex = 2;
            this.tbChoiseFeatures.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpOrderFeatures,
            this.tpExpositionFeatures});
            // 
            // tpOrderFeatures
            // 
            this.tpOrderFeatures.Controls.Add(this.gcNomenclatureFeatures);
            this.tpOrderFeatures.Name = "tpOrderFeatures";
            this.tpOrderFeatures.Size = new System.Drawing.Size(480, 167);
            this.tpOrderFeatures.Text = "Характеристики";
            // 
            // gcNomenclatureFeatures
            // 
            this.gcNomenclatureFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNomenclatureFeatures.Location = new System.Drawing.Point(0, 0);
            this.gcNomenclatureFeatures.MainView = this.gridView1;
            this.gcNomenclatureFeatures.Name = "gcNomenclatureFeatures";
            this.gcNomenclatureFeatures.Size = new System.Drawing.Size(480, 167);
            this.gcNomenclatureFeatures.TabIndex = 0;
            this.gcNomenclatureFeatures.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcNomenclatureFeatures;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tpExpositionFeatures
            // 
            this.tpExpositionFeatures.Controls.Add(this.gcExposition);
            this.tpExpositionFeatures.Name = "tpExpositionFeatures";
            this.tpExpositionFeatures.Size = new System.Drawing.Size(480, 167);
            this.tpExpositionFeatures.Text = "Экспозиция";
            // 
            // gcExposition
            // 
            this.gcExposition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExposition.Location = new System.Drawing.Point(0, 0);
            this.gcExposition.MainView = this.gridView3;
            this.gcExposition.Name = "gcExposition";
            this.gcExposition.Size = new System.Drawing.Size(480, 167);
            this.gcExposition.TabIndex = 0;
            this.gcExposition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcExposition;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // lcOrderHeader
            // 
            this.lcOrderHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcOrderHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lcOrderHeader.Location = new System.Drawing.Point(3, 225);
            this.lcOrderHeader.Name = "lcOrderHeader";
            this.lcOrderHeader.Size = new System.Drawing.Size(217, 23);
            this.lcOrderHeader.TabIndex = 3;
            this.lcOrderHeader.Text = "Спецификация заказа";
            // 
            // gcOrderSpecifications
            // 
            this.gcOrderSpecifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderSpecifications.Location = new System.Drawing.Point(3, 254);
            this.gcOrderSpecifications.MainView = this.gridView2;
            this.gcOrderSpecifications.Name = "gcOrderSpecifications";
            this.gcOrderSpecifications.Size = new System.Drawing.Size(486, 196);
            this.gcOrderSpecifications.TabIndex = 4;
            this.gcOrderSpecifications.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcOrderSpecifications;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // treeList
            // 
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(3, 3);
            this.treeList.Name = "treeList";
            this.treeList.Size = new System.Drawing.Size(171, 453);
            this.treeList.TabIndex = 2;
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // OrderSpecificControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSpecific);
            this.Name = "OrderSpecificControl";
            this.Size = new System.Drawing.Size(721, 505);
            this.tlpSpecific.ResumeLayout(false);
            this.tpSpecificDevideTree.ResumeLayout(false);
            this.tlpTableDevided.ResumeLayout(false);
            this.tlpTableDevided.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChoiseFeatures)).EndInit();
            this.tbChoiseFeatures.ResumeLayout(false);
            this.tpOrderFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNomenclatureFeatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tpExpositionFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcExposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderSpecifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSpecific;
        private System.Windows.Forms.TableLayoutPanel tpSpecificDevideTree;
        private Controls.TreeListWrapper treeList;
        private System.Windows.Forms.TableLayoutPanel tlpTableDevided;
        private DevExpress.XtraTab.XtraTabControl tbChoiseFeatures;
        private DevExpress.XtraTab.XtraTabPage tpOrderFeatures;
        private Controls.GridControlWrapper gcNomenclatureFeatures;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage tpExpositionFeatures;
        private Controls.GridControlWrapper gcExposition;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl lcOrderHeader;
        private Controls.GridControlWrapper gcOrderSpecifications;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}
