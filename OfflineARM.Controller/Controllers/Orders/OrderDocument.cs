namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Документ для загрузки из оплат
    /// </summary>
    public class OrderDocument
    {
        /// <summary>
        /// Настойщий путь к файлу
        /// </summary>
        private readonly string _path;

        /// <summary>
        /// Поток из файла
        /// </summary>
        private readonly byte[] _fileStream;

        /// <summary>
        /// Настойщий путь к файлу
        /// </summary>
        public string Path
        {
            get
            {
                return _path;
            }
        }

        /// <summary>
        /// Поток из файла
        /// </summary>
        public byte[] FileStream
        {
            get
            {
                return _fileStream;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path">Настойщий путь к файлу</param>
        /// <param name="fileStream">Поток из файла</param>
        public OrderDocument(string path, byte[] fileStream)
        {
            _path = path;
            _fileStream = fileStream;
        }
    }
}