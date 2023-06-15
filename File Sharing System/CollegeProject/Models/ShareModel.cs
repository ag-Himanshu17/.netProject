using CollegeProject.Data;
using CollegeProject.Models.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeProject.Models
{
	public class ShareModel : BaseModel
	{
		[ForeignKey("Data")]
		public int Fileid { get; set; }
        public DataModel Data { get; set; }

		[ForeignKey("Reciever")]
        public Guid	 ReciverId { get; set; }
		public ApplicationUser Reciever { get; set; }
		public bool IsCompleted { get; set; }
	

	}
}
