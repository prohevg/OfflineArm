namespace OfflineARM.Gui.Forms.Orders
{
    partial class OrderClientControl
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rgClientType = new DevExpress.XtraEditors.RadioGroup();
            this.lcCaption = new DevExpress.XtraEditors.LabelControl();
            this.lkClient = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tePhone = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgClientType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClient.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.panelControl, 0, 0);
            this.tlpMain.Controls.Add(this.lkClient, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(753, 120);
            this.tlpMain.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.tableLayoutPanel2);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(747, 44);
            this.panelControl.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.rgClientType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lcCaption, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(743, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // rgClientType
            // 
            this.rgClientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rgClientType.Location = new System.Drawing.Point(123, 3);
            this.rgClientType.Name = "rgClientType";
            this.rgClientType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Физическое лицо"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Юридическое лицо")});
            this.rgClientType.Size = new System.Drawing.Size(327, 34);
            this.rgClientType.TabIndex = 1;
            // 
            // lcCaption
            // 
            this.lcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lcCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcCaption.Location = new System.Drawing.Point(3, 3);
            this.lcCaption.Name = "lcCaption";
            this.lcCaption.Size = new System.Drawing.Size(70, 23);
            this.lcCaption.TabIndex = 0;
            this.lcCaption.Text = "Клиент";
            // 
            // lkClient
            // 
            this.lkClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkClient.Location = new System.Drawing.Point(3, 53);
            this.lkClient.Name = "lkClient";
            this.lkClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Добавить", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.lkClient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Адрес")});
            this.lkClient.Size = new System.Drawing.Size(747, 20);
            this.lkClient.TabIndex = 1;
            this.lkClient.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lkClient_ButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tePhone, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.teAddress, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tePhone
            // 
            this.tePhone.EditValue = "";
            this.tePhone.Location = new System.Drawing.Point(600, 3);
            this.tePhone.Name = "tePhone";
            this.tePhone.Properties.Mask.EditMask = "(\\(\\d\\d\\d\\))?\\d{1,3}-\\d\\d-\\d\\d";
            this.tePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tePhone.Properties.NullText = "Телефон";
            this.tePhone.Size = new System.Drawing.Size(144, 20);
            this.tePhone.TabIndex = 2;
            // 
            // teAddress
            // 
            this.teAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teAddress.Location = new System.Drawing.Point(3, 3);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.NullText = "Адрес";
            this.teAddress.Size = new System.Drawing.Size(591, 20);
            this.teAddress.TabIndex = 3;
            // 
            // OrderClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "OrderClientControl";
            this.Size = new System.Drawing.Size(753, 120);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgClientType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClient.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.LabelControl lcCaption;
        private DevExpress.XtraEditors.RadioGroup rgClientType;
        private DevExpress.XtraEditors.LookUpEdit lkClient;
        private DevExpress.XtraEditors.TextEdit tePhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
