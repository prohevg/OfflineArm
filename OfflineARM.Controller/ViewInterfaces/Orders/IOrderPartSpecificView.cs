using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public interface IOrderPartSpecificView : IBaseView<IOrderPartSpecificController>
    {
        /// <summary>
        /// Заполнение дерева номенклатуры
        /// </summary>
        void LoadNomenclatureTree();

        /// <summary>
        /// Загрукзка экспозиция
        /// </summary>
        /// <param name="data">Список экспозиций</param>
        void LoadExpositions(PagedResult<Exposition> data);

        /// <summary>
        /// Добавить в грид к спецификации
        /// </summary>
        /// <param name="orderSpesific">спецификация</param>
        void AddToSpecificationGrid(OrderSpecificationItem orderSpesific);

        /// <summary>
        /// Удалить из грида спецификации
        /// </summary>
        /// <param name="orderSpesific">спецификация</param>
        void RemoveFromSpecificationGrid(OrderSpecificationItem orderSpesific);
    }
}
