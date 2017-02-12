using System.Collections.Generic;
using OfflineARM.Controller.Base;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public interface IOrderPartSpecificController : IBaseController
    {
        /// <summary>
        /// Спецификация
        /// </summary>
        List<OrderSpecificationItem> SpecificationItems { get; }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        decimal OrderAmount { get; set; }

        /// <summary>
        /// Поиск дочерних номенклатур
        /// </summary>
        /// <param name="parentId">Id родителя</param>
        /// <returns></returns>
        List<Nomenclature> GetNomenclaturesByParentId(int parentId);

        /// <summary>
        /// Проверка наличия дочерних узлов
        /// </summary>
        /// <param name="id">Id родителя</param>
        /// <returns></returns>
        bool NomenclatureHasChild(int id);

        /// <summary>
        /// Загрузка характеристик для номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">номенклатура Id</param>
        /// <returns></returns>
        List<Feature> GetFeaturesByNomenclatureId(int nomenclatureId);

        /// <summary>
        /// Добавить характеристику в спецификацию
        /// </summary>
        /// <param name="feature"></param>
        void AddFeatureToSpecification(Feature feature);

        /// <summary>
        /// Добавить экспозицию в спецификацию
        /// </summary>
        /// <param name="exposition"></param>
        void AddExpositionToSpecification(Exposition exposition);

        /// <summary>
        /// Удалить из спецификации
        /// </summary>
        /// <param name="orderSpecificationItem">Спецификацмя</param>
        void RemoveFromSpecification(OrderSpecificationItem orderSpecificationItem);
    }
}
