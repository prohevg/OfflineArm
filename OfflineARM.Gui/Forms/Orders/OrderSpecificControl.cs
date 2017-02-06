using System;
using System.Collections.Generic;
using DevExpress.XtraTreeList;
using OfflineARM.Business;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Controls.EventArg;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using OfflineARM.Gui.Helpers;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public partial class OrderSpecificControl : BasePartControl, IOrderSpecificControl
    {
        #region поля и свойства

        /// <summary>
        /// Реализация номеклатуры
        /// </summary>
        private readonly INomenclatureImp _nomenclatureImp;

        /// <summary>
        /// Характеристика номенклатуры
        /// </summary>
        private readonly IFeatureImp _featureImp;

        /// <summary>
        /// Экспозиция
        /// </summary>
        private readonly IExpositionImp _expositionImp;

        /// <summary>
        /// В потоке формы
        /// </summary>
        private readonly TaskScheduler _taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderSpecificControl()
        {
            InitializeComponent();

            tpExpositionFeatures.Text = GuiResource.OrderSpecificControl_ExpositionCharacteristics;
            tpOrderFeatures.Text = GuiResource.OrderSpecificControl_tpOrderCharacteristics;
          
            if (!DesignTimeHelper.IsInDesignMode)
            {
                 _nomenclatureImp = IoCBusiness.Instance.Get<INomenclatureImp>();
                _featureImp = IoCBusiness.Instance.Get<IFeatureImp>();
                _expositionImp = IoCBusiness.Instance.Get<IExpositionImp>();
            }

            Initialization();
        }

        #endregion

        #region События

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadNomenclatureTree();
            LoadExpositions();
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

            treeList.SetExpandActions(GetNomenclatures, GetNomenclatureData, GetNomenclatureHasChild);
            treeList.FocusedNodeChanged += TreeList_FocusedNodeChanged;
        }

        /// <summary>
        /// Заполнение дерева номенклатуры
        /// </summary>
        private async void LoadNomenclatureTree()
        {
            await Task.Factory.StartNew(() => treeList.LoadNodes(), CancellationToken.None, TaskCreationOptions.None, _taskScheduler);
        }

        /// <summary>
        /// Загрузка узлов
        /// </summary>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        private List<object> GetNomenclatures(object nodeData)
        {
            var model = nodeData as INomenclatureModel;
            if (model == null)
            {
                var roots = _nomenclatureImp.GetAllByParentId(0);
                return roots.OfType<object>().ToList();
            }

            var childs = _nomenclatureImp.GetAllByParentId(model.Id);
            return childs.OfType<object>().ToList();
        }

        /// <summary>
        /// Проверка наличия дочерних узлов
        /// </summary>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        private bool GetNomenclatureHasChild(object nodeData)
        {
            var model = nodeData as INomenclatureModel;
            if (model == null)
            {
                return false;
            }

            return _nomenclatureImp.HasChildren(model.Id);
        }

        /// <summary>
        /// Данные, отображаемые в дереве
        /// </summary>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        private object[] GetNomenclatureData(object nodeData)
        {
            var model = nodeData as INomenclatureModel;
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
            LoadNomenclatureFeatures(e.Node.Tag as INomenclatureModel);
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
        private void LoadNomenclatureFeatures(INomenclatureModel nomenclature)
        {
            if (nomenclature != null)
            {
                gcNomenclatureFeatures.DataSource = _featureImp.GetByNomenclatureId(nomenclature.Id);
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
            var model = e.Value as IFeatureModel;
            if (model == null)
            {
                return;
            }

            var newOrderSpesific = new OrderSpecificationItemModel()
            {
                Guid = Guid.NewGuid(),
                Nomenclature = model.Nomenclature,
                Feature = model,
                Count = 1,
                Price = model.Price,
            };

            AddInOrderSpecifics(newOrderSpesific);
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
        /// Заполнение таблицы экспозиции
        /// </summary>
        private async void LoadExpositions()
        {
            var result = await _expositionImp.GetAllAsync();
            gcExposition.DataSource = result.Data;
        }

        /// <summary>
        /// Добавление номенклатуры в заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exposition_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            var model = e.Value as IExpositionModel;
            if (model == null || model.Count <= 0)
            {
                return;
            }

            model.Count--;
            gcExposition.RefreshDataSource();

            var newOrderSpesific = new OrderSpecificationItemModel()
            {
                Guid = Guid.NewGuid(),
                Nomenclature = model.Nomenclature,
                Feature = model.Feature,
                Count = 1,
                Price = model.Price,
            };

            AddInOrderSpecifics(newOrderSpesific);
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
            var model = e.Value as IOrderSpecificationItemModel;
            if (model == null)
            {
                return;
            }

            RemoveFromOrderSpecifics(model);
        }

        #endregion

        #region private

        private void AddInOrderSpecifics(IOrderSpecificationItemModel model)
        {
            var exist = _specifications.FirstOrDefault(
                os => os.Nomenclature == model.Nomenclature && os.Feature == model.Feature);

            if (exist == null)
            {
                _specifications.Add(new OrderSpecificationItemModel()
                {
                    Guid = Guid.NewGuid(),
                    Nomenclature = model.Nomenclature,
                    Feature = model.Feature,
                    Count = 1,
                    Price = model.Price
                });
            }
            else
            {
                exist.Count++;
            }

            foreach (var itemModel in _specifications)
            {
                itemModel.PriceWithDiscount = itemModel.Count * itemModel.Price;
            }

            gcOrderSpecifications.DataSource = _specifications;
            gcOrderSpecifications.RefreshDataSource();

            RecalculateTotalAmmout();
        }

        private void RemoveFromOrderSpecifics(IOrderSpecificationItemModel model)
        {
            _specifications.Remove(model);

            var source = gcExposition.DataSource as List<IExpositionModel>;
            if (source != null)
            {

            }

            gcOrderSpecifications.DataSource = _specifications;
            gcOrderSpecifications.RefreshDataSource();

            RecalculateTotalAmmout();
        }

        private void RecalculateTotalAmmout()
        {
            decimal ammount = 0;
            foreach (var item in this._specifications)
            {
                ammount += item.PriceWithDiscount;
            }

            TotalAmount = ammount;
        }

        #endregion

        #region IOrderSpecificControl

        /// <summary>
        /// Список 
        /// </summary>
        private List<IOrderSpecificationItemModel> _specifications = new List<IOrderSpecificationItemModel>();

        /// <summary>
        /// Список спецификации
        /// </summary>
        public  List<IOrderSpecificationItemModel> Specifications
        {
            get
            {
                return _specifications;
            }
            set
            {
                _specifications = value;
            }
        }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal TotalAmount
        {
            get;
            set;
        }

        #endregion
    }
}