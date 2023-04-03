using FactoryMethod.Interfaces.Ticket;

namespace FactoryMethod.Implementations.Ticket
{
	internal class EconomClassTicket : ITicket
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
		/// Конструктор класса билета класса "эконом".
		/// </summary>
		/// <param name="price">Цена.</param>
		public EconomClassTicket()
		{
			_name = "Билет эконом-класса";
		}
		#endregion
	}
}
