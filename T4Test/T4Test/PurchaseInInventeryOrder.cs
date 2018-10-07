using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseInInventeryOrder
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
		public DateTime OperateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OperateUserId { get; set; }
		
		
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
  