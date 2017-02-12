using System.ComponentModel;

namespace OfflineARM.View.Helpers
{
    /// <summary>
    /// Хелпер. позволяющиц определять, открыта ли форма в дизайнере
    /// </summary>
    public static class DesignTimeHelper
    {
        public static bool IsInDesignMode
        {
            get
            {
                return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
            }
        }
    }
}
