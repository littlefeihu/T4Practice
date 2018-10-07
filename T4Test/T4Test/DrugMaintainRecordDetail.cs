using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugMaintainRecordDetail
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? UserId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DrugInventoryRecordId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? CheckDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BillDocumentNo { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ProductName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DictionaryDosageCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DictionarySpecificationCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal CurrentInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal MaintainCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Price { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Origin { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string LicensePermissionNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BatchNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime PruductDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OutValidDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Manufacturer { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DictionaryMeasurementUnitCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string QualitySituation { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string MaintainResult { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckqualifiedNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CheckResult { get; set; }
		
		
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
  