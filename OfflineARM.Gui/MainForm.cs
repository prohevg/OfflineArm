using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using OfflineARM.Gui.Interfaces.Windows;

namespace OfflineARM.Gui
{
    /// <summary>
    /// Главное форма
    /// </summary>
    public partial class MainForm : RibbonForm, IMainForm
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="orderListControl">Заказы</param>
        public MainForm(IOrderListControl orderListControl)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.Dock = DockStyle.Fill;
            tabControl.TabPages.Clear();

            for (var i = 0; i < this.ribbonControl.Pages.Count; i++)
            {
                tabControl.TabPages.Add("");
                tabControl.TabPages[i].Dock = DockStyle.Fill;
            }

            var orderControl = orderListControl as Control;
            orderControl.Dock = DockStyle.Fill;
            tabControl.TabPages[0].Controls.Add(orderControl);

            BarCreator.CreateBars(rpOrders, orderListControl.GetCommands(), item_ItemClick);
        }

        #endregion

        #region События

        protected override void OnLoad(EventArgs e)
        {
            this.Text = GuiResource.MainForm_Caption;

            base.OnLoad(e);
        }

        /// <summary>
		/// Обработчик выполения команды пункта меню
		/// </summary>
		private void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();
            CommandExecutor.Execute(e.Item);
        }

        /// <summary>
        /// Смена страниц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControl.SelectedPage == null)
            {
                return;
            }

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Controls.Count > 0)
                {
                    tabPage.Controls[0].Visible = false;
                }
            }

            if (ribbonControl.SelectedPage.PageIndex == 0)
            {
                tabControl.TabPages[0].Controls[0].Visible = true;
            }
        }

        #endregion
    }
}
