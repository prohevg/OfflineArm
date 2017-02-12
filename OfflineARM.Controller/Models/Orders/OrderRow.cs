using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Business.Bases;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Models.Orders
{
    /// <summary>
    /// Строка в таблице заказы
    /// </summary>
    public class OrderRow
    {
        /// <summary>
        /// Guid из 1С   
        /// </summary>
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        ///  Номер заказа
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime DateCreate
        {
            get;
            set;
        }

        /// <summary>
        /// Ответственный
        /// </summary>
        public User User
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент
        /// </summary>
        public Customer Customer
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес доставки в заказе
        /// </summary>
        public Delivery Delivery
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal TotalAmount
        {
            get;
            set;
        }

        public OrderRow(Order order)
        {
            this.Guid = order.Guid;
            this.Number = order.Number;
            this.DateCreate = order.DateCreate;
            this.User = order.User;
            this.Customer = (Customer)order.CustomerPrivate ?? order.CustomerLegal;
            this.Delivery = order.Delivery;
            this.TotalAmount = order.TotalAmount;
        }
    }
}
