namespace FactoryMethod.Interfaces.Ticket
{
	internal interface ITicket
	{
		#region Свойства
		/// <summary>
		/// Имя билета.
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Описание билета.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Цена билета.
		/// </summary>
		public decimal Price { get; set; }
		#endregion
	}
}
