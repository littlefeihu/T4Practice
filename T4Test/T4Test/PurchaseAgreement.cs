using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseAgreement
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
		public bool Deleted { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DeleteTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? SupplyUnitSalesman_Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? SupplyUnit_Id { get; set; }
		
		 
      
    }
}
  