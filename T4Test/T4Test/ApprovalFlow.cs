using System;
namespace T4ConsoleApplication.Entities
{	

	public class ApprovalFlow
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid Id { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid FlowId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int SubFlowId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public int Status { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public string ChangeNote { get; set; }
		
		
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
		public Guid ApprovalFlowTypeId { get; set; }
		
		
		/// <summary>
		/// 
		/// </summary>		
		public Guid NextNodeID { get; set; }
		
		
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
  