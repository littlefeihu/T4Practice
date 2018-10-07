using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugMaintainSet
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int DrugMaintainTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Name { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int Day { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime StartDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int RemindBeforeDay { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int? MinPercent { get; set; }
		
		
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
  