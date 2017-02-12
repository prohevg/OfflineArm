using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Controller.Commands
{
    /// <summary>
	/// Пустые данные
	/// </summary>
	public class EmptyData : ItemData
    {
        /// <summary>
        /// Единственный экземпляр пустых данных
        /// </summary>
        public static readonly EmptyData Value = new EmptyData();

        /// <summary>
        /// Закрытый конструктор
        /// </summary>
        private EmptyData()
        {
        }
    }
}
