using System;
namespace T4ConsoleApplication.Entities
{	

	public class Delivery
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime DeliveryTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ShippingAddress { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ReceivingCompasnyID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DeliveryAddress { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ManifestNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal DrugsCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int DeliveryMethodValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int TransportMethodValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Principal { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PrincipalPhone { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string TransportCompany { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string VehicleInfo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid VehicleID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int DeliveryStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Memo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsOver { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ReservationTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ReservationOperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ReservationNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime AcceptedTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid AcceptedOperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string AcceptedNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CanceledTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid CanceledOperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CanceledNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime outedTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid outedOperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string outedNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime SignedTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SignedOperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SignedNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ReturnTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ReturnOperatorId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ReturnNo { get; set; }
		
		
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
		public DateTime UpdateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid UpdateUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OutInventoryID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OwnVehicleID { get; set; }
		
		
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
  