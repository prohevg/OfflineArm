using System.Threading.Tasks;

namespace OfflineARM.Controller.Validators
{
    /// <summary>
    /// Валидатор
    /// </summary>
    /// <typeparam name="T">Тип валидации</typeparam>
    public interface IValidator<T>
    {
        /// <summary>
        /// Валидатор
        /// </summary>
        /// <param name="element">Тип валидации</param>
        /// <returns></returns>
        ValidationResult Validate(T element);
    }
}
