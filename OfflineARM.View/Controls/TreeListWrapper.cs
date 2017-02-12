using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OfflineARM.View.Controls
{
    /// <summary>
    /// Дерево
    /// </summary>
    public class TreeListWrapper : TreeList
    {
        #region поля и свойства

        /// <summary>
        /// Метод, возращает список объектов (дочерних) для построения узлов
        /// </summary>
        private Func<object, List<object>> _getNodes;

        /// <summary>
        /// Метод, возращает данные узла
        /// </summary>
        private Func<object, object[]> _getNodeObject;

        /// <summary>
        /// Метод, возращает данные узла
        /// </summary>
        private Func<object, bool> _getHasNodes;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public TreeListWrapper()
        {
            this.OptionsBehavior.Editable = false;
            this.OptionsView.ShowHorzLines = false;
            this.OptionsView.ShowVertLines = false;

            this.BeforeExpand += TreeListWrapper_BeforeExpand;
            this.CustomDrawNodeButton += TreeListWrapper_CustomDrawNodeButton;
        }

        #endregion

        #region События

        /// <summary>
        /// Раскрытие узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeListWrapper_BeforeExpand(object sender, BeforeExpandEventArgs e)
        {
            LoadNodes(e.Node.Tag, e.Node);
        }

        private void TreeListWrapper_CustomDrawNodeButton(object sender, CustomDrawNodeButtonEventArgs e)
        {
            Brush backBrush = e.Cache.GetSolidBrush(Color.White);
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            //ControlPaint.DrawBorder(e.Graphics, e.Bounds, Color.Gray, ButtonBorderStyle.Solid);
            string displayCharacter = e.Expanded ? "-" : "+";
            StringFormat outCharacterFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            e.Graphics.DrawString(displayCharacter, new Font("Verdana", 8), new SolidBrush(Color.Black), e.Bounds, outCharacterFormat);
            e.Handled = true;
        }

        #endregion

        #region методы

        /// <summary>
        /// Действия выполняемые при раскрытии узла
        /// </summary>
        /// <param name="getNodes"></param>
        /// <param name="getNodeObject"></param>
        /// <param name="getHasNodes"></param>
        public void SetExpandActions(Func<object, List<object>> getNodes, Func<object, object[]> getNodeObject, Func<object, bool> getHasNodes)
        {
            this._getNodes = getNodes;
            this._getNodeObject = getNodeObject;
            this._getHasNodes = getHasNodes;
        }

        /// <summary>
        /// Добавить столбец
        /// </summary>
        /// <param name="caption">Заголовок</param>
        /// <param name="fieldName">Имя привязываемого поля</param>
        /// <param name="visibleIndex">Индекс</param>
        /// <returns></returns>
        public TreeListColumn AddColumn(string caption, string fieldName, int visibleIndex = 0)
        {
            var gridColumn = this.Columns.Add();

            gridColumn.Caption = caption;
            gridColumn.FieldName = fieldName;
            gridColumn.VisibleIndex = visibleIndex;

            return gridColumn;
        }

        /// <summary>
        /// Загрузка дочерних узлов
        /// </summary>
        /// <param name="parentNodeData">Данные родительского узла</param>
        /// <param name="parentNode">Родитеский узел</param>
        public void LoadNodes(object parentNodeData = null, TreeListNode parentNode = null)
        {
            this.BeginUnboundLoad();

            foreach (var data in _getNodes(parentNodeData))
            {
                var node = this.AppendNode(_getNodeObject(data), parentNode);
                node.HasChildren = _getHasNodes(data);
                node.Tag = data;
            }

            this.EndUnboundLoad();
        }

        #endregion
    }
}
