using System.Threading.Tasks;
using OfflineARM.Business.Models;

namespace OfflineARM.Business.Validators
{
    /// <summary>
    /// Валидатор
    /// </summary>
    /// <typeparam name="T">Тип валидации</typeparam>
    public interface IValidator<T>
        where T : IBaseBusninessModel
    {
        /// <summary>
        /// Валидатор
        /// </summary>
        /// <param name="element">Тип валидации</param>
        /// <returns></returns>
        ValidationResult Validate(T element);
    }
}
