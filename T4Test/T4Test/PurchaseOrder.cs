using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseOrder
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
		public decimal TotalMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PaymentForGoodsMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal AmountOfTaxMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? PaymentDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int InValidDays { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? AllReceiptedDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime PurchasedDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SupplyUnitAccountExecutiveId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid CreateUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
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
		public string ApprovalDecription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? AmountApprovaledTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid AmountApprovalUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string AmountApprovalDecription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int OrderStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid UpdateUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime UpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool DirectMarketing { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ShippingMethod { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SupplyUnitId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ReleatedPurchaseOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? TaxReturnUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsInvoiceArrival { get; set; }
		
		
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
		public decimal? PayMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? PurchaseOrderConcatID { get; set; }
		
		
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
  