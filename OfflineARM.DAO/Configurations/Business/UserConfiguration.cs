using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Пользователь
    /// </summary>
    public class UserConfiguration : BaseDaoEntityConfiguration<User>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public UserConfiguration()
            : base("Users")
        {
            Property(p => p.Fio)
                .HasMaxLength(255);

            Property(p => p.Login)
               .HasMaxLength(50);

            Property(p => p.Password)
              .HasMaxLength(255);

            Property(p => p.Email)
               .HasMaxLength(50);
        }

        #endregion
    }
}
