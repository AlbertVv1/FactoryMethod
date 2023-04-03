using FactoryMethod.Interfaces.Ticket;

namespace FactoryMethod.Implementations.Ticket
{
	internal class BusinessClassTicket: ITicket
	{
		#region Свойства
		/// <summary>
		/// Имя билета.
		/// </summary>
		public string Name => _name;
		/// <summary>
		/// Описание билета.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Цена билета.
		/// </summary>
		public decimal Price { get; set; }
		#endregion

		#region Приватное поле
		/// <summary>
		/// Имя билета.
		/// </summary>
		private readonly string _name;
		#endregion

		#region Конструктор
		/// <summary>
		/// Конструктор класса билета класса "бизнес".
		/// </summary>
		/// <param name="price">Цена.</param>
		public BusinessClassTicket()
		{
			_name = "Билет бизнес-класса";
		}
		#endregion
	}
}
