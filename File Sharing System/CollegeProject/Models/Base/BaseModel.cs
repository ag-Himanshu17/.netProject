using CollegeProject.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeProject.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDate { get; set; }

        [ForeignKey("CreatedUser")]
        public Guid? CreatedBy { get; set; }

        public ApplicationUser CreatedUser { get; set; }

    }
}
