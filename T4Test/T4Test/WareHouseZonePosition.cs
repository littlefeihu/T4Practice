using System;
namespace T4ConsoleApplication.Entities
{	

	public class WareHouseZonePosition
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PIndex { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PIndex2 { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Name { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Capacity { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string RowCol { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Memo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid WareHouseZoneId { get; set; }
		
		
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
		public bool Deleted { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DeleteTime { get; set; }
		
		 
      
    }
}
  