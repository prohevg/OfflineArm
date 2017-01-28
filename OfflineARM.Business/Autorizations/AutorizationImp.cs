using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Business.Autorizations
{
    /// <summary>
    /// Логика авторизации
    /// </summary>
    public class AutorizationImp : IAutorizationImp
    {
        /// <summary>
        /// true - Если успешно выполнена авторизация
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public bool IsSuccessAutorization(string login, string password)
        {
            return login == "admin" && password == "admin";
        }
    }
}
