using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseUnitDeliverer
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
		public string IDFile { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string IDNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Tel { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Address { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Birthday { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Gender { get; set; }
		
		
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
		public bool Valid { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Enabled { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseUnitId { get; set; }
		
		
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
  