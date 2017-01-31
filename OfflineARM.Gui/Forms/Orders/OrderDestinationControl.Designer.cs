namespace OfflineARM.Gui.Forms.Orders
{
    partial class OrderDestinationControl
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
            this.orderClient = new OfflineARM.Gui.Forms.Orders.OrderClientControl();
            this.orderAddress = new OfflineARM.Gui.Forms.Orders.OrderAddressControl();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.orderClient, 0, 0);
            this.tlpMain.Controls.Add(this.orderAddress, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(762, 493);
            this.tlpMain.TabIndex = 0;
            // 
            // orderClient
            // 
            this.orderClient.AutoSize = true;
            this.orderClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderClient.Location = new System.Drawing.Point(3, 3);
            this.orderClient.Name = "orderClient";
            this.orderClient.Size = new System.Drawing.Size(756, 114);
            this.orderClient.TabIndex = 0;
            // 
            // orderAddress
            // 
            this.orderAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderAddress.Location = new System.Drawing.Point(3, 123);
            this.orderAddress.Name = "orderAddress";
            this.orderAddress.Size = new System.Drawing.Size(756, 367);
            this.orderAddress.TabIndex = 1;
            // 
            // OrderDestinationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "OrderDestinationControl";
            this.Size = new System.Drawing.Size(762, 493);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private OrderClientControl orderClient;
        private OrderAddressControl orderAddress;
    }
}
