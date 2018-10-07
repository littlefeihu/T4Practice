using System;
namespace T4ConsoleApplication.Entities
{	

	public class RetailOrder
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
		public string Code { get; set; }
		
		
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
		public decimal ReduceMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReceivableMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal GotMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ChangeMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RealPayMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int RetailCustomerTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int RetailPaymentMethodValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal TotalRefund { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReturnReduceMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReturnReceivableMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReturnRealReceiveMoney { get; set; }
		
		
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
		public Guid? RetailMember_Id { get; set; }
		
		 
      
    }
}
  