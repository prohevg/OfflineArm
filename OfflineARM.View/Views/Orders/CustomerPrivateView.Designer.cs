namespace OfflineARM.View.Views.Orders
{
    partial class CustomerPrivateView
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tePhone = new DevExpress.XtraEditors.TextEdit();
            this.lcFIO = new DevExpress.XtraEditors.LabelControl();
            this.lcAddress = new DevExpress.XtraEditors.LabelControl();
            this.lcPhone = new DevExpress.XtraEditors.LabelControl();
            this.teFio = new DevExpress.XtraEditors.TextEdit();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.daDataAddress = new OfflineARM.View.Controls.DaDataAddress();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFio.Properties)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tePhone, 1, 2);
            this.tlpMain.Controls.Add(this.lcFIO, 0, 0);
            this.tlpMain.Controls.Add(this.lcAddress, 0, 1);
            this.tlpMain.Controls.Add(this.lcPhone, 0, 2);
            this.tlpMain.Controls.Add(this.teFio, 1, 0);
            this.tlpMain.Controls.Add(this.tlpButtons, 1, 3);
            this.tlpMain.Controls.Add(this.daDataAddress, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(584, 142);
            this.tlpMain.TabIndex = 0;
            // 
            // tePhone
            // 
            this.tePhone.Location = new System.Drawing.Point(103, 65);
            this.tePhone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tePhone.Name = "tePhone";
            this.tePhone.Properties.Mask.EditMask = "(\\(\\d\\d\\d\\))?\\d{1,3}-\\d\\d-\\d\\d";
            this.tePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tePhone.Size = new System.Drawing.Size(154, 20);
            this.tePhone.TabIndex = 3;
            // 
            // lcFIO
            // 
            this.lcFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lcFIO.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcFIO.Location = new System.Drawing.Point(63, 5);
            this.lcFIO.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.lcFIO.Name = "lcFIO";
            this.lcFIO.Size = new System.Drawing.Size(27, 16);
            this.lcFIO.TabIndex = 0;
            this.lcFIO.Text = "ФИО";
            // 
            // lcAddress
            // 
            this.lcAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lcAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcAddress.Location = new System.Drawing.Point(55, 35);
            this.lcAddress.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(35, 16);
            this.lcAddress.TabIndex = 1;
            this.lcAddress.Text = "Адрес";
            // 
            // lcPhone
            // 
            this.lcPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lcPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcPhone.Location = new System.Drawing.Point(37, 65);
            this.lcPhone.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.lcPhone.Name = "lcPhone";
            this.lcPhone.Size = new System.Drawing.Size(53, 16);
            this.lcPhone.TabIndex = 2;
            this.lcPhone.Text = "Телефон";
            // 
            // teFio
            // 
            this.teFio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teFio.Location = new System.Drawing.Point(103, 5);
            this.teFio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.teFio.Name = "teFio";
            this.teFio.Size = new System.Drawing.Size(478, 20);
            this.teFio.TabIndex = 1;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.sbSave, 0, 0);
            this.tlpButtons.Controls.Add(this.sbCancel, 1, 0);
            this.tlpButtons.Location = new System.Drawing.Point(381, 94);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(200, 45);
            this.tlpButtons.TabIndex = 8;
            // 
            // sbSave
            // 
            this.sbSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbSave.Location = new System.Drawing.Point(3, 3);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(75, 23);
            this.sbSave.TabIndex = 4;
            this.sbSave.Text = "Сохранить";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(103, 3);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(75, 23);
            this.sbCancel.TabIndex = 5;
            this.sbCancel.Text = "Отмена";
            // 
            // daDataAddress
            // 
            this.daDataAddress.Address = null;
            this.daDataAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daDataAddress.Location = new System.Drawing.Point(103, 33);
            this.daDataAddress.Name = "daDataAddress";
            this.daDataAddress.Size = new System.Drawing.Size(478, 24);
            this.daDataAddress.TabIndex = 9;
            // 
            // CustomerPrivateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 142);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(600, 180);
            this.Name = "CustomerPrivateView";
            this.Text = "Новый клиент - физическое лицо";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFio.Properties)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DevExpress.XtraEditors.LabelControl lcFIO;
        private DevExpress.XtraEditors.LabelControl lcAddress;
        private DevExpress.XtraEditors.LabelControl lcPhone;
        private DevExpress.XtraEditors.TextEdit tePhone;
        private DevExpress.XtraEditors.TextEdit teFio;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private Controls.DaDataAddress daDataAddress;
    }
}