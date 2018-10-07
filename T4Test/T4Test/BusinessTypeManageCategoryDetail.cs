using System;
namespace T4ConsoleApplication.Entities
{	

	public class BusinessTypeManageCategoryDetail
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseManageCategoryDetailId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid BusinessTypeId { get; set; }
		
		
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
  