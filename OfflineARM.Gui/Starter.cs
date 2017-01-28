using Ninject;
using OfflineARM.Business;
using OfflineARM.Gui.Forms.Orders;
using OfflineARM.Gui.Holders;

namespace OfflineARM.Gui
{
    /// <summary>
    /// Клиетский стартер
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Запускает стартер
        /// </summary>
        public virtual void Start(string[] args = null)
        {
            RegisterInject();
            FillCommandMetadataHolder();
            FillDispatchedCommandHolder();
        }

        /// <summary>
        /// Регистрация контайнеров
        /// </summary>
        private void RegisterInject()
        {
            var container = new StandardKernel();
            IoCBusiness.Instance.Register(container);
            IoCForm.Instance.Register(container);
        }

        /// <summary>
        /// Заполняет хранилище метаданных для команд
        /// </summary>
        private void FillCommandMetadataHolder()
        {
            #region Команды заказов

            CommandMetadataHolder.Instance.SetMetadata(
                OrderCommands.OrderAdd,
                CommandResources.add_32x32,
                CommandResources.OrderAddCommandCaption,
                CommandResources.OrderAddCommandHint);

            #endregion
        }

        /// <summary>
        /// Заполняет хранилище обработчиков для диспетчеризуемых команд
        /// </summary>
        protected void FillDispatchedCommandHolder()
        {
            //DispatchedCommandHolder.Instance.SetType(OrderCommands.OrderAdd, typeof(OrderAddCommandHandler));
        }
    }
}
