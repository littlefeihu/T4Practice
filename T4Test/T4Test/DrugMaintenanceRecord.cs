using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugMaintenanceRecord
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInventoryRecordId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid UserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime MaintenanceTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid LastUserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime LastMaintenanceTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Memo { get; set; }
		
		
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
  