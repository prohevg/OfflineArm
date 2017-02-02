using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Действующего на основании
    /// </summary>
    public class BasisActionModel : BaseBusninessModel, IBasisActionModel
    {
        #region implicit

        public static implicit operator BasisActionModel(BasisAction value)
        {
            var result = new BasisActionModel
            {
                Id = value.Id,
                Guid = value.Guid
            };

            return result;
        }

        public static implicit operator BasisAction(BasisActionModel value)
        {
            var result = new BasisAction
            {
                Id = value.Id,
                Guid = value.Guid
            };

            return result;
        }

        #endregion
    }
}
