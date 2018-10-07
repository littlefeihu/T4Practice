using System;
namespace T4ConsoleApplication.Entities
{	

	public class SalesOrderDeliverRecord
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
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
		public DateTime? ApprovaledTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ApprovalUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool HadDelivered { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DeliverTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OutInventoryId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SalesOrderId { get; set; }
		
		
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
  