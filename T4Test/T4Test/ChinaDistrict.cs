using System;
namespace T4ConsoleApplication.Entities
{	

	public class ChinaDistrict
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Name { get; set; }
		
		
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
		public int? ProvincesId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string PostCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string AreaCode { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int? CitiesId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string Discriminator { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? Provinces_Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid? Cities_Id { get; set; }
		
		 
      
    }
}
  