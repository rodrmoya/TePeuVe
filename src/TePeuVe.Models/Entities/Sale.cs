using System.Collections.Generic;

namespace TePeuVe.Models.Entities
{
	public class Sale
	{
		public int Id { get; internal set; }
		public DateTime Date { get; internal set; }
		public List<SaleItem> Items { get; } = new();
	}

	public class SaleItem
	{
		public Product Product { get; set; }
		public double Quantity { get; set; }
	}
}

