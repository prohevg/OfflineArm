using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders;
using OfflineARM.Gui.Interfaces.Windows;

namespace OfflineARM.Gui
{
    /// <summary>
    /// Главное форма
    /// </summary>
    public partial class MainForm : RibbonForm, IMainForm
    {
        #region поля и свойства

        /// <summary>
        /// О программе
        /// </summary>
        private readonly IAboutBoxProgram _aboutBoxProgram;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="aboutBoxProgram">IAboutBoxProgram</param>
        public MainForm(IAboutBoxProgram aboutBoxProgram)
        {
            InitializeComponent();

            this._aboutBoxProgram = aboutBoxProgram;

            this.Text = GuiResource.MainForm_Caption;

            var orderListControl = new OrderListControl();
            panelControl.Controls.Add(orderListControl);

            RibbonPageBarCreator.CreateBars(rpOrders, orderListControl.GetCommands(), item_ItemClick);
        }


        /// <summary>
		/// Обработчик выполения команды пункта меню
		/// </summary>
		private void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();
            CommandExecutor.Execute(e.Item);
        }

        #endregion

        #region события

        /// <summary>
        /// Добавление заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void biOrderAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            var orderForm = new OrderForm
            {
                ShowInTaskbar = false
            };
            orderForm.ShowDialog();
        }

        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void biHelpAboutProgram_ItemClick(object sender, ItemClickEventArgs e)
        {
            _aboutBoxProgram.ShowDialog();
        }

        #endregion
    }
}
