using FactoryMethod.Implementations.Ticket;
using FactoryMethod.Interfaces.Factory;
using FactoryMethod.Interfaces.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Implementations.Factory
{
	internal class EconomTicketFactory : ITicketFactory
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
		/// Конструктор класса фабричного метода, создающего билет класса "эконом".
		/// </summary>
		/// <param name="description">Описание билета.</param>
		/// <param name="price">Цена билета.</param>
		public EconomTicketFactory(string description, decimal price)
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
			var ticket = new EconomClassTicket()
			{
				Description = _description,
				Price = _price
			};

			return ticket;
		}
		#endregion
	}
}
