using System;
namespace T4ConsoleApplication.Entities
{	

	public class DocumentRefuse
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string OrderDocumentID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime createTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Creator { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime updateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInfoID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Source { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string drugName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DocumentNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal quantity { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BatchNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string rsn { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string conclusion { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime conclusionSignDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string conclusionSigner { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int proc { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RefuseQuantity { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal ReceiveQuantity { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PurchaseUnitName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseOrderId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? OutValidDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Specific { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DosageType { get; set; }
		
		
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
  