using System;
using System.Threading.Tasks;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Форма клиента юридического лица
    /// </summary>
    public class CustomerLegalController : BaseController, ICustomerLegalController
    {
        #region поля и свойства

        /// <summary>
        /// Форма создания клиента
        /// </summary>
        private ICustomerLegalView _customerLegalView;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _customerLegalView = (ICustomerLegalView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override async void LoadView()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var listActions = await unitOfWork.DictionaryRepositories.BasisActionRepository.GetAllAsync();
                _customerLegalView.LoadActions(listActions);
            }
        }

        #endregion

        #region ICustomerLegalController

        /// <summary>
        /// Покупатель
        /// </summary>
        private CustomerLegal _customer;

        /// <summary>
        /// Покупатель
        /// </summary>
        public CustomerLegal Customer
        {
            get
            {
                return _customer;
            }
        }

        /// <summary>
        /// Действия
        /// </summary>
        /// <returns></returns>
        public Task<PagedResult<BasisAction>> GetAllActionsAsync()
        {
            var unitOfWork = new UnitOfWork();
            return unitOfWork.DictionaryRepositories.BasisActionRepository.GetAllAsync();
        }

        /// <summary>
        /// Сохранить нового клиента
        /// </summary>
        public void SaveNewClient()
        {
            _customer = new CustomerLegal()
            {
                Guid = Guid.NewGuid(),
                BasisAction = _customerLegalView.BasisAction,
                DocDate = _customerLegalView.DocDate,
                DocNumber = _customerLegalView.DocNumber,
                Face = _customerLegalView.Face,
                Inn = _customerLegalView.Inn,
                Kpp = _customerLegalView.Kpp,
                Position = _customerLegalView.Position,
                Address = _customerLegalView.Address,
                Name = _customerLegalView.Name,
                Phone = _customerLegalView.Phone,
            };
        }

        #endregion
    }
}
