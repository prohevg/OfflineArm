using OfflineARM.Controller.Base;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Редактирование заказа
    /// </summary>
    public interface IOrderEditController : IBaseCommandController
    {
        /// <summary>
        /// Созданный заказ
        /// </summary>
        /// <returns></returns>
        Order GetOrder();

        /// <summary>
        /// Контроллеры
        /// </summary>
        /// <param name="specificController">Спецификация</param>
        /// <param name="delivaryController">Доставка</param>
        /// <param name="payController">Оплата</param>
        void SetControllers(IOrderPartSpecificController specificController, IOrderPartDeliveryController delivaryController, IOrderPartPayController payController);

        /// <summary>
        /// Установить ответственного
        /// </summary>
        /// <param name="user">Ответсвенный</param>
        User SetResponsable(User user);
    }
}
