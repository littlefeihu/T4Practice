using System;
namespace T4ConsoleApplication.Entities
{	

	public class PurchaseUnit
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DocNumber { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PinyinCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string QualityAgreementDetail { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsQualityAgreementOut { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid QualityAgreementFile { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime QualityAgreemenStartdate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime QualityAgreementOutdate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string QualityCharger { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string AttorneyAattorneyDetail { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid PurchaseDelegaterFile { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PurchaseDelegater { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OutDate { get; set; }
		
		
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
		public string LockRemark { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ReceiveAddress { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DetailedAddress { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid FlowID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DistrictId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Name { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Code { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ContactName { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ContactTel { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Description { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string LegalPerson { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Header { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string BusinessScope { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string SalesAmount { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Fax { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Email { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string WebAddress { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid GSPLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsGSPLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime GSPLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid GMPLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsGMPLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime GMPLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid BusinessLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsBusinessLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime BusinessLicenseeOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid MedicineProductionLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsMedicineProductionLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime MedicineProductionLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid MedicineBusinessLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsMedicineBusinessLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime MedicineBusinessLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid InstrumentsProductionLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsInstrumentsProductionLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime InstrumentsProductionLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid InstrumentsBusinessLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsInstrumentsBusinessLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime InstrumentsBusinessLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid HealthLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsHealthLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime HealthLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid TaxRegisterLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsTaxRegisterLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime TaxRegisterLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid OrganizationCodeLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsOrganizationCodeLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OrganizationCodeLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid FoodCirculateLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsFoodCirculateLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime FoodCirculateLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid MmedicalInstitutionPermitId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsMmedicalInstitutionPermitOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime MmedicalInstitutionPermitOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid LnstitutionLegalPersonLicenseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsLnstitutionLegalPersonLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime LnstitutionLegalPersonLicenseOutDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string TaxRegistrationCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid TaxRegistrationFile { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid AnnualFile { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime LastAnnualDte { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsApproval { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int ApprovalStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid UnitTypeId { get; set; }
		
		
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
		public Guid StoreId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Enabled { get; set; }
		
		
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
		public string Bank { get; set; }
		
		 
      
    }
}
  