using FactoryMethod.Implementations.Ticket;
using FactoryMethod.Interfaces.Factory;
using FactoryMethod.Interfaces.Ticket;

namespace FactoryMethod.Implementations.Factory
{
	internal class BusinessTicketFactory : ITicketFactory
	{
		#region Приватные поля
		/// <summary>
		/// Описание билета.
		/// </summary>
		private readonly string _description;
		/// <summary>
		/// Цена билета.
		/// </summary>
		private readonly decimal _price;
		#endregion

		#region Конструктор
		/// <summary>
		/// Конструктор класса фабричного метода, создающего билет класса "бизнес".
		/// </summary>
		/// <param name="description">Описание билета.</param>
		/// <param name="price">Цена билета.</param>
		public BusinessTicketFactory(string description, decimal price)
		{
			_description = description;
			_price = price;
		}
		#endregion

		#region Метод, создающий билет
		/// <summary>
		/// Метод, создающий билет.
		/// </summary>
		/// <returns></returns>
		public ITicket GetTicket()
		{
			var ticket = new BusinessClassTicket()
			{
				Description = _description,
				Price = _price
			};

			return ticket;
		}
		#endregion
	}
}
