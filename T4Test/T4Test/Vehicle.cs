using System;
namespace T4ConsoleApplication.Entities
{	

	public class Vehicle
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? createUID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? CreateTime { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Type { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int VehicleCategoryValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Cubage { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string LicensePlate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Rule { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Other { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Driver { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Status { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsOutCheck { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int? ApprovalStatusValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? FlowID { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DelegateMan { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DelegateCompany { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DelegateTel { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string LiscenceCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DelegateAddr { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string DelegateScope { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? StartDate { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? EndDate { get; set; }
		
		
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
  