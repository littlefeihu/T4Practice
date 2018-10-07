using System;
namespace T4ConsoleApplication.Entities
{	

	public class WarehouseZone
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int PIndex { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Name { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Decription { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Code { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string MnemonicCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Area { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public bool Enabled { get; set; }
		
		
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
		public int WarehouseZoneTypeValue { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid WarehouseId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DictionaryStorageTypeId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid DictionaryMeasurementUnitId { get; set; }
		
		
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
  