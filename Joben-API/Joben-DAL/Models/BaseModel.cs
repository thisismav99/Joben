using System.ComponentModel.DataAnnotations;

namespace Joben_DAL.Models
{
    public class BaseModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public bool IsActive { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public DateTime CreatedOn { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public required string CreatedBy { get; set; }
    }
}
