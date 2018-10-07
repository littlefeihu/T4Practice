using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugMaintainRecord
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BillDocumentNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ExpirationDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int DrugMaintainTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int CompleteState { get; set; }
		
		
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
  