namespace OfflineARM.Gui.Forms.Orders
{
    partial class OrderForm
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
            this.lueResponsiable = new DevExpress.XtraEditors.LookUpEdit();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpSpecific = new DevExpress.XtraTab.XtraTabPage();
            this.orderSpecificControl = new OfflineARM.Gui.Forms.Orders.OrderSpecificControl();
            this.tpDelivary = new DevExpress.XtraTab.XtraTabPage();
            this.orderDestination = new OfflineARM.Gui.Forms.Orders.OrderDestinationControl();
            this.tpBuy = new DevExpress.XtraTab.XtraTabPage();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueResponsiable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpSpecific.SuspendLayout();
            this.tpDelivary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.lueResponsiable, 1, 1);
            this.tlpMain.Controls.Add(this.tcMain, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 29);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(784, 532);
            this.tlpMain.TabIndex = 0;
            // 
            // lueResponsiable
            // 
            this.lueResponsiable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lueResponsiable.Location = new System.Drawing.Point(23, 23);
            this.lueResponsiable.Name = "lueResponsiable";
            this.lueResponsiable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueResponsiable.Size = new System.Drawing.Size(738, 20);
            this.lueResponsiable.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(23, 53);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpSpecific;
            this.tcMain.Size = new System.Drawing.Size(738, 476);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSpecific,
            this.tpDelivary,
            this.tpBuy});
            // 
            // tpSpecific
            // 
            this.tpSpecific.Controls.Add(this.orderSpecificControl);
            this.tpSpecific.Name = "tpSpecific";
            this.tpSpecific.Size = new System.Drawing.Size(732, 448);
            this.tpSpecific.Text = "Спецификация";
            // 
            // orderSpecificControl
            // 
            this.orderSpecificControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderSpecificControl.Location = new System.Drawing.Point(0, 0);
            this.orderSpecificControl.Name = "orderSpecificControl";
            this.orderSpecificControl.Size = new System.Drawing.Size(732, 448);
            this.orderSpecificControl.TabIndex = 0;
            // 
            // tpDelivary
            // 
            this.tpDelivary.Controls.Add(this.orderDestination);
            this.tpDelivary.Name = "tpDelivary";
            this.tpDelivary.Size = new System.Drawing.Size(732, 448);
            this.tpDelivary.Text = "Доставка";
            // 
            // orderDestination
            // 
            this.orderDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDestination.Location = new System.Drawing.Point(0, 0);
            this.orderDestination.Name = "orderDestination";
            this.orderDestination.Size = new System.Drawing.Size(732, 448);
            this.orderDestination.TabIndex = 0;
            // 
            // tpBuy
            // 
            this.tpBuy.Name = "tpBuy";
            this.tpBuy.Size = new System.Drawing.Size(732, 448);
            this.tpBuy.Text = "Оплата";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueResponsiable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpSpecific.ResumeLayout(false);
            this.tpDelivary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DevExpress.XtraEditors.LookUpEdit lueResponsiable;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpSpecific;
        private DevExpress.XtraTab.XtraTabPage tpDelivary;
        private DevExpress.XtraTab.XtraTabPage tpBuy;
        private OrderSpecificControl orderSpecificControl;
        private OrderDestinationControl orderDestination;
    }
}