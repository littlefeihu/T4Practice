using System;
namespace T4ConsoleApplication.Entities
{	

	public class User
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Account { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Pwd { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsSpecialPriceAuth { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SpecialPriceAuth { get; set; }
		
		
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
		public bool Enabled { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid EmployeeId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? PurchaseTaxReturn { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? SalesManageFee { get; set; }
		
		
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
  