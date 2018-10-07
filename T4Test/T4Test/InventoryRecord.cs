using System;
namespace T4ConsoleApplication.Entities
{	

	public class InventoryRecord
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal MaxInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal MinInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal CurrentInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal SalesCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal OnSalesOrderCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RetailCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal OnRetailCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal DismantingAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RetailDismantingAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInfoId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DrugInfoCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Deleted { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DeleteTime { get; set; }
		
		 
      
    }
}
  