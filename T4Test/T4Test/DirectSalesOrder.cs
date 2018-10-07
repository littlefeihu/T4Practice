using System;
namespace T4ConsoleApplication.Entities
{	

	public class DirectSalesOrder
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
		public DateTime CreateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime UpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid UpdateUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DocumentNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SupplyUnitId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseUnitId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int ApprovalStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid FlowId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ApprovalDateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ApprovalUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid CheckUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckUserName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckAddress { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckResulty { get; set; }
		
		
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
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CheckTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Memo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int? CheckStatusValue { get; set; }
		
		 
      
    }
}
  