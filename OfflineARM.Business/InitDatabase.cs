using OfflineARM.DAO;

namespace OfflineARM.Business
{
    public class InitDatabaseFull
    {
        public static void Init()
        {
            var d = new InitDaoDatabase();
            d.Init();
        }
    }
}
