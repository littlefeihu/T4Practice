using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseOrderReturnDetail
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
		public decimal ReturnAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ReturnReason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsReissue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReissueAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseOrderReturnId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PurchaseReturnSourceValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid RelatedOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int ReturnHandledMethodValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
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
  