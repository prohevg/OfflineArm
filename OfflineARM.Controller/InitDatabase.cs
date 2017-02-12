using OfflineARM.DAO;

namespace OfflineARM.Controller
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
