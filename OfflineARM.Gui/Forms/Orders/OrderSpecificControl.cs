using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using OfflineARM.Business;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public partial class OrderSpecificControl : UserControl
    {
        List<OrderTemp> _orders = new List<OrderTemp>();

        public OrderSpecificControl()
        {
            InitializeComponent();

            tpExpositionCharacteristics.Text = GuiResource.OrderSpecificControl_ExpositionCharacteristics;
            tpOrderCharacteristics.Text = GuiResource.OrderSpecificControl_tpOrderCharacteristics;
            spNext.Text = GuiResource.OrderSpecificControl_spNext;
        }

        #region События

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillNomenclatureTree();
        }

        #endregion

        #region Fill Nomenclature Tree

        /// <summary>
        /// Заполнение дерева номенклатуры
        /// </summary>
        private void FillNomenclatureTree()
        {
            treeNomenclature.OptionsSelection.EnableAppearanceFocusedCell = true;
            CreateColumns(treeNomenclature);
            LoadNodes(0);
        }

        /// <summary>
        /// Создание узлов в дереве
        /// </summary>
        /// <param name="tl"></param>
        private void CreateColumns(TreeList tl)
        {
            tl.BeginUpdate();
            tl.KeyFieldName = "Id";
            tl.ParentFieldName = "ParentId";

            TreeListColumn col1 = tl.Columns.Add();
            col1.Caption = GuiResource.OrderSpecificControl_treeNomenclature_CaptionId;
            col1.FieldName = "Id";
            col1.VisibleIndex = -1;

            TreeListColumn col2 = tl.Columns.Add();
            col2.Caption = "ParentId";
            col2.FieldName = "ParentId";
            col2.VisibleIndex = -1;

            TreeListColumn col3 = tl.Columns.Add();
            col3.Caption = GuiResource.OrderSpecificControl_treeNomenclature_CaptionName;
            col3.FieldName = "Name";
            col3.VisibleIndex = 0;

            tl.EndUpdate();
        }

        /// <summary>
        /// Загрузка узлов
        /// </summary>
        /// <param name="parentId">Id родительского узла</param>
        /// <param name="parentNode">Родитеский узел</param>
        private void LoadNodes(int parentId, TreeListNode parentNode = null)
        {
            treeNomenclature.BeginUnboundLoad();

            INomenclatureImp nomenclatureImp = IoCBusiness.Instance.Get<INomenclatureImp>();
            var roots = nomenclatureImp.GetAllByParentId(parentId);
            foreach (var nomenclature in roots)
            {
                var node = treeNomenclature.AppendNode(new object[] { nomenclature.Id, nomenclature.ParentId, nomenclature.Name }, parentNode);
                node.HasChildren = nomenclatureImp.HasChildren(nomenclature.Id);
                node.Tag = nomenclature;
            }

            treeNomenclature.EndUnboundLoad();
        }

        /// <summary>
        /// Событие раскрутия узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeNomenclature_BeforeExpand(object sender, BeforeExpandEventArgs e)
        {
            var nomenclature = e.Node.Tag as INomenclatureModel;
            LoadNodes(nomenclature.Id, e.Node);
        }

        /// <summary>
        /// смега
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeNomenclature_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            FillGridStoreCharacteristic(e.Node.Tag as INomenclatureModel);
        }

        #endregion

        #region Fill Characteristic

        #region Fill Characteristic from store

        private void FillGridStoreCharacteristic(INomenclatureModel nomenclature)
        {
            if (nomenclature != null)
            {
                var list = IoCBusiness.Instance.Get<ICharacteristicImp>().GetByNomenclatureId(nomenclature.Id);
                gcOrderCharacteristics.DataSource = list;
            }
            else
            {
                gcOrderCharacteristics.DataSource = null;
            }
        }

        private void biAddCommand_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (gcOrderCharacteristicsView.FocusedRowHandle < 0)
            {
                return;
            }

            var row = gcOrderCharacteristicsView.GetFocusedRow();
            var charact = row as ICharacteristicModel;

            _orders.Add(new OrderTemp()
            {
                Nomenclature = charact.Nomenclature.Name,
                Characteristic = charact.Name
            });

            gcNomenclatureSelected.DataSource = _orders;
            gcNomenclatureSelected.RefreshDataSource();
        }

        private void gcOrderCharacteristics_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            //if (e.Column.FieldName == "gcAddInOrderCommand")
            //{
            //    e.Value = e.Row;
            //    e.Column.ColumnEdit.Tag = e.Row;
            //}
        }

        #endregion

        #endregion
    }

    public class  OrderTemp
    {
        public string Nomenclature { get; set; }

        public string Characteristic { get; set; }

    }
}
