namespace Joben_API.Models.Custom
{
    public class BaseCustomModel
    {
        public int ID { get; set; }

        public required bool IsActive { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public required string CreatedBy { get; set; }
    }
}
