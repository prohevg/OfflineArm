﻿using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using OfflineARM.View.Controls.EventArg;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace OfflineARM.View.Controls
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
        public const string FieldCommandName = "FieldCommandName";

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
        /// <param name="width">Ширина</param>
        /// <returns></returns>
        public GridColumn AddColumn(string caption, string fieldName, int visibleIndex = 0, UnboundColumnType unboundType = UnboundColumnType.Bound, int? width = null)
        {
            var gridColumn = GridView.Columns.AddVisible(fieldName, caption);

            gridColumn.VisibleIndex = visibleIndex;
            gridColumn.UnboundType = unboundType;
            gridColumn.Visible = true;

            if (width.HasValue)
            {
                gridColumn.MinWidth = width.Value;
                gridColumn.Width = width.Value;
                gridColumn.MaxWidth = width.Value;
            }

            return gridColumn;
        }

        /// <summary>
        /// Добавить столбец с кнопкой
        /// </summary>
        /// <param name="caption">Заголовок</param>
        /// <param name="kind">Вид кнопки</param>
        /// <param name="visibleIndex">Индекс</param>
        /// <param name="width">Ширина</param>
        /// <returns></returns>
        public GridColumn AddColumnCommand(string caption = "", ButtonPredefines kind = ButtonPredefines.Plus, int visibleIndex = 0, int? width = null)
        {
            var gridColumn = GridView.Columns.AddVisible(FieldCommandName, caption);

            gridColumn.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            gridColumn.UnboundType = UnboundColumnType.Object;
            gridColumn.VisibleIndex = visibleIndex;

            var button = new RepositoryItemButtonEdit();
            button.Buttons[0].Kind = kind;
            button.Buttons[0].Caption = caption;
            button.TextEditStyle = TextEditStyles.HideTextEditor;
            button.ButtonClick += FieldCommandName_ButtonClick;
            this.RepositoryItems.Add(button);

            gridColumn.ColumnEdit = button;

            if (width.HasValue)
            {
                gridColumn.MinWidth = width.Value;
                gridColumn.Width = width.Value;
                gridColumn.MaxWidth = width.Value;
            }

            return gridColumn;
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
            if (e.Column.FieldName == FieldCommandName)
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
        private void FieldCommandName_ButtonClick(object sender, ButtonPressedEventArgs e)
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

        #endregion
    }
}
