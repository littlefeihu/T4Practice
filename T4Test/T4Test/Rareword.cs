using System;
namespace T4ConsoleApplication.Entities
{	

	public class Rareword
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PinYin { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Word { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Parts { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Code { get; set; }
		
		
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
  