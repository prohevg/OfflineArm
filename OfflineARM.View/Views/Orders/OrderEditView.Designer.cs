namespace OfflineARM.View.Views.Orders
{
    partial class OrderEditView
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
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpSpecific = new DevExpress.XtraTab.XtraTabPage();
            this.tpDelivary = new DevExpress.XtraTab.XtraTabPage();
            this.tpBuy = new DevExpress.XtraTab.XtraTabPage();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.sbPrevios = new DevExpress.XtraEditors.SimpleButton();
            this.sbNext = new DevExpress.XtraEditors.SimpleButton();
            this.tlpResponsable = new System.Windows.Forms.TableLayoutPanel();
            this.lcResponsable = new DevExpress.XtraEditors.LabelControl();
            this.gcSumms = new DevExpress.XtraEditors.GroupControl();
            this.lcBalance = new DevExpress.XtraEditors.LabelControl();
            this.lcAmountPayment = new DevExpress.XtraEditors.LabelControl();
            this.lcAmountOrder = new DevExpress.XtraEditors.LabelControl();
            this.lueResponsiable = new DevExpress.XtraEditors.LookUpEdit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpResponsable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSumms)).BeginInit();
            this.gcSumms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueResponsiable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tcMain, 1, 1);
            this.tlpMain.Controls.Add(this.tlpButtons, 1, 2);
            this.tlpMain.Controls.Add(this.tlpResponsable, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMain.Size = new System.Drawing.Size(1008, 730);
            this.tlpMain.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(23, 33);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpSpecific;
            this.tcMain.Size = new System.Drawing.Size(962, 619);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSpecific,
            this.tpDelivary,
            this.tpBuy});
            // 
            // tpSpecific
            // 
            this.tpSpecific.Name = "tpSpecific";
            this.tpSpecific.Size = new System.Drawing.Size(956, 591);
            this.tpSpecific.Text = "Спецификация";
            // 
            // tpDelivary
            // 
            this.tpDelivary.Name = "tpDelivary";
            this.tpDelivary.Size = new System.Drawing.Size(956, 616);
            this.tpDelivary.Text = "Доставка";
            // 
            // tpBuy
            // 
            this.tpBuy.Name = "tpBuy";
            this.tpBuy.Size = new System.Drawing.Size(956, 616);
            this.tpBuy.Text = "Оплата";
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.sbPrevios, 0, 0);
            this.tlpButtons.Controls.Add(this.gcSumms, 1, 0);
            this.tlpButtons.Controls.Add(this.sbNext, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(23, 658);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(962, 69);
            this.tlpButtons.TabIndex = 2;
            // 
            // sbPrevios
            // 
            this.sbPrevios.Image = global::OfflineARM.View.CommandResources.backward_16x16;
            this.sbPrevios.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbPrevios.Location = new System.Drawing.Point(20, 3);
            this.sbPrevios.Margin = new System.Windows.Forms.Padding(20, 3, 3, 15);
            this.sbPrevios.Name = "sbPrevios";
            this.sbPrevios.Size = new System.Drawing.Size(75, 23);
            this.sbPrevios.TabIndex = 3;
            this.sbPrevios.Text = "spPrevios";
            // 
            // sbNext
            // 
            this.sbNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbNext.Image = global::OfflineARM.View.CommandResources.forward_16x16;
            this.sbNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.sbNext.Location = new System.Drawing.Point(867, 3);
            this.sbNext.Margin = new System.Windows.Forms.Padding(3, 3, 20, 15);
            this.sbNext.Name = "sbNext";
            this.sbNext.Size = new System.Drawing.Size(75, 23);
            this.sbNext.TabIndex = 2;
            this.sbNext.Text = "sbNext";
            // 
            // tlpResponsable
            // 
            this.tlpResponsable.ColumnCount = 3;
            this.tlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResponsable.Controls.Add(this.lcResponsable, 0, 0);
            this.tlpResponsable.Controls.Add(this.lueResponsiable, 1, 0);
            this.tlpResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResponsable.Location = new System.Drawing.Point(23, 3);
            this.tlpResponsable.Name = "tlpResponsable";
            this.tlpResponsable.RowCount = 1;
            this.tlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResponsable.Size = new System.Drawing.Size(962, 24);
            this.tlpResponsable.TabIndex = 3;
            // 
            // lcResponsable
            // 
            this.lcResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lcResponsable.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcResponsable.Location = new System.Drawing.Point(6, 3);
            this.lcResponsable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 23);
            this.lcResponsable.Name = "lcResponsable";
            this.lcResponsable.Size = new System.Drawing.Size(91, 16);
            this.lcResponsable.TabIndex = 1;
            this.lcResponsable.Text = "Ответственный";
            // 
            // gcSumms
            // 
            this.gcSumms.Controls.Add(this.lcBalance);
            this.gcSumms.Controls.Add(this.lcAmountPayment);
            this.gcSumms.Controls.Add(this.lcAmountOrder);
            this.gcSumms.Location = new System.Drawing.Point(384, 0);
            this.gcSumms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gcSumms.Name = "gcSumms";
            this.gcSumms.ShowCaption = false;
            this.gcSumms.Size = new System.Drawing.Size(194, 66);
            this.gcSumms.TabIndex = 2;
            this.gcSumms.Text = "Оплаты";
            // 
            // lcBalance
            // 
            this.lcBalance.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcBalance.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lcBalance.Location = new System.Drawing.Point(15, 42);
            this.lcBalance.Name = "lcBalance";
            this.lcBalance.Size = new System.Drawing.Size(73, 16);
            this.lcBalance.TabIndex = 5;
            this.lcBalance.Text = "Остаток 0 р.";
            // 
            // lcAmountPayment
            // 
            this.lcAmountPayment.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcAmountPayment.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.lcAmountPayment.Location = new System.Drawing.Point(15, 22);
            this.lcAmountPayment.Name = "lcAmountPayment";
            this.lcAmountPayment.Size = new System.Drawing.Size(84, 16);
            this.lcAmountPayment.TabIndex = 4;
            this.lcAmountPayment.Text = "Оплачено 0 р.";
            // 
            // lcAmountOrder
            // 
            this.lcAmountOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcAmountOrder.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lcAmountOrder.Location = new System.Drawing.Point(15, 3);
            this.lcAmountOrder.Name = "lcAmountOrder";
            this.lcAmountOrder.Size = new System.Drawing.Size(102, 16);
            this.lcAmountOrder.TabIndex = 3;
            this.lcAmountOrder.Text = "Итого заказа 0 р.";
            // 
            // lueResponsiable
            // 
            this.lueResponsiable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lueResponsiable.Location = new System.Drawing.Point(103, 3);
            this.lueResponsiable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.lueResponsiable.Name = "lueResponsiable";
            this.lueResponsiable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueResponsiable.Properties.EditValueChanged += new System.EventHandler(this.lueResponsiable_Properties_EditValueChanged);
            this.lueResponsiable.Size = new System.Drawing.Size(344, 20);
            this.lueResponsiable.TabIndex = 0;
            // 
            // OrderEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OrderEditView";
            this.Size = new System.Drawing.Size(1008, 730);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpResponsable.ResumeLayout(false);
            this.tlpResponsable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSumms)).EndInit();
            this.gcSumms.ResumeLayout(false);
            this.gcSumms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueResponsiable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DevExpress.XtraEditors.LookUpEdit lueResponsiable;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpSpecific;
        private DevExpress.XtraTab.XtraTabPage tpDelivary;
        private DevExpress.XtraTab.XtraTabPage tpBuy;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private DevExpress.XtraEditors.SimpleButton sbNext;
        private DevExpress.XtraEditors.SimpleButton sbPrevios;
        private System.Windows.Forms.TableLayoutPanel tlpResponsable;
        private DevExpress.XtraEditors.LabelControl lcResponsable;
        private DevExpress.XtraEditors.GroupControl gcSumms;
        private DevExpress.XtraEditors.LabelControl lcBalance;
        private DevExpress.XtraEditors.LabelControl lcAmountPayment;
        private DevExpress.XtraEditors.LabelControl lcAmountOrder;
    }
}