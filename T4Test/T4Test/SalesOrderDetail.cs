using System;
namespace T4ConsoleApplication.Entities
{	

	public class SalesOrderDetail
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int Index { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid CreateUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid UpdateUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime UpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string productName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string productCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BatchNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Amount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal UnitPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ActualUnitPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Price { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string MeasurementUnit { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SpecificationCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DictionaryDosageCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Origin { get; set; }
		
		
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
		public string FactoryName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Description { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReturnAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ChangeAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal OutAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OutInventoryDetailID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SalesOrderID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInventoryRecordID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Deleted { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DeleteTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Discount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePrice { get; set; }
		
		 
      
    }
}
  