using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseInInventeryOrderDetail
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInfoId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BatchNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime PruductDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OutValidDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ArrivalAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ArrivalDateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid WarehouseZoneId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? sequence { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseInInventeryOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid WarehouseZonePositionId { get; set; }
		
		
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
  