namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Состояние команды
	/// </summary>
	public class CommandState : ItemData
	{
		/// <summary>
		/// Конструктор
		/// </summary>
		protected CommandState()
		{
		}
		
		/// <summary>
		/// Экземпляр, используемый в качестве состояния простой команды
		/// </summary>
		public static readonly CommandState SimpleCommandState = new CommandState();
	}
}
