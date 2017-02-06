using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using OfflineARM.Gui.Controls.EventArg;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace OfflineARM.Gui.Controls
{
    /// <summary>
    /// Таблица
    /// </summary>
    public class GridControlWrapper : GridControl
    {
        #region поля и свойства

        /// <summary>
        /// FieldName кнопки добавить
        /// </summary>
        public const string AddFieldName = "AddButton";

        /// <summary>
        /// FieldName кнопки Удалить
        /// </summary>
        public const string DeleteFieldName = "DeleteButton";

        /// <summary>
        /// Главная таблица
        /// </summary>
        public GridView GridView
        {
            get
            {
                return this.MainView as GridView;
            }
        }

        /// <summary>
        /// Событие команды в строке грида
        /// </summary>
        public event EventHandler<GridCommandEventArgs> OnGridCommand;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public GridControlWrapper()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region override

        /// <summary>
        /// Загрузка формы
        /// </summary>
        protected override void OnLoaded()
        {
            GridView.OptionsBehavior.ReadOnly = true;
            GridView.OptionsView.ShowGroupedColumns = false;
            GridView.OptionsView.ShowGroupPanel = false;

            GridView.CustomUnboundColumnData += GridView_CustomUnboundColumnData;
            GridView.DoubleClick += GridView_DoubleClick;

            base.OnLoaded();
        }

        #endregion

        #region методы

        /// <summary>
        /// Добавить столбец
        /// </summary>
        /// <param name="caption">Заголовок</param>
        /// <param name="fieldName">Имя привязываемого поля</param>
        /// <param name="visibleIndex">Индекс</param>
        /// <param name="unboundType">Тип</param>
        /// <returns></returns>
        public GridColumn AddColumn(string caption, string fieldName, int visibleIndex = 0, UnboundColumnType unboundType = UnboundColumnType.Bound)
        {
            var gridColumn = GridView.Columns.AddVisible(fieldName, caption);

            gridColumn.VisibleIndex = visibleIndex;
            gridColumn.UnboundType = unboundType;
            gridColumn.Visible = true;

            return gridColumn;
        }

        /// <summary>
        /// Добавить столбец с кнопкой
        /// </summary>
        /// <param name="caption">Заголовок</param>
        /// <param name="kind">Вид кнопки</param>
        /// <returns></returns>
        public GridColumn AddColumnCommand(string caption = "", ButtonPredefines kind = ButtonPredefines.Plus)
        {
            return AddColumnCommandInternal(caption, kind);
        }

        #endregion

        #region События

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == AddFieldName)
            {
                (e.Column.ColumnEdit as RepositoryItemButtonEdit).Buttons[0].Tag = e.Row;
            }
        }

        /// <summary>
        /// https://www.devexpress.com/Support/Center/Question/Details/A2934
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        /// <summary>
        /// Обработчик двойного клика по строке
        /// </summary>
        /// <param name="view"></param>
        /// <param name="pt"></param>
        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow)
            {
                var row = view.GetFocusedRow();
                if (row != null)
                {
                    RaiseGridCommand(row);
                }
            }
        }

        /// <summary>
        /// Событие добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var row = GridView.GetFocusedRow();
            if (row != null)
            {
                RaiseGridCommand(row);
            }
        }

        #endregion

        #region private

        /// <summary>
        /// Вбросить событие
        /// </summary>
        /// <param name="value"></param>
        private void RaiseGridCommand(object value)
        {
            if (OnGridCommand != null)
            {
                OnGridCommand(this, new GridCommandEventArgs(value));
            }
        }

        /// <summary>
        /// Добавить столбец с кнопкой
        /// </summary>
        /// <param name="caption">Заголовок</param>
        /// <param name="kind">Вид кнопки</param>
        /// <returns></returns>
        public GridColumn AddColumnCommandInternal(string caption = "", ButtonPredefines kind = ButtonPredefines.Ellipsis)
        {
            string fieldName = string.Empty;
            switch (kind)
            {
                case ButtonPredefines.Plus:
                    fieldName = AddFieldName;
                    break;
                case ButtonPredefines.Delete:
                    fieldName = DeleteFieldName;
                    break;
            }


            var gridColumn = GridView.Columns.AddVisible(AddFieldName, caption);

            gridColumn.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            gridColumn.UnboundType = UnboundColumnType.Object;

            var button = new RepositoryItemButtonEdit();
            button.Buttons[0].Kind = kind;
            button.Buttons[0].Caption = caption;
            button.TextEditStyle = TextEditStyles.HideTextEditor;
            button.ButtonClick += AddButton_ButtonClick;
            this.RepositoryItems.Add(button);

            gridColumn.ColumnEdit = button;

            return gridColumn;
        }

        #endregion
    }
}
