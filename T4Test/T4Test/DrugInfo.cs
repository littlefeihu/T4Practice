using System;
namespace T4ConsoleApplication.Entities
{	

	public class DrugInfo
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PermitLicenseCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Code { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DocCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Pinyin { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Description { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BarCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string StandardCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ProductName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ProductEnglishName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ProductGeneralName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ProductOtherName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string FactoryName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string FactoryNameAbbreviation { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PiecemealSpecification { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PiecemealNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal Price { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal NationalSalePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchasePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal SalePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal WholeSalePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal RetailPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal TagPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal LowSalePrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal LimitedLowPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal LimitedUpPrice { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsMedicalInsurance { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsPrescription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsImport { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsMainMaintenance { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsSpecialDrugCategory { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SpecialDrugCategoryCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int ValidPeriod { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string LicensePermissionNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PerformanceStandards { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Package { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PackageAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid WareHouses { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string WareHouseZones { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal BigPackage { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal MiddlePackage { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int SmallPackage { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsApproval { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Valid { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ValidRemark { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsLock { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Enabled { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string LockRemark { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime PermitDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime PermitOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ApprovalDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int MaxInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int MinInventoryCount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Origin { get; set; }
		
		
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
		public string BusinessScopeCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PurchaseManageCategoryDetailCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DrugCategoryCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string MedicalCategoryDetailCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DrugClinicalCategoryCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DictionaryUserDefinedTypeCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DrugStorageTypeCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DictionaryMeasurementUnitCode { get; set; }
		
		
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
		public string DictionaryPiecemealUnitCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid FlowID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int GoodsTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int ApprovalStatusValue { get; set; }
		
		
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
		public string Function { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Ingredient { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string CommendedUser { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string InstEntProductLiscencePermitNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal SaleTax { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal PurchaseTax { get; set; }
		
		 
      
    }
}
  