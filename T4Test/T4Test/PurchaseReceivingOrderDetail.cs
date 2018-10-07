using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseReceivingOrderDetail
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
		public decimal Amount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ActualAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReceiveAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RejectAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string RejectReason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string RejectTrace { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsCompanyPurchase { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string TransportMethod { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsTransportMethod { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string TransportTemperature { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string TemperatureStatus { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsTransportTemperature { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int CheckResult { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInfoId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseReceivingOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? sequence { get; set; }
		
		
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
  