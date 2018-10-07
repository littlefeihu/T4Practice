using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugsInventoryMove
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid createUID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime createTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime updateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int ApprovalStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid flowID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Description { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OriginWareHouseID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid WareHouseID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal quantity { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string drugName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string batchNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid inventoryRecordID { get; set; }
		
		
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
  