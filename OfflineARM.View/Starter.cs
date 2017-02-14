using System.IO;
using System.Reflection;
using Ninject;
using OfflineARM.Controller;
using OfflineARM.Controller.Controllers.Orders.Commands;
using OfflineARM.Controller.Controllers.Settings.Commands;
using OfflineARM.Controller.CustomConfigFile;
using OfflineARM.Controller.CustomConfigFile.Sections;
using OfflineARM.Controller.Holders;
using OfflineARM.View.Forms.Orders.Commands;

namespace OfflineARM.View
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

            ConfigFileDispatcher.Instance.ConfigFile = new AppConfigFile();

            InitializationConfig();

            FillCommandMetadataHolder();
            FillDispatchedCommandHolder();
        }

        /// <summary>
        /// Регистрация контайнеров
        /// </summary>
        private void RegisterInject()
        {
            var container = new StandardKernel();
            IoCControllers.Instance.Register(container);
            IoCView.Instance.Register(container);
        }

        /// <summary>
        /// Заполняет хранилище метаданных для команд
        /// </summary>
        private void FillCommandMetadataHolder()
        {
            #region Команды заказов
            
            CommandMetadataHolder.Instance.SetMetadata(
                OrderCommands.Save,
                CommandResources.save_32x32,
                CommandResources.SaveCommandCaption,
                CommandResources.SaveCommandHint);

            CommandMetadataHolder.Instance.SetMetadata(
                OrderCommands.OrderAdd,
                CommandResources.add_32x32,
                CommandResources.OrderAddCommandCaption,
                CommandResources.OrderAddCommandHint);

            CommandMetadataHolder.Instance.SetMetadata(
                OrderCommands.OrderPrint,
                CommandResources.print_32x32,
                CommandResources.OrderPrintCommandCaption,
                CommandResources.OrderPrintCommandHint);

            #endregion

            #region Команлы настроек приложения

            CommandMetadataHolder.Instance.SetMetadata(
               SettingsCommands.ApplicationSettings,
               CommandResources.properties_32x32,
               CommandResources.ApplicationSettingsCommandCaption,
               CommandResources.ApplicationSettingsCommandHint);

            #endregion
        }

        /// <summary>
        /// Заполняет хранилище обработчиков для диспетчеризуемых команд
        /// </summary>
        protected void FillDispatchedCommandHolder()
        {
            //DispatchedCommandHolder.Instance.SetType(OrderCommands.OrderAdd, typeof(OrderAddCommandHandler));
            DispatchedCommandHolder.Instance.SetType(OrderCommands.OrderPrint, typeof(OrderPrintCommandHandler));
        }

        /// <summary>
        /// Инициализация конфигурационного файла
        /// </summary>
        protected void InitializationConfig()
        {
            var armConfig = IoCControllers.Instance.Get<AppConfigFile>();
            var section = armConfig.GetSection<ArmConfigurationSection>(ArmConfigurationSection.SectionName);

            if (string.IsNullOrWhiteSpace(section.Main.PathToDocuments))
            {
                section.Main.PathToDocuments = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Documents";
                armConfig.Save(section, ArmConfigurationSection.SectionName);
            }
        }
    }
}
