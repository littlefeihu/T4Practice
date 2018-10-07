using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseOrderReturn
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DocumentNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid CheckerUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckerSuggest { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? CheckerUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid QualityUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string QualitySuggest { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? QualityUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid GeneralManagerUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string GeneralManagerSuggest { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? GeneralManagerUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid FinanceDepartmentUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string FinanceDepartmentSuggest { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? FinanceDepartmentUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int OrderStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
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
		public Guid PurchaseOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid RelatedOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string RelatedOrderDocumentNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int RelatedOrderTypeValue { get; set; }
		
		
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
		public Guid? PurchasingPlan_Id { get; set; }
		
		 
      
    }
}
  