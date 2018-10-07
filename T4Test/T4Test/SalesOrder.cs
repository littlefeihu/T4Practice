using System;
namespace T4ConsoleApplication.Entities
{	

	public class SalesOrder
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
		public string SalerName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime SaleDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Description { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal TotalMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool AllDelivered { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? AllDeliverTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int SalesDrugTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PickUpGoodTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PickUpMan { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PurchaseUnitMan { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseUnitManID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int OrderStatusValue { get; set; }
		
		
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
		public DateTime? CancelTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid CancelUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CancelReason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderCancelCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderBalanceCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? BalanceTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid BalanceUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BalanceReason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid payMentMethodID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderOutInventoryCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderOutInventoryUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderOutInventoryTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderOutInventoryCheckCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderOutInventoryCheckUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderOutInventoryCheckTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderReturnTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderReturnUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderReturnReason { get; set; }
		
		
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
		public string OrderDirectReturnCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderDirectReturnTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderDirectReturnUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsNeedInvoice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsInvoice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? ReceivedMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? InvoiceMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsPayed { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OutInventoryId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseUnitId { get; set; }
		
		
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
		public string VATCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string VATNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal VATRate { get; set; }
		
		 
      
    }
}
  