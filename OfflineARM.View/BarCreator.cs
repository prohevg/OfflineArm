using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.Holders;

namespace OfflineARM.View
{
    /// <summary>
    /// Создание команд на панели
    /// </summary>
    public class BarCreator
    {
        /// <summary>
        /// Создание панели задач на форме
        /// </summary>
        /// <param name="ribbonPage">Страница</param>
        /// <param name="commands">Команды</param>
        /// <param name="handler">Обработчик команд</param>
        public static void CreateBars(RibbonPage ribbonPage, List<ICommand> commands, ItemClickEventHandler handler)
        {
            if (commands == null || commands.Count == 0)
            {
                return;
            }

            var ribbonPageGroup = new RibbonPageGroup();

            ribbonPage.Groups.Add(ribbonPageGroup);

            ribbonPageGroup.AllowTextClipping = false;
            ribbonPageGroup.ShowCaptionButton = false;
            ribbonPageGroup.Text = "Действия";

            foreach (var command in commands)
            {
                var barButtonItem = CreateBarButton(command, handler);
                ribbonPageGroup.ItemLinks.Add(barButtonItem);
            }
        }

        /// <summary>
        /// Создание панели задач на форме
        /// </summary>
        /// <param name="barManager">Страница</param>
        /// <param name="commands">Команды</param>
        /// <param name="handler">Обработчик команд</param>
        public static void CreateBars(BarManager barManager, List<ICommand> commands, ItemClickEventHandler handler)
        {
            if (commands == null || commands.Count == 0)
            {
                return;
            }

            barManager.Items.Clear();
            foreach (var command in commands)
            {
                var barButtonItem = CreateBarButton(command, handler);
                barManager.Items.Add(barButtonItem);
                barManager.Bars[0].AddItem(barButtonItem);
            }
        }

        /// <summary>
        /// Создание пункта меню на основе команды
        /// </summary>
        /// <param name="command">Команда</param>
        /// <param name="handler">Обработчик команд</param>
        /// <returns>Пункт меню</returns>
        private static BarButtonItem CreateBarButton(ICommand command, ItemClickEventHandler handler)
        {
            string caption = null;
            string hint = null;
            Image glyph = null;

            AcquireMetadata(command, ref caption, ref hint, ref glyph);

            var item = new BarButtonItem()
            {
                Caption = caption,
                Hint = hint,
                Tag = command,
                Enabled = command.CanExecute(),
                Glyph = glyph, 
                RibbonStyle = RibbonItemStyles.Large
            };
            item.ItemClick += handler;
            item.ButtonStyle = command.ChildCommands.Count > 0 ? BarButtonStyle.DropDown : BarButtonStyle.Default;

            return item;
        }

        /// <summary>
        /// Метаданные команды
        /// </summary>
        /// <param name="command">Командв</param>
        /// <param name="caption">Заголовок</param>
        /// <param name="hint">Полсказка</param>
        /// <param name="glyph">Картинка</param>
        private static void AcquireMetadata(ICommand command, ref string caption, ref string hint, ref Image glyph)
        {
            ICommandMetadata metadataFromData = command.Data as ICommandMetadata;
            ICommandMetadata metadata = (metadataFromData != null ? metadataFromData : CommandMetadataHolder.Instance.GetMetadata(command.Id));
            if (metadata == null)
            {
                //throw new Exception(FormResources.NoCommandMetadataFormat(command.Id));
                throw new Exception();
            }

            caption = metadata.GetCaption(command.State);
            hint = metadata.GetHint(command.State);
            glyph = metadata.GetGlyph(command.State);
        }
    }
}
