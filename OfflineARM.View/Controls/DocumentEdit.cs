using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Controller.Loggers;
using OfflineARM.Controller.ViewInterfaces;

namespace OfflineARM.View.Controls
{
    /// <summary>
    /// Добавление\открытие документа
    /// </summary>
    public class DocumentEdit : HyperLinkEdit
    {
        #region поля и свойства

        /// <summary>
        /// Путь к файлу
        /// </summary>
        private string _path;

        /// <summary>
        /// Поток байт файла
        /// </summary>
        private byte[] _fileStream;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Path
        {
            get
            {
                return this._path;
            }
            set
            {
                if (!string.Equals(_path, value))
                {
                    this._path = value;
                    this.EditValue = FileName;
                }
            }
        }

        /// <summary>
        /// Наименование файла
        /// </summary>
        public string FileName
        {
            get
            {
                return string.IsNullOrWhiteSpace(Path) ? string.Empty : System.IO.Path.GetFileName(Path);
            }
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public DocumentEdit()
        {
            var addButton = new EditorButton(ButtonPredefines.Plus, GuiResource.DocumentEdit_AddToolTip);

            this.Properties.Buttons.Clear();
            this.Properties.Buttons.Add(addButton);
           
            this.ButtonClick += DocumentEdit_ButtonClick;
            this.OpenLink += DocumentEdit_OpenLink;
        }

        #endregion

        #region события

        /// <summary>
        /// Открыть документ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentEdit_OpenLink(object sender, OpenLinkEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Path))
                {
                    Process.Start(Path);
                }
            }
            catch (Exception exc)
            {
                var error = string.Format(GuiResource.DocumentEdit_ErrorOpenDocument, Path);
                IoCView.Instance.Resolve<IMessageBoxView>().Show(error);   
                Logger.Error(exc.Message);
                Logger.Error(exc.StackTrace);
            }
        }

        /// <summary>
        /// Добавить документ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DocumentEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
            }
        }

        #endregion
    }
}
