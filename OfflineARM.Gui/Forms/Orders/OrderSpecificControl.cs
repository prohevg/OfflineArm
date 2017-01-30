using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraTreeList;
using OfflineARM.Business;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using System.Linq;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using OfflineARM.Gui.Controls.EventArg;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public partial class OrderSpecificControl : UserControl
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


        List<OrderTemp> _orders = new List<OrderTemp>();

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

            FillNomenclatureTree();

            NomenclatureCharacteristicColumns();

            ExpositionColumns();
            FillExpositions();
        }

        #endregion

        #region Fill Nomenclature Tree

        /// <summary>
        /// Заполнение дерева номенклатуры
        /// </summary>
        private void FillNomenclatureTree()
        {
            treeList.BeginUpdate();
            treeList.AddColumn(GuiResource.OrderSpecificControl_TreeNomenclatureCaption_Name, "Name");
            treeList.EndUpdate();

            treeList.SetExpandActions(GetNomenclatures, GetNomenclatureData, GetNomenclatureHasChild);
            treeList.FocusedNodeChanged += TreeList_FocusedNodeChanged;
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
            FillNomenclatureCharacteristic(e.Node.Tag as INomenclatureModel);
        }

        #endregion

        #region Fill Nomenclature Characteristic

        /// <summary>
        /// Создание столюцов таблицы характиристики номенклатуры
        /// </summary>
        private void NomenclatureCharacteristicColumns()
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
        private void FillNomenclatureCharacteristic(INomenclatureModel nomenclature)
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

            _orders.Add(new OrderTemp()
            {
                Nomenclature = model.Nomenclature.Name,
                Characteristic = model.Name
            });

            gcNomenclatureSelected.DataSource = _orders;
            gcNomenclatureSelected.RefreshDataSource();
        }

        #endregion

        #region Fill Exposition

        /// <summary>
        /// Создание столюцов таблицы экспозиции
        /// </summary>
        private void ExpositionColumns()
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
        private void FillExpositions()
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

            _orders.Add(new OrderTemp()
            {
                Nomenclature = model.Nomenclature.Name,
                Characteristic = model.Characteristic.Name
            });

            gcNomenclatureSelected.DataSource = _orders;
            gcNomenclatureSelected.RefreshDataSource();
        }


        #endregion
    }

    public class  OrderTemp
    {
        public string Nomenclature { get; set; }

        public string Characteristic { get; set; }

    }
}
