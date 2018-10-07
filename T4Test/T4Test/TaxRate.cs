using System;
namespace T4ConsoleApplication.Entities
{	

	public class TaxRate
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Name { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Code { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Enabled { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? UserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? PurchaseUnitID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? SupplyUnitID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? MRate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? IRate { get; set; }
		
		
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
  