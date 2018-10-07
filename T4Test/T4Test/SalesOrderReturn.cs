using System;
namespace T4ConsoleApplication.Entities
{	

	public class SalesOrderReturn
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnReason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OrderReturnTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsReissue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SellerID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SellerMemo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime SellerUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid TradeUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string TradeMemo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime TradeUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid QualityUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string QualityMemo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime QualityUpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int OrderReturnStatusValue { get; set; }
		
		
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
		public string OrderReturnInInventoryCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderReturnInInventoryTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderReturnInInventoryUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnCancelCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderReturnCancelTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderReturnCancelUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnCancelReason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnCheckCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderReturnCheckTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderReturnCheckUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SalesOrderID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OutInventoryID { get; set; }
		
		
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
  