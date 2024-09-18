using System.ComponentModel.DataAnnotations;

namespace Joben_DAL.Models
{
    public class BaseModel
    {
        public int ID { get; set; }

        public required bool IsActive { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public required string CreatedBy { get; set; }
    }
}
