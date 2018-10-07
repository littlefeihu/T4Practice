using System;
namespace T4ConsoleApplication.Entities
{	

	public class SetSpeicalDrugRecord
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInventoryId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int MaintainDuetime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Reason { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string MaintainEmphasis { get; set; }
		
		
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
  