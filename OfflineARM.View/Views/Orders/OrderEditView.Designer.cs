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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEditView));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpSpecific = new DevExpress.XtraTab.XtraTabPage();
            this.orderPartSpecificControl = new OrderPartSpecificView();
            this.tpDelivary = new DevExpress.XtraTab.XtraTabPage();
            this.orderPartDelivary = new OrderPartDeliveryView();
            this.tpBuy = new DevExpress.XtraTab.XtraTabPage();
            this.orderPartPayControl = new Orders.OrderPartPayView();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.sbNext = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrevios = new DevExpress.XtraEditors.SimpleButton();
            this.tlpResponsable = new System.Windows.Forms.TableLayoutPanel();
            this.lueResponsiable = new DevExpress.XtraEditors.LookUpEdit();
            this.lcResponsable = new DevExpress.XtraEditors.LabelControl();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpSpecific.SuspendLayout();
            this.tpDelivary.SuspendLayout();
            this.tpBuy.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpResponsable.SuspendLayout();
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
            this.tlpMain.Location = new System.Drawing.Point(0, 29);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1008, 701);
            this.tlpMain.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(23, 33);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpSpecific;
            this.tcMain.Size = new System.Drawing.Size(962, 615);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSpecific,
            this.tpDelivary,
            this.tpBuy});
            // 
            // tpSpecific
            // 
            this.tpSpecific.Controls.Add(this.orderPartSpecificControl);
            this.tpSpecific.Name = "tpSpecific";
            this.tpSpecific.Size = new System.Drawing.Size(956, 587);
            this.tpSpecific.Text = "Спецификация";
            // 
            // orderPartSpecificControl
            // 
            this.orderPartSpecificControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPartSpecificControl.Location = new System.Drawing.Point(0, 0);
            this.orderPartSpecificControl.Name = "orderPartSpecificControl";
            this.orderPartSpecificControl.Size = new System.Drawing.Size(956, 587);
            this.orderPartSpecificControl.TabIndex = 0;
            // 
            // tpDelivary
            // 
            this.tpDelivary.Controls.Add(this.orderPartDelivary);
            this.tpDelivary.Name = "tpDelivary";
            this.tpDelivary.Size = new System.Drawing.Size(956, 587);
            this.tpDelivary.Text = "Доставка";
            // 
            // orderPartDelivary
            // 
            this.orderPartDelivary.Location = new System.Drawing.Point(0, 0);
            this.orderPartDelivary.Name = "orderPartDelivary";
            this.orderPartDelivary.Size = new System.Drawing.Size(732, 380);
            this.orderPartDelivary.TabIndex = 0;
            // 
            // tpBuy
            // 
            this.tpBuy.AutoScroll = true;
            this.tpBuy.Controls.Add(this.orderPartPayControl);
            this.tpBuy.Name = "tpBuy";
            this.tpBuy.Size = new System.Drawing.Size(956, 587);
            this.tpBuy.Text = "Оплата";
            // 
            // orderPartPayControl
            // 
            this.orderPartPayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPartPayControl.Location = new System.Drawing.Point(0, 0);
            this.orderPartPayControl.MinimumSize = new System.Drawing.Size(700, 500);
            this.orderPartPayControl.Name = "orderPartPayControl";
            this.orderPartPayControl.Size = new System.Drawing.Size(956, 587);
            this.orderPartPayControl.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.sbNext, 1, 0);
            this.tlpButtons.Controls.Add(this.sbPrevios, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(23, 654);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(962, 44);
            this.tlpButtons.TabIndex = 2;
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
            // sbPrevios
            // 
            this.sbPrevios.Image = global::OfflineARM.View.CommandResources.backward_16x16;
            this.sbPrevios.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbPrevios.Location = new System.Drawing.Point(3, 3);
            this.sbPrevios.Margin = new System.Windows.Forms.Padding(3, 3, 20, 15);
            this.sbPrevios.Name = "sbPrevios";
            this.sbPrevios.Size = new System.Drawing.Size(75, 23);
            this.sbPrevios.TabIndex = 3;
            this.sbPrevios.Text = "spPrevios";
            // 
            // tlpResponsable
            // 
            this.tlpResponsable.ColumnCount = 2;
            this.tlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResponsable.Controls.Add(this.lueResponsiable, 1, 0);
            this.tlpResponsable.Controls.Add(this.lcResponsable, 0, 0);
            this.tlpResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResponsable.Location = new System.Drawing.Point(23, 3);
            this.tlpResponsable.Name = "tlpResponsable";
            this.tlpResponsable.RowCount = 1;
            this.tlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResponsable.Size = new System.Drawing.Size(962, 24);
            this.tlpResponsable.TabIndex = 3;
            // 
            // lueResponsiable
            // 
            this.lueResponsiable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lueResponsiable.Location = new System.Drawing.Point(123, 3);
            this.lueResponsiable.Name = "lueResponsiable";
            this.lueResponsiable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueResponsiable.Properties.EditValueChanged += new System.EventHandler(this.lueResponsiable_Properties_EditValueChanged);
            this.lueResponsiable.Size = new System.Drawing.Size(321, 20);
            this.lueResponsiable.TabIndex = 0;
            // 
            // lcResponsable
            // 
            this.lcResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcResponsable.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcResponsable.Location = new System.Drawing.Point(26, 3);
            this.lcResponsable.Name = "lcResponsable";
            this.lcResponsable.Size = new System.Drawing.Size(91, 16);
            this.lcResponsable.TabIndex = 1;
            this.lcResponsable.Text = "Ответственный";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpSpecific.ResumeLayout(false);
            this.tpDelivary.ResumeLayout(false);
            this.tpBuy.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpResponsable.ResumeLayout(false);
            this.tlpResponsable.PerformLayout();
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
        private OrderPartSpecificView orderPartSpecificControl;
        private OrderPartDeliveryView orderPartDelivary;
        private OrderPartPayView orderPartPayControl;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private DevExpress.XtraEditors.SimpleButton sbNext;
        private DevExpress.XtraEditors.SimpleButton sbPrevios;
        private System.Windows.Forms.TableLayoutPanel tlpResponsable;
        private DevExpress.XtraEditors.LabelControl lcResponsable;
    }
}