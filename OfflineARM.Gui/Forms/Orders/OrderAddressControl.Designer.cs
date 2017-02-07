using OfflineARM.Gui.Controls;

namespace OfflineARM.Gui.Forms.Orders
{
    partial class OrderAddressControl
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lcDelivaryCaption = new DevExpress.XtraEditors.LabelControl();
            this.chIsSelf = new DevExpress.XtraEditors.CheckEdit();
            this.tlpHouse = new System.Windows.Forms.TableLayoutPanel();
            this.lcHouse = new DevExpress.XtraEditors.LabelControl();
            this.teHouse = new DevExpress.XtraEditors.TextEdit();
            this.teFlat = new DevExpress.XtraEditors.TextEdit();
            this.tePorch = new DevExpress.XtraEditors.TextEdit();
            this.teFloor = new DevExpress.XtraEditors.TextEdit();
            this.lkFlat = new DevExpress.XtraEditors.LabelControl();
            this.lkPorch = new DevExpress.XtraEditors.LabelControl();
            this.lkFloor = new DevExpress.XtraEditors.LabelControl();
            this.tlpIntercom = new System.Windows.Forms.TableLayoutPanel();
            this.ceClimb = new DevExpress.XtraEditors.CheckEdit();
            this.ceCargoLift = new DevExpress.XtraEditors.CheckEdit();
            this.teIntercom = new DevExpress.XtraEditors.TextEdit();
            this.lc = new DevExpress.XtraEditors.LabelControl();
            this.tlpPhones = new System.Windows.Forms.TableLayoutPanel();
            this.lkContPhone = new DevExpress.XtraEditors.LabelControl();
            this.teContactPersonName = new DevExpress.XtraEditors.TextEdit();
            this.lcAdditPhone = new DevExpress.XtraEditors.LabelControl();
            this.lсContactPersonName = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDateDelivery = new DevExpress.XtraEditors.LabelControl();
            this.deDeliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.meComment = new DevExpress.XtraEditors.MemoEdit();
            this.tlpAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lcAddress = new DevExpress.XtraEditors.LabelControl();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.teContactPhoneSecondary = new OfflineARM.Gui.Controls.PhoneControl();
            this.teContactPhoneMain = new OfflineARM.Gui.Controls.PhoneControl();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chIsSelf.Properties)).BeginInit();
            this.tlpHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFlat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePorch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFloor.Properties)).BeginInit();
            this.tlpIntercom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceClimb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCargoLift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIntercom.Properties)).BeginInit();
            this.tlpPhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teContactPersonName.Properties)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meComment.Properties)).BeginInit();
            this.tlpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactPhoneSecondary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactPhoneMain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.panelControl, 0, 0);
            this.tlpMain.Controls.Add(this.tlpHouse, 0, 2);
            this.tlpMain.Controls.Add(this.tlpIntercom, 0, 3);
            this.tlpMain.Controls.Add(this.tlpPhones, 0, 4);
            this.tlpMain.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tlpMain.Controls.Add(this.meComment, 0, 6);
            this.tlpMain.Controls.Add(this.tlpAddress, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(918, 456);
            this.tlpMain.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.tableLayoutPanel1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(912, 44);
            this.panelControl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lcDelivaryCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chIsSelf, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lcDelivaryCaption
            // 
            this.lcDelivaryCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lcDelivaryCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcDelivaryCaption.Location = new System.Drawing.Point(3, 7);
            this.lcDelivaryCaption.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lcDelivaryCaption.Name = "lcDelivaryCaption";
            this.lcDelivaryCaption.Size = new System.Drawing.Size(92, 23);
            this.lcDelivaryCaption.TabIndex = 0;
            this.lcDelivaryCaption.Text = "Доставка";
            // 
            // chIsSelf
            // 
            this.chIsSelf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chIsSelf.Location = new System.Drawing.Point(120, 9);
            this.chIsSelf.Margin = new System.Windows.Forms.Padding(20, 9, 3, 3);
            this.chIsSelf.Name = "chIsSelf";
            this.chIsSelf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chIsSelf.Properties.Appearance.Options.UseFont = true;
            this.chIsSelf.Properties.Caption = "Самовывоз";
            this.chIsSelf.Size = new System.Drawing.Size(132, 23);
            this.chIsSelf.TabIndex = 1;
            // 
            // tlpHouse
            // 
            this.tlpHouse.ColumnCount = 11;
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpHouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHouse.Controls.Add(this.lcHouse, 0, 0);
            this.tlpHouse.Controls.Add(this.teHouse, 1, 0);
            this.tlpHouse.Controls.Add(this.teIntercom, 9, 0);
            this.tlpHouse.Controls.Add(this.teFlat, 3, 0);
            this.tlpHouse.Controls.Add(this.lc, 8, 0);
            this.tlpHouse.Controls.Add(this.lkFlat, 2, 0);
            this.tlpHouse.Controls.Add(this.lkFloor, 4, 0);
            this.tlpHouse.Controls.Add(this.teFloor, 5, 0);
            this.tlpHouse.Controls.Add(this.lkPorch, 6, 0);
            this.tlpHouse.Controls.Add(this.tePorch, 7, 0);
            this.tlpHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlpHouse.Location = new System.Drawing.Point(3, 83);
            this.tlpHouse.Name = "tlpHouse";
            this.tlpHouse.RowCount = 1;
            this.tlpHouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHouse.Size = new System.Drawing.Size(912, 24);
            this.tlpHouse.TabIndex = 1;
            // 
            // lcHouse
            // 
            this.lcHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcHouse.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcHouse.Location = new System.Drawing.Point(23, 3);
            this.lcHouse.Name = "lcHouse";
            this.lcHouse.Size = new System.Drawing.Size(24, 16);
            this.lcHouse.TabIndex = 21;
            this.lcHouse.Text = "Дом";
            // 
            // teHouse
            // 
            this.teHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teHouse.Location = new System.Drawing.Point(53, 3);
            this.teHouse.Name = "teHouse";
            this.teHouse.Properties.MaxLength = 10;
            this.teHouse.Size = new System.Drawing.Size(69, 20);
            this.teHouse.TabIndex = 1;
            // 
            // teFlat
            // 
            this.teFlat.Location = new System.Drawing.Point(208, 3);
            this.teFlat.Name = "teFlat";
            this.teFlat.Properties.MaxLength = 5;
            this.teFlat.Size = new System.Drawing.Size(69, 20);
            this.teFlat.TabIndex = 2;
            // 
            // tePorch
            // 
            this.tePorch.Location = new System.Drawing.Point(458, 3);
            this.tePorch.Name = "tePorch";
            this.tePorch.Properties.MaxLength = 5;
            this.tePorch.Size = new System.Drawing.Size(44, 20);
            this.tePorch.TabIndex = 3;
            // 
            // teFloor
            // 
            this.teFloor.Location = new System.Drawing.Point(333, 3);
            this.teFloor.Name = "teFloor";
            this.teFloor.Properties.MaxLength = 5;
            this.teFloor.Size = new System.Drawing.Size(44, 20);
            this.teFloor.TabIndex = 4;
            // 
            // lkFlat
            // 
            this.lkFlat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkFlat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lkFlat.Location = new System.Drawing.Point(147, 3);
            this.lkFlat.Name = "lkFlat";
            this.lkFlat.Size = new System.Drawing.Size(55, 16);
            this.lkFlat.TabIndex = 6;
            this.lkFlat.Text = "Квартира";
            // 
            // lkPorch
            // 
            this.lkPorch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkPorch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lkPorch.Location = new System.Drawing.Point(403, 3);
            this.lkPorch.Name = "lkPorch";
            this.lkPorch.Size = new System.Drawing.Size(49, 16);
            this.lkPorch.TabIndex = 7;
            this.lkPorch.Text = "Подъезд";
            // 
            // lkFloor
            // 
            this.lkFloor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkFloor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lkFloor.Location = new System.Drawing.Point(296, 3);
            this.lkFloor.Name = "lkFloor";
            this.lkFloor.Size = new System.Drawing.Size(31, 16);
            this.lkFloor.TabIndex = 8;
            this.lkFloor.Text = "Этаж";
            // 
            // tlpIntercom
            // 
            this.tlpIntercom.ColumnCount = 3;
            this.tlpIntercom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpIntercom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpIntercom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIntercom.Controls.Add(this.ceClimb, 0, 0);
            this.tlpIntercom.Controls.Add(this.ceCargoLift, 1, 0);
            this.tlpIntercom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIntercom.Location = new System.Drawing.Point(3, 113);
            this.tlpIntercom.Name = "tlpIntercom";
            this.tlpIntercom.RowCount = 1;
            this.tlpIntercom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIntercom.Size = new System.Drawing.Size(912, 24);
            this.tlpIntercom.TabIndex = 2;
            // 
            // ceClimb
            // 
            this.ceClimb.Location = new System.Drawing.Point(3, 3);
            this.ceClimb.Name = "ceClimb";
            this.ceClimb.Properties.Caption = "Подъем";
            this.ceClimb.Size = new System.Drawing.Size(75, 19);
            this.ceClimb.TabIndex = 0;
            // 
            // ceCargoLift
            // 
            this.ceCargoLift.Location = new System.Drawing.Point(123, 3);
            this.ceCargoLift.Name = "ceCargoLift";
            this.ceCargoLift.Properties.Caption = "Грузовой лифт";
            this.ceCargoLift.Size = new System.Drawing.Size(108, 19);
            this.ceCargoLift.TabIndex = 1;
            // 
            // teIntercom
            // 
            this.teIntercom.Location = new System.Drawing.Point(583, 3);
            this.teIntercom.Name = "teIntercom";
            this.teIntercom.Properties.MaxLength = 10;
            this.teIntercom.Size = new System.Drawing.Size(69, 20);
            this.teIntercom.TabIndex = 5;
            // 
            // lc
            // 
            this.lc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lc.Location = new System.Drawing.Point(522, 3);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(55, 16);
            this.lc.TabIndex = 6;
            this.lc.Text = "Домофон";
            // 
            // tlpPhones
            // 
            this.tlpPhones.ColumnCount = 6;
            this.tlpPhones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPhones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPhones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPhones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPhones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpPhones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhones.Controls.Add(this.lkContPhone, 0, 0);
            this.tlpPhones.Controls.Add(this.teContactPersonName, 5, 0);
            this.tlpPhones.Controls.Add(this.teContactPhoneSecondary, 3, 0);
            this.tlpPhones.Controls.Add(this.teContactPhoneMain, 1, 0);
            this.tlpPhones.Controls.Add(this.lcAdditPhone, 2, 0);
            this.tlpPhones.Controls.Add(this.lсContactPersonName, 4, 0);
            this.tlpPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPhones.Location = new System.Drawing.Point(3, 143);
            this.tlpPhones.Name = "tlpPhones";
            this.tlpPhones.RowCount = 1;
            this.tlpPhones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhones.Size = new System.Drawing.Size(912, 24);
            this.tlpPhones.TabIndex = 3;
            // 
            // lkContPhone
            // 
            this.lkContPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkContPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lkContPhone.Location = new System.Drawing.Point(11, 3);
            this.lkContPhone.Name = "lkContPhone";
            this.lkContPhone.Size = new System.Drawing.Size(86, 16);
            this.lkContPhone.TabIndex = 6;
            this.lkContPhone.Text = "Конт. телефон";
            // 
            // teContactPersonName
            // 
            this.teContactPersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teContactPersonName.Location = new System.Drawing.Point(478, 3);
            this.teContactPersonName.Name = "teContactPersonName";
            this.teContactPersonName.Size = new System.Drawing.Size(431, 20);
            this.teContactPersonName.TabIndex = 8;
            // 
            // lcAdditPhone
            // 
            this.lcAdditPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcAdditPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcAdditPhone.Location = new System.Drawing.Point(215, 3);
            this.lcAdditPhone.Name = "lcAdditPhone";
            this.lcAdditPhone.Size = new System.Drawing.Size(82, 16);
            this.lcAdditPhone.TabIndex = 7;
            this.lcAdditPhone.Text = "Доп. телефон";
            // 
            // lсContactPersonName
            // 
            this.lсContactPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lсContactPersonName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lсContactPersonName.Location = new System.Drawing.Point(409, 3);
            this.lсContactPersonName.Name = "lсContactPersonName";
            this.lсContactPersonName.Size = new System.Drawing.Size(63, 16);
            this.lсContactPersonName.TabIndex = 8;
            this.lсContactPersonName.Text = "Конт. лицо";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lbDateDelivery, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deDeliveryDate, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 173);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(912, 24);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // lbDateDelivery
            // 
            this.lbDateDelivery.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDateDelivery.Location = new System.Drawing.Point(3, 3);
            this.lbDateDelivery.Name = "lbDateDelivery";
            this.lbDateDelivery.Size = new System.Drawing.Size(86, 16);
            this.lbDateDelivery.TabIndex = 0;
            this.lbDateDelivery.Text = "Дата доставки";
            // 
            // deDeliveryDate
            // 
            this.deDeliveryDate.EditValue = null;
            this.deDeliveryDate.Location = new System.Drawing.Point(103, 3);
            this.deDeliveryDate.Name = "deDeliveryDate";
            this.deDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDeliveryDate.Properties.NullText = "Дата";
            this.deDeliveryDate.Size = new System.Drawing.Size(131, 20);
            this.deDeliveryDate.TabIndex = 9;
            // 
            // meComment
            // 
            this.meComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meComment.Location = new System.Drawing.Point(3, 203);
            this.meComment.Name = "meComment";
            this.meComment.Properties.NullText = "Комментарий";
            this.meComment.Size = new System.Drawing.Size(912, 250);
            this.meComment.TabIndex = 10;
            this.meComment.UseOptimizedRendering = true;
            // 
            // tlpAddress
            // 
            this.tlpAddress.ColumnCount = 2;
            this.tlpAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Controls.Add(this.lcAddress, 0, 0);
            this.tlpAddress.Controls.Add(this.teAddress, 1, 0);
            this.tlpAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddress.Location = new System.Drawing.Point(3, 53);
            this.tlpAddress.Name = "tlpAddress";
            this.tlpAddress.RowCount = 1;
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Size = new System.Drawing.Size(912, 24);
            this.tlpAddress.TabIndex = 6;
            // 
            // lcAddress
            // 
            this.lcAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcAddress.Location = new System.Drawing.Point(12, 3);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(35, 16);
            this.lcAddress.TabIndex = 20;
            this.lcAddress.Text = "Адрес";
            // 
            // teAddress
            // 
            this.teAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teAddress.Location = new System.Drawing.Point(53, 3);
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(856, 20);
            this.teAddress.TabIndex = 0;
            // 
            // teContactPhoneSecondary
            // 
            this.teContactPhoneSecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teContactPhoneSecondary.Location = new System.Drawing.Point(303, 3);
            this.teContactPhoneSecondary.Name = "teContactPhoneSecondary";
            this.teContactPhoneSecondary.Size = new System.Drawing.Size(94, 20);
            this.teContactPhoneSecondary.TabIndex = 7;
            // 
            // teContactPhoneMain
            // 
            this.teContactPhoneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teContactPhoneMain.Location = new System.Drawing.Point(103, 3);
            this.teContactPhoneMain.Name = "teContactPhoneMain";
            this.teContactPhoneMain.Size = new System.Drawing.Size(94, 20);
            this.teContactPhoneMain.TabIndex = 6;
            // 
            // OrderAddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "OrderAddressControl";
            this.Size = new System.Drawing.Size(918, 456);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chIsSelf.Properties)).EndInit();
            this.tlpHouse.ResumeLayout(false);
            this.tlpHouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFlat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePorch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFloor.Properties)).EndInit();
            this.tlpIntercom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceClimb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCargoLift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIntercom.Properties)).EndInit();
            this.tlpPhones.ResumeLayout(false);
            this.tlpPhones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teContactPersonName.Properties)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meComment.Properties)).EndInit();
            this.tlpAddress.ResumeLayout(false);
            this.tlpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactPhoneSecondary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactPhoneMain.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lcDelivaryCaption;
        private DevExpress.XtraEditors.CheckEdit chIsSelf;
        private System.Windows.Forms.TableLayoutPanel tlpHouse;
        private DevExpress.XtraEditors.TextEdit teHouse;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.TextEdit tePorch;
        private DevExpress.XtraEditors.TextEdit teFloor;
        private DevExpress.XtraEditors.TextEdit teFlat;
        private System.Windows.Forms.TableLayoutPanel tlpIntercom;
        private DevExpress.XtraEditors.CheckEdit ceClimb;
        private DevExpress.XtraEditors.CheckEdit ceCargoLift;
        private DevExpress.XtraEditors.TextEdit teIntercom;
        private System.Windows.Forms.TableLayoutPanel tlpPhones;
        private DevExpress.XtraEditors.TextEdit teContactPersonName;
        private PhoneControl teContactPhoneSecondary;
        private PhoneControl teContactPhoneMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LabelControl lbDateDelivery;
        private DevExpress.XtraEditors.DateEdit deDeliveryDate;
        private DevExpress.XtraEditors.MemoEdit meComment;
        private DevExpress.XtraEditors.LabelControl lcHouse;
        private System.Windows.Forms.TableLayoutPanel tlpAddress;
        private DevExpress.XtraEditors.LabelControl lcAddress;
        private DevExpress.XtraEditors.LabelControl lkFlat;
        private DevExpress.XtraEditors.LabelControl lkPorch;
        private DevExpress.XtraEditors.LabelControl lkFloor;
        private DevExpress.XtraEditors.LabelControl lkContPhone;
        private DevExpress.XtraEditors.LabelControl lcAdditPhone;
        private DevExpress.XtraEditors.LabelControl lсContactPersonName;
        private DevExpress.XtraEditors.LabelControl lc;
    }
}
