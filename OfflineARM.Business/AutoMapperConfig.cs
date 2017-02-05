using AutoMapper;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Business
{
    /// <summary>
    /// Автомеппер моделей на DAO 
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// Конфигурация
        /// </summary>
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Bank, IBankModel>();
                cfg.CreateMap<IBankModel, Bank>();

                cfg.CreateMap<BankProduct, IBankProductModel>();
                cfg.CreateMap<IBankProductModel, BankProduct>();

                cfg.CreateMap<BasisAction, IBasisActionModel>();
                cfg.CreateMap<IBasisActionModel, BasisAction>();

                cfg.CreateMap<Feature, IFeatureModel>();
                cfg.CreateMap<IFeatureModel, Feature>();

                cfg.CreateMap<Nomenclature, INomenclatureModel>();
                cfg.CreateMap<INomenclatureModel, Nomenclature>();

                cfg.CreateMap<OrderStatus, IOrderStatusModel>();
                cfg.CreateMap<IOrderStatusModel, OrderStatus>();

                cfg.CreateMap<Shop, IShopModel>();
                cfg.CreateMap<IShopModel, Shop>();

                cfg.CreateMap<User, IUserModel>();
                cfg.CreateMap<IUserModel, User>();

                cfg.CreateMap<CardPayment, ICardPaymentModel>();
                cfg.CreateMap<ICardPaymentModel, CardPayment>();

                cfg.CreateMap<CashPayment, ICashPaymentModel>();
                cfg.CreateMap<ICashPaymentModel, CashPayment>();

                cfg.CreateMap<CreditPayment, ICreditPaymentModel>();
                cfg.CreateMap<ICreditPaymentModel, CreditPayment>();

                cfg.CreateMap<CustomerLegal, ICustomerLegalModel>();
                cfg.CreateMap<ICustomerLegalModel, CustomerLegal>();

                cfg.CreateMap<CustomerPrivate, ICustomerPrivateModel>();
                cfg.CreateMap<ICustomerPrivateModel, CustomerPrivate>();

                cfg.CreateMap<Exposition, IExpositionModel>();
                cfg.CreateMap<IExpositionModel, Exposition>();

                cfg.CreateMap<Order, IOrderModel>();
                cfg.CreateMap<IOrderModel, Order>();

                cfg.CreateMap<OrderSpecificationItem, IOrderSpecificationItemModel>();
                cfg.CreateMap<IOrderSpecificationItemModel, OrderSpecificationItem>();

                cfg.CreateMap<Delivery, IDeliveryModel>();
                cfg.CreateMap<IDeliveryModel, Delivery>();
            });
        }
    }
}
