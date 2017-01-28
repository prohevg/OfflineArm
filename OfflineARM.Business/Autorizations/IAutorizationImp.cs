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
    public interface IAutorizationImp
    {
        /// <summary>
        /// true - Если успешно выполнена авторизация
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        bool IsSuccessAutorization(string login, string password);
    }
}
