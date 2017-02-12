namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Базовые метаданные команды
	/// </summary>
	public interface ICommandMetadataBase
	{
		/// <summary>
		/// Заголовок команды
		/// </summary>
		string Caption
		{
			get;
		}
		
		/// <summary>
		/// Тултип команды
		/// </summary>
		string Hint
		{
			get;
		}
	}
}
