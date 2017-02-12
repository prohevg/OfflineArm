using System;
using System.Collections.Generic;
using System.Linq;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public class OrderPartSpecificController : BaseController, IOrderPartSpecificController
    {
        #region поля и свойства

        /// <summary>
        /// View спецификация заказа
        /// </summary>
        private IOrderPartSpecificView _orderSpecificView;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderSpecificView = (IOrderPartSpecificView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override async void LoadView()
        {
            using (var unit = new UnitOfWork())
            {
                _orderSpecificView.LoadNomenclatureTree();

                var listExpositions = await unit.BusinessesRepositories.ExpositionRepository.GetAllAsync();
                foreach (var exposition in listExpositions.Data)
                {
                    exposition.Nomenclature = unit.DictionaryRepositories.NomenclatureRepository.GetById(exposition.NomenclatureId);
                    exposition.Feature = unit.DictionaryRepositories.FeatureRepository.GetById(exposition.FeatureId);
                }
                _orderSpecificView.LoadExpositions(listExpositions);
            }
        }

        #endregion

        #region  IOrderPartSpecificController

        /// <summary>
        /// Спецификация
        /// </summary>
        private readonly List<OrderSpecificationItem> _specificationItems = new List<OrderSpecificationItem>();
      
        /// <summary>
        /// Спецификация
        /// </summary>
        public List<OrderSpecificationItem> SpecificationItems
        {
            get
            {
                return _specificationItems;
            }
        }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal OrderAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Поиск дочерних номенклатур
        /// </summary>
        /// <param name="parentId">Id родителя</param>
        /// <returns></returns>
        public List<Nomenclature> GetNomenclaturesByParentId(int parentId)
        {
            using (var unit = new UnitOfWork())
            {
                return unit.DictionaryRepositories.NomenclatureRepository.GetAllByParentId(parentId);
            }
        }

        /// <summary>
        /// Проверка наличия дочерних узлов
        /// </summary>
        /// <param name="id">Id родителя</param>
        /// <returns></returns>
        public bool NomenclatureHasChild(int id)
        {
            using (var unit = new UnitOfWork())
            {
                return unit.DictionaryRepositories.NomenclatureRepository.HasChildren(id);
            }
        }

        /// <summary>
        /// Загрузка характеристик для номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">номенклатура Id</param>
        /// <returns></returns>
        public List<Feature> GetFeaturesByNomenclatureId(int nomenclatureId)
        {
            using (var unit = new UnitOfWork())
            {
                return unit.DictionaryRepositories.FeatureRepository.GetByNomenclatureId(nomenclatureId);
            }
        }

        /// <summary>
        /// Добавить характеристику в спецификацию
        /// </summary>
        /// <param name="feature"></param>
        public void AddFeatureToSpecification(Feature feature)
        {
            if (feature == null)
            {
                return;
            }

            if (feature.Nomenclature == null)
            {
                using (var unit = new UnitOfWork())
                {
                    feature.Nomenclature = unit.DictionaryRepositories.NomenclatureRepository.GetById(feature.NomenclatureId);
                }
            }

            var orderSpesific = AddToOrderSpecificationItems(feature.Nomenclature, feature);

            _orderSpecificView.AddToSpecificationGrid(orderSpesific);
        }

        /// <summary>
        /// Добавить экспозицию в спецификацию
        /// </summary>
        /// <param name="exposition"></param>
        public void AddExpositionToSpecification(Exposition exposition)
        {
            if (exposition == null || exposition.Count <= 0)
            {
                return;
            }

            exposition.Count--;

            var orderSpesific = AddToOrderSpecificationItems(exposition.Nomenclature, exposition.Feature);

            _orderSpecificView.AddToSpecificationGrid(orderSpesific);
        }

        /// <summary>
        /// Удалить из спецификации
        /// </summary>
        /// <param name="orderSpecificationItem">Спецификацмя</param>
        public void RemoveFromSpecification(OrderSpecificationItem orderSpecificationItem)
        {
            if (orderSpecificationItem == null)
            {
                return;
            }

            _specificationItems.Remove(orderSpecificationItem);
            _orderSpecificView.RemoveFromSpecificationGrid(orderSpecificationItem);
        }

        #endregion

        #region private

        /// <summary>
        /// Добавить в список спецификаций
        /// </summary>
        /// <param name="nomenclature">Номенклатура</param>
        /// <param name="feature">Характеристика</param>
        /// <returns></returns>
        private OrderSpecificationItem AddToOrderSpecificationItems(Nomenclature nomenclature, Feature feature)
        {
            var exist = _specificationItems.FirstOrDefault(os => os.Nomenclature == nomenclature && os.Feature == feature);
            var orderSpesific = exist ??
                                new OrderSpecificationItem()
                                {
                                    Guid = Guid.NewGuid(),
                                    Nomenclature = nomenclature,
                                    NomenclatureId = nomenclature.Id,
                                    Feature = feature,
                                    FeatureId = feature.Id,
                                    Price = feature.Price,
                                };

            orderSpesific.Count++;
            orderSpesific.PriceWithDiscount = orderSpesific.Price * orderSpesific.Count;

            if (exist == null)
            {
                _specificationItems.Add(orderSpesific);
            }

            this.OrderAmount = _specificationItems.Sum(item => item.PriceWithDiscount);

            return orderSpesific;
        }

        #endregion
    }
}
