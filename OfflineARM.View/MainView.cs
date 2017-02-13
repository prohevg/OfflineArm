using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OfflineARM.Controller;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Settings;

namespace OfflineARM.View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainView : RibbonForm, IMainView
    {
        #region поля и свойства

        /// <summary>
        /// Список заказов
        /// </summary>
        private readonly IOrderListView _orderListView;

        /// <summary>
        /// Настройки приложения
        /// </summary>
        private readonly ISettingsView _settingsView;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="orderListView">Список заказов</param>
        /// <param name="settingsView">Настройки приложения</param>
        public MainView(IOrderListView orderListView, ISettingsView settingsView)
        {
            InitializeComponent();

            this.MinimumSize = new Size(1024, 768);
            this.Text = string.Empty;

            CreateController();

            _orderListView = orderListView;
            _settingsView = settingsView;

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

            tabControl.TabPages[0].Controls.Add(orderListView as Control);
            tabControl.TabPages[2].Controls.Add(settingsView as Control);

            orderListView.Controller.LoadView();

            BarCreator.CreateBars(rpOrders, orderListView.Controller.GetCommands(), item_ItemClick);
        }

        #endregion

        #region IMainView

        /// <summary>
        /// Контроллер формы
        /// </summary>
        private IMainController _сontroller;

        /// <summary>
        /// Контроллер для формы
        /// </summary>
        public IMainController Controller
        {
            get
            {
                return _сontroller ?? CreateController();
            }
        }

        /// <summary>
        /// Создать контроллер для представления
        /// </summary>
        private IMainController CreateController()
        {
            _сontroller = IoCControllers.Instance.ResolveController(this);
            _сontroller.SetControllerView(this);
            return _сontroller;
        }

        #endregion

        #region События

        /// <summary>
		/// Обработчик выполения команды пункта меню
		/// </summary>
		private void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();
            CommandExecutor.Execute(e.Item.Tag as ICommand);
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
                BarCreator.CreateBars(rpOrders, _orderListView.Controller.GetCommands(), item_ItemClick);
            }

            if (ribbonControl.SelectedPage.PageIndex == 2)
            {
                tabControl.TabPages[2].Controls[0].Visible = true;
                BarCreator.CreateBars(rpSettings, _settingsView.Controller.GetCommands(), item_ItemClick);

            }
        }

        #endregion
    }
}
