using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugInventoryRecordHis
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInventoryRecordId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OperatorName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePricce { get; set; }
		
		
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
		public bool IsOutValidDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal InInventoryCount { get; set; }
		
		
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
		public decimal CurrentInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RetailCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal DismantingAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ChangeAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RetailDismantingAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal OnRetailCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal CanSaleNum { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Valid { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal DurgInventoryTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInfoId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchaseReturnNumber { get; set; }
		
		
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
  