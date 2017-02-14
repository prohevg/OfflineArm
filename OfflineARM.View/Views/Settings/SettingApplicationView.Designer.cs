namespace OfflineARM.View.Views.Settings
{
    partial class SettingApplicationView
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
            this.bePathToDocuments = new DevExpress.XtraEditors.ButtonEdit();
            this.cbOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bePathToDocuments.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bePathToDocuments
            // 
            this.bePathToDocuments.EditValue = "Введите путь к документам";
            this.bePathToDocuments.Location = new System.Drawing.Point(150, 20);
            this.bePathToDocuments.Name = "bePathToDocuments";
            this.bePathToDocuments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bePathToDocuments.Size = new System.Drawing.Size(411, 20);
            this.bePathToDocuments.TabIndex = 0;
            this.bePathToDocuments.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bePathToDocuments_ButtonClick);
            // 
            // cbOk
            // 
            this.cbOk.Location = new System.Drawing.Point(388, 132);
            this.cbOk.Name = "cbOk";
            this.cbOk.Size = new System.Drawing.Size(75, 23);
            this.cbOk.TabIndex = 1;
            this.cbOk.Text = "Ок";
            this.cbOk.Click += new System.EventHandler(this.sbOk_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(486, 132);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(75, 23);
            this.sbCancel.TabIndex = 2;
            this.sbCancel.Text = "Отмена";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Папка для документов";
            // 
            // SettingApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sbCancel);
            this.Controls.Add(this.cbOk);
            this.Controls.Add(this.bePathToDocuments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingApplicationView";
            this.Text = "Настройки приложения";
            ((System.ComponentModel.ISupportInitialize)(this.bePathToDocuments.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit bePathToDocuments;
        private DevExpress.XtraEditors.SimpleButton cbOk;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
