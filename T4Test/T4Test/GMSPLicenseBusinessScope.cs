using System;
namespace T4ConsoleApplication.Entities
{	

	public class GMSPLicenseBusinessScope
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid LicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid BusinessScopeId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid GSPLicenseId { get; set; }
		
		
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
		
		 
      
    }
}
  