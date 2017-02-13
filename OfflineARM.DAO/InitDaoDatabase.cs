using System;
using System.Linq;
using System.Threading.Tasks;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO
{
    public class InitDaoDatabase
    {
        public void Init()
        {
            Task.Factory.StartNew(() =>
            {
                using (var unit = new ApplicationDbContext())
                {
                    if (unit.Set<User>().Any())
                    {
                        return;
                    }
                }

                AddUserShopOrgs();
                AddOrderStatus();
                AddBankAndPoduct();
                AddCustomerPrivate();
                AddCustomerLegal();
                AddNomencl();
            });
        }

        /// <summary>
        /// Магазины
        /// </summary>
        private void AddOrderStatus()
        {
            var context = new ApplicationDbContext();

            var orderStatus = new OrderStatus()
            {
                Guid = Guid.NewGuid(),
                Name = "Создан"
            };

            context.Set<OrderStatus>().Add(orderStatus);
            context.SaveChanges();

            var orderStatus1 = new OrderStatus()
            {
                Guid = Guid.NewGuid(),
                Name = "В работе"
            };

            context.Set<OrderStatus>().Add(orderStatus1);
            context.SaveChanges();

            var orderStatus2 = new OrderStatus()
            {
                Guid = Guid.NewGuid(),
                Name = "Выполнен"
            };

            context.Set<OrderStatus>().Add(orderStatus2);
            context.SaveChanges();

        }

        /// <summary>
        /// Магазины
        /// </summary>
        private void AddUserShopOrgs()
        {
            var context = new ApplicationDbContext();

            var org = new Organization
            {
                Guid = Guid.NewGuid(),
                Name = "Саратов-Организация"
            };

            context.Set<Organization>().Add(org);
            context.SaveChanges();

            var city = new City()
            {
                Guid = Guid.NewGuid(),
                Name = "Саратов"
            };

            context.Set<City>().Add(city);
            context.SaveChanges();

            var shop = new Shop()
            {
                Guid = Guid.NewGuid(),
                Address = "г. Саратов, ул. Чапаева", 
                CityId = city.Id,
                OrganizationId = org.Id,
                Name = "Магазин на Чапаева", 
            };

            context.Set<Shop>().Add(shop);
            context.SaveChanges();

            var shop2 = new Shop()
            {
                Guid = Guid.NewGuid(),
                Address = "г. Саратов, ул. Некрасова",
                CityId = city.Id,
                OrganizationId = org.Id,
                Name = "Магазин на Некрасова",
            };

            context.Set<Shop>().Add(shop2);
            context.SaveChanges();

            var user = new User()
            {
                Guid = Guid.NewGuid(),
                Login = "admin",
                Fio = "admin",
                ShopId = shop.Id
            };

            context.Set<User>().Add(user);
            context.SaveChanges();

            var user2 = new User()
            {
                Guid = Guid.NewGuid(),
                Login = "test",
                Fio = "test",
                ShopId = shop.Id
            };

            context.Set<User>().Add(user2);
            context.SaveChanges();

            context.Dispose();
        }

        /// <summary>
        /// Банк и продукт
        /// </summary>
        private void AddBankAndPoduct()
        {
            using (var uf = new ApplicationDbContext())
            {
                var bank = new Bank()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Банк_сбер"
                };

                uf.Set<Bank>().Add(bank);
                uf.SaveChanges();

                var bnkProduct = new BankProduct()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Продукт 1",
                    BankId = bank.Id
                };

                var bnkProduct2 = new BankProduct()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Продукт 2",
                    BankId = bank.Id
                };

                uf.Set<BankProduct>().Add(bnkProduct);
                uf.Set<BankProduct>().Add(bnkProduct2);
                uf.SaveChanges();


                var bank2 = new Bank()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Банк_москва"
                };

                uf.Set<Bank>().Add(bank2);
                uf.SaveChanges();

                var bnkProduct12 = new BankProduct()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Продукт Москва 1",
                    BankId = bank.Id
                };

                var bnkProduct22 = new BankProduct()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Продукт Москва 2",
                    BankId = bank.Id
                };

                uf.Set<BankProduct>().Add(bnkProduct12);
                uf.Set<BankProduct>().Add(bnkProduct22);
                uf.SaveChanges();
            }
        }

        /// <summary>
        /// Добавить частных клиентов
        /// </summary>
        private void AddCustomerPrivate()
        {
            using (var uf = new ApplicationDbContext())
            {
                var client = new CustomerPrivate()
                {
                    Guid = Guid.NewGuid(),
                    Address = "г. Саратов, ул. Техническая",
                    Name = "Петров",
                    Phone = "(927)111-11-11"
                };

                uf.Set<CustomerPrivate>().Add(client);
                uf.SaveChanges();

                var client2 = new CustomerPrivate()
                {
                    Guid = Guid.NewGuid(),
                    Address = "г. Саратов, ул. Чернышевского",
                    Name = "Иванов",
                    Phone = "(8452)222-22-22"
                };

                uf.Set<CustomerPrivate>().Add(client2);
                uf.SaveChanges();
            }
        }

        /// <summary>
        /// Добавить юр клиентов
        /// </summary>
        private void AddCustomerLegal()
        {
            using (var uf = new ApplicationDbContext())
            {
                var basisAction = new BasisAction()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Какое-то действие",
                };
                uf.Set<BasisAction>().Add(basisAction);
                uf.SaveChanges();


                var client = new CustomerLegal()
                {
                    Guid = Guid.NewGuid(),
                    Address = "г. Саратов, ул. Техническая",
                    Name = "Пиво балтика",
                    Phone = "(8452)11-11-11",
                    BasisActionId = basisAction.Id,
                    DocDate = DateTime.Now,
                    DocNumber = "# 123456",
                    Face = "Директор",
                    Inn = "123456",
                    Kpp = "654321",
                    Position = "Директор"
                };

                uf.Set<CustomerLegal>().Add(client);
                uf.SaveChanges();

                var client2 = new CustomerLegal()
                {
                    Guid = Guid.NewGuid(),
                    Address = "г. Энгельс, ул. Техническая",
                    Name = "ООО керамика",
                    Phone = "(8453)22-11-11",
                    BasisActionId = basisAction.Id,
                    DocDate = DateTime.Now,
                    DocNumber = "# авввву",
                    Face = "Директор",
                    Inn = "123456",
                    Kpp = "654321",
                    Position = "Директор"
                };

                uf.Set<CustomerLegal>().Add(client2);
                uf.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddNomencl()
        {
            using (var uf = new ApplicationDbContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    var mainGuid = Guid.NewGuid();
                    var newNomencl = new Nomenclature
                    {
                        Guid = mainGuid,
                        Name = "Диван_" + mainGuid.ToString().Substring(0, 4)
                    };

                    uf.Set<Nomenclature>().Add(newNomencl);
                    uf.SaveChanges();

                    for (int j = 0; j < 2; j++)
                    {
                        var childGuid = Guid.NewGuid();
                        var childNomencl = new Nomenclature
                        {
                            Guid = childGuid,
                            Parent = newNomencl,
                            Name = newNomencl.Name + "_Inner_" + childGuid.ToString().Substring(0, 4)
                        };

                        uf.Set<Nomenclature>().Add(childNomencl);
                        uf.SaveChanges();

                        AddCharact(childNomencl, uf);
                    }
                }
            }
        }

        private void AddCharact(Nomenclature nomecModel, ApplicationDbContext uf)
        {
            for (int i = 0; i < 3; i++)
            {
                var guid = Guid.NewGuid();
                var newCharact = new Feature()
                {
                    Guid = guid,
                    Nomenclature = nomecModel,
                    Name = "Характер_" + guid.ToString().Substring(0, 4),
                    Price = 100,
                };

                uf.Set<Feature>().Add(newCharact);
                uf.SaveChanges();

                AddExposit(newCharact, uf);
            }
        }

        private void AddExposit(Feature charModel, ApplicationDbContext uf)
        {
            for (int i = 0; i < 2; i++)
            {
                var guid = Guid.NewGuid();
                var newExpo = new Exposition()
                {
                    Guid = guid,
                    Nomenclature = charModel.Nomenclature,
                    Feature = charModel,
                    IsEnabled = i == 1,
                    Count = i,
                    Price = 100
                };

                uf.Set<Exposition>().Add(newExpo);
                uf.SaveChanges();
            }
        }
    }
}
