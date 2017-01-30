using System;
using System.Collections.Generic;
using DevExpress.XtraTreeList;
using OfflineARM.Business;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using System.Linq;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Controls.EventArg;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public partial class OrderSpecificControl : BasePartControl
    {
        #region поля и свойства

        /// <summary>
        /// Реализация номеклатуры
        /// </summary>
        private readonly INomenclatureImp _nomenclatureImp = IoCBusiness.Instance.Get<INomenclatureImp>();

        /// <summary>
        /// Характеристика номенклатуры
        /// </summary>
        private readonly ICharacteristicImp _characteristicImp = IoCBusiness.Instance.Get<ICharacteristicImp>();

        /// <summary>
        /// Экспозиция
        /// </summary>
        private readonly IExpositionImp _expositionImp = IoCBusiness.Instance.Get<IExpositionImp>();

        /// <summary>
        /// Список 
        /// </summary>
        private readonly List<IOrderSpecificationModel> _orderSpecifications = new List<IOrderSpecificationModel>();

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderSpecificControl()
        {
            InitializeComponent();

            tpExpositionCharacteristics.Text = GuiResource.OrderSpecificControl_ExpositionCharacteristics;
            tpOrderCharacteristics.Text = GuiResource.OrderSpecificControl_tpOrderCharacteristics;
            spNext.Text = GuiResource.OrderSpecificControl_spNext;

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
            InitializationNomenclatureCharacteristic();
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
        private void LoadNomenclatureTree()
        {
            treeList.LoadNodes();
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
            LoadNomenclatureCharacteristic(e.Node.Tag as INomenclatureModel);
        }

        #endregion

        #region Fill Nomenclature Characteristic

        /// <summary>
        /// Создание столюцов таблицы характиристики номенклатуры
        /// </summary>
        private void InitializationNomenclatureCharacteristic()
        {
            gcNomenclatureCharactristics.BeginUpdate();
            gcNomenclatureCharactristics.AddColumn(GuiResource.OrderSpecificControl_GridNomenclatureCharacteristicCaption_Name, "Name");
            gcNomenclatureCharactristics.AddColumn(GuiResource.OrderSpecificControl_GridNomenclatureCharacteristicCaption_Price, "Price", 1, UnboundColumnType.Decimal);
            gcNomenclatureCharactristics.AddColumnCommand(GuiResource.OrderSpecificControl_GridNomenclatureCharacteristicCaption_AddInOrder);
            gcNomenclatureCharactristics.EndUpdate();

            gcNomenclatureCharactristics.OnGridCommand += NomenclatureCharactristics_OnGridCommand;
        }

        /// <summary>
        /// Заполнение таблицы с характеристиками, если нет
        /// </summary>
        /// <param name="nomenclature"></param>
        private void LoadNomenclatureCharacteristic(INomenclatureModel nomenclature)
        {
            if (nomenclature != null)
            {
                gcNomenclatureCharactristics.DataSource = _characteristicImp.GetByNomenclatureId(nomenclature.Id);
            }
            else
            {
                gcNomenclatureCharactristics.DataSource = null;
            }
        }

        /// <summary>
        /// Добавление характеристики в заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NomenclatureCharactristics_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            var model = e.Value as ICharacteristicModel;
            if (model == null)
            {
                return;
            }

            var newOrderSpesific = new OrderSpecificationModel()
            {
                Nomenclature = model.Nomenclature,
                Characteristic = model,
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
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Name, "Characteristic.Name");
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Price, "Price");
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_Count, "Count");
            gcExposition.AddColumn(GuiResource.OrderSpecificControl_GridExpositionCaption_IsEnabled, "IsEnabled");
            gcExposition.AddColumnCommand(GuiResource.OrderSpecificControl_GridExpositionCaption_Count_AddInOrder);
            gcExposition.EndUpdate();

            gcExposition.OnGridCommand += Exposition_OnGridCommand;
        }

        /// <summary>
        /// Заполнение таблицы экспозиции
        /// </summary>
        private void LoadExpositions()
        {
            gcExposition.DataSource = _expositionImp.GetAll().Data;
        }

        /// <summary>
        /// Добавление номенклатуры в заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exposition_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            var model = e.Value as IExpositionModel;
            if (model == null)
            {
                return;
            }

            var newOrderSpesific = new OrderSpecificationModel()
            {
                Nomenclature = model.Nomenclature,
                Characteristic = model.Characteristic,
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
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Characteristic, "Characteristic.Name", 1);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Price, "Price", 2);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_DiscountProcent, "DiscountProcent", 3);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_DiscountSum, "DiscountSum", 4);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_Count, "Count", 5);
            gcOrderSpecifications.AddColumn(GuiResource.OrderSpecificControl_OrderSpecifications_TotalSum, "TotalSum", 6);
            gcOrderSpecifications.AddColumnCommand(GuiResource.OrderSpecificControl_OrderSpecifications_DeleteFromOrder, ButtonPredefines.Delete);
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
            var model = e.Value as IOrderSpecificationModel;
            if (model == null)
            {
                return;
            }

            RemoveFromOrderSpecifics(model);
        }

        #endregion

        #region private

        private void AddInOrderSpecifics(IOrderSpecificationModel model)
        {
            var exist = _orderSpecifications.FirstOrDefault(
                os => os.Nomenclature == model.Nomenclature && os.Characteristic == model.Characteristic);

            if (exist == null)
            {
                _orderSpecifications.Add(new OrderSpecificationModel()
                {
                    Nomenclature = model.Nomenclature,
                    Characteristic = model.Characteristic,
                    Count = 1,
                    Price = model.Price,
                });
            }
            else
            {
                exist.Count++;
            }

            gcOrderSpecifications.DataSource = _orderSpecifications;
            gcOrderSpecifications.RefreshDataSource();
        }

        private void RemoveFromOrderSpecifics(IOrderSpecificationModel model)
        {
            var exist = _orderSpecifications.FirstOrDefault(os => os == model);

            if (exist != null)
            {
                _orderSpecifications.Remove(exist);
                gcOrderSpecifications.DataSource = _orderSpecifications;
                gcOrderSpecifications.RefreshDataSource();
            }
        }

        #endregion
    }
}
