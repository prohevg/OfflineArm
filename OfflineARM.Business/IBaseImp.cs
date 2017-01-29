using OfflineARM.Business.Models;

namespace OfflineARM.Business
{
    /// <summary>
    /// Базовая реализация логики
    /// </summary>
    public interface IBaseImp<TModelEntity>
         where TModelEntity : class, IBaseBusninessModel
    {
        /// <summary>
        /// Найти в БД по Id
        /// </summary>
        /// <param name="id">Id объекта</param>
        /// <returns></returns>
        TModelEntity GetById(int id);

        /// <summary>
        /// Получить все
        /// </summary>
        PagedResult<TModelEntity> GetAll();

        /// <summary>
        /// Добавить в БД
        /// </summary>
        /// <param name="model">Модель</param>
        /// <returns></returns>
        ModelEntityModifyResult Insert(TModelEntity model);

        /// <summary>
        /// ОБновить в БД
        /// </summary>
        /// <param name="model">Модель</param>
        /// <returns></returns>
        ModelEntityModifyResult Update(TModelEntity model);

        /// <summary>
        /// true - если можно удалить из БД
        /// </summary>
        /// <param name="id">Id объекта</param>
        /// <returns></returns>
        bool IsCanDeleteAsync(int id);

        /// <summary>
        /// Удалить из БД
        /// </summary>
        /// <param name="id">Id объекта</param>
        /// <returns></returns>
        ModelEntityModifyResult Delete(int id);
    }
}
