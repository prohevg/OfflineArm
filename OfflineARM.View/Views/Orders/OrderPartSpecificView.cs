using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.View.Base.Controls;
using OfflineARM.View.Controls.EventArg;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public partial class OrderPartSpecificView : BasePartControlView<IOrderPartSpecificController>, IOrderPartSpecificView
    {
        #region поля и свойства

        /// <summary>
        /// В потоке формы
        /// </summary>
        private readonly TaskScheduler _taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderPartSpecificView()
        {
            InitializeComponent();

            tpExpositionFeatures.Text = GuiResource.OrderSpecificControl_ExpositionCharacteristics;
            tpOrderFeatures.Text = GuiResource.OrderSpecificControl_tpOrderCharacteristics;

            Initialization();
        }

        #endregion

        #region override

        /// <summary>
        /// Инициализация контрола
        /// </summary>
        public override void Initialization()
        {
            if (_isInitialization)
            {
                return;
            }
            _isInitialization = true;

            InitializationNomenclatureTree();
            InitializationNomenclatureFeature();
            InitializationExposition();
            InitializationOrderSpecifications();
        }

        #endregion

        #region Fill Nomenclature Tree

        /// <summary>
        /// Инициализация дерева номенклатуры
        /// </summary>
        private void InitializationNomenclatureTree()
        {
            treeList.BeginUpdate();
            treeList.AddColumn(GuiResource.OrderSpecificControl_TreeNomenclatureCaption_Name, "Name");
            treeList.EndUpdate();

            treeList.SetExpandActions(GetNomenclatures, GetNomenclatureData, NomenclatureHasChild);
            treeList.FocusedNodeChanged += TreeList_FocusedNodeChanged;
        }

        /// <summary>
        /// Загрузка узлов
        /// </summary>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        private List<object> GetNomenclatures(object nodeData)
        {
            var model = nodeData as Nomenclature;
            if (model == null)
            {
                var roots = Controller.GetNomenclaturesByParentId(0);
                return roots.OfType<object>().ToList();
            }

            var childs = Controller.GetNomenclaturesByParentId(model.Id);
            return childs.OfType<object>().ToList();
        }

        /// <summary>
        /// Проверка наличия дочерних узлов
        /// </summary>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        private bool NomenclatureHasChild(object nodeData)
        {
            var model = nodeData as Nomenclature;
            if (model == null)
            {
                return false;
            }

            return Controller.NomenclatureHasChild(model.Id);
        }

        /// <summary>
        /// Данные, отображаемые в дереве
        /// </summary>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        private object[] GetNomenclatureData(object nodeData)
        {
            var model = nodeData as Nomenclature;
            if (model == null)
            {
                return null;
            }

            return new object[] { model.Name };
        }

        /// <summary>
        /// Смена выделения узла в дереве
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            LoadNomenclatureFeatures(e.Node.Tag as Nomenclature);
        }

        #endregion

        #region Fill Nomenclature Feature

        /// <summary>
        /// Создание столюцов таблицы характиристики номенклатуры
        /// </summary>
        private void InitializationNomenclatureFeature()
        {
            gcNomenclatureFeatures.BeginUpdate();
            gcNomenclatureFeatures.AddColumn(GuiResource.OrderSpecificControl_GridNomenclatureFeatureCaption_Name, "Name");
            gcNomenclatureFeatures.AddColumn(GuiResource.OrderSpecificControl_GridNomenclatureFeatureCaption_Price, "Price", 1, UnboundColumnType.Decimal, 75);
            gcNomenclatureFeatures.AddColumnCommand(GuiResource.OrderSpecificControl_GridNomenclatureFeatureCaption_AddInOrder, visibleIndex: 2, width: 50);
            gcNomenclatureFeatures.EndUpdate();

            gcNomenclatureFeatures.OnGridCommand += NomenclatureFeatures_OnGridCommand;
        }

        /// <summary>
        /// Заполнение таблицы с характеристиками, если нет
        /// </summary>
        /// <param name="nomenclature"></param>
        private void LoadNomenclatureFeatures(Nomenclature nomenclature)
        {
            if (nomenclature != null)
            {
                gcNomenclatureFeatures.DataSource = Controller.GetFeaturesByNomenclatureId(nomenclature.Id);
            }
            else
            {
                gcNomenclatureFeatures.DataSource = null;
            }
        }

        /// <summary>
        /// Добавление характеристики в заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NomenclatureFeatures_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            Controller.AddFeatureToSpecification(e.Value as Feature);
        }

        #endregion

        #region Fill Exposition

        /// <summary>
        /// Создание столюцов таблицы экспозиции
        /// </summary>
        private void InitializationExposition()
        {
            gcExposition.BeginUpdate();
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Nomeclature, "Nomenclature.Name");
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Name, "Feature.Name", 1);
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Price, "Price", 2, UnboundColumnType.Decimal, 75);
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Count, "Count", 3, UnboundColumnType.Integer, 75);
            gcExposition.AddColumnCommand(GuiResource.OrderSpecificControl_GridExpositionCaption_Count_AddInOrder, visibleIndex: 4, width: 50);
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_IsEnabled, "IsEnabled", 5, width: 50);
            gcExposition.EndUpdate();

            gcExposition.OnGridCommand += Exposition_OnGridCommand;
        }

        /// <summary>
        /// Добавление номенклатуры в заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exposition_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            this.Controller.AddExpositionToSpecification(e.Value as Exposition);

            gcExposition.RefreshDataSource();
        }

        #endregion

        #region Fill Order Specifications

        /// <summary>
        /// Инициализация таблицы спецификации товара
        /// </summary>
        private void InitializationOrderSpecifications()
        {
            gcOrderSpecifications.BeginUpdate();
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Nomenclature, "Nomenclature.Name");
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Characteristic, "Feature.Name", 1);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Price, "Price", 2, UnboundColumnType.Decimal, 75);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_DiscountProcent, "DiscountPercent", 3, UnboundColumnType.Decimal, 50);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_DiscountSum, "DiscountAmount", 4, UnboundColumnType.Decimal, 75);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Count, "Count", 5, UnboundColumnType.Integer, 50);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_TotalSum, "PriceWithDiscount", 6, UnboundColumnType.Decimal, 75);
            gcOrderSpecifications.AddColumnCommand(GuiResource.OrderSpecificControl_OrderSpecifications_DeleteFromOrder, ButtonPredefines.Delete, 7, 50);
            gcOrderSpecifications.EndUpdate();

            gcOrderSpecifications.OnGridCommand += OrderSpecifications_OnGridCommand;
        }

        /// <summary>
        /// Обработчик удаления из заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderSpecifications_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            this.Controller.RemoveFromSpecification(e.Value as OrderSpecificationItem);
        }

        #endregion

        #region IOrderPartSpecificView

        /// <summary>
        /// Загрукзка экспозиция
        /// </summary>
        /// <param name="data">Список экспозиций</param>
        public void LoadExpositions(PagedResult<Exposition> data)
        {
            gcExposition.DataSource = data.Data;
        }

        /// <summary>
        /// Заполнение дерева номенклатуры
        /// </summary>
        public async void LoadNomenclatureTree()
        {
            await Task.Factory.StartNew(() => treeList.LoadNodes(), CancellationToken.None, TaskCreationOptions.None, _taskScheduler);
        }

        /// <summary>
        /// Добавить в грид к спецификации
        /// </summary>
        /// <param name="orderSpesific">спецификация</param>
        public void AddToSpecificationGrid(OrderSpecificationItem orderSpesific)
        {
            var source = gcOrderSpecifications.DataSource as List<OrderSpecificationItem>;
            if (source == null)
            {
                gcOrderSpecifications.DataSource = new List<OrderSpecificationItem> {orderSpesific};
            }
            else
            {
                if (!source.Contains(orderSpesific))
                {
                    source.Add(orderSpesific);
                    gcOrderSpecifications.DataSource = orderSpesific;
                }
            }

            gcOrderSpecifications.RefreshDataSource();
        }

        /// <summary>
        /// Удалить из грида спецификации
        /// </summary>
        /// <param name="orderSpesific">спецификация</param>
        public void RemoveFromSpecificationGrid(OrderSpecificationItem orderSpesific)
        {
            var source = gcOrderSpecifications.DataSource as List<OrderSpecificationItem>;
            if (source == null)
            {
                return;
            }
            
            source.Remove(orderSpesific);

            gcOrderSpecifications.DataSource = orderSpesific;
            gcOrderSpecifications.RefreshDataSource();
        }

        #endregion
    }
}