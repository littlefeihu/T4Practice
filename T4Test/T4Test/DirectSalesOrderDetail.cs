using System;
namespace T4ConsoleApplication.Entities
{	

	public class DirectSalesOrderDetail
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInfoId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Amount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal QualityAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal UnQualityAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckMethod { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DirectSalesOrderId { get; set; }
		
		
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
		public string BatchNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Origin { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ProductDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OutValidDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string QualityMemo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string UnqualityMemo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal SupplyPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal SalePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal DirectSaleDiff { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int Squence { get; set; }
		
		 
      
    }
}
  