using System;
namespace T4ConsoleApplication.Entities
{	

	public class OutInventory
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OutInventoryNumber { get; set; }
		
		
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
		public Guid storekeeperId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid ReviewerId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OutInventoryDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Description { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderOutInventoryUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderOutInventoryTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderOutInventoryCheckNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrderOutInventoryCheckUserID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OrderOutInventoryCheckTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal TotalMoney { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal TotalTax { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int OutInventoryTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int OutInventoryStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SalesOrderID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SalesOrderReturnID { get; set; }
		
		
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
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid SpecialDrugSecondChecker { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime SecondCheckDateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SecondeCheckMemo { get; set; }
		
		 
      
    }
}
  