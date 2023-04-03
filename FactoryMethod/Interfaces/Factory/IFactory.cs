using FactoryMethod.Interfaces.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces.Factory
{
	internal interface ITicketFactory
	{
		#region Метод, создающий билет
		/// <summary>
		/// Метод, создающий билет.
		/// </summary>
		/// <returns></returns>
		public ITicket GetTicket();
		#endregion
	}
}
