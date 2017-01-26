using Ninject;

namespace OfflineARM.Business
{
    /// <summary>
	/// Клиетский стартер
	/// </summary>
	public class Starter
    {
        /// <summary>
        /// Запускает стартер
        /// </summary>
        public virtual void Start(string[] args)
        {
            var container = new StandardKernel();
            IoCBusiness.Instance.Register(container);
        }
    }
}
