﻿using System;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Спецификация заказа
    /// </summary>
    public interface IOrderSpecificationModel : IBaseBusninessModel
    {
        /// <summary>
        /// Заказ
        /// </summary>
        IOrderModel Order
        {
            get;
            set;
        }

        /// <summary>
        /// Номенклатура
        /// </summary>
        INomenclatureModel Nomenclature
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        ICharacteristicModel Characteristic
        {
            get;
            set;
        }

        /// <summary>
        /// Склад
        /// </summary>
        Guid Stock
        {
            get;
            set;
        }

        /// <summary>
        /// Количество
        /// </summary>
        int Count
        {
            get;
            set;
        }

        /// <summary>
        /// Цена
        /// </summary>
        decimal Price
        {
            get;
            set;
        }

        /// <summary>
        /// % скидки
        /// </summary>
        decimal DiscountProcent
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        decimal DiscountSum
        {
            get;
            set;
        }

        /// <summary>
        /// Итоговая сумма
        /// </summary>
        decimal TotalSum
        {
            get;
        }
    }
}
