using System.Data.Entity;

namespace OfflineARM.DAO
{
    public class FirebirdDbConfiguration : DbConfiguration
    {
        public FirebirdDbConfiguration()
        {
            SetMigrationSqlGenerator("FirebirdSql.Data.FirebirdClient", () => new FirebirdSqlGenerator());
        }
    }
}
