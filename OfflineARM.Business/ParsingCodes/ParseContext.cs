using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Business.ParsingCodes
{
    /// <summary>
    /// Парсинг в зависимости от строки
    /// </summary>
    public class ParseContext
    {
        /// <summary>
        /// Выполнить парсинг строки
        /// </summary>
        /// <param name="code">Штрихкод</param>
        public static void Execute(string code)
        {
            code = code.ToUpper();
           
        }
    }
}
