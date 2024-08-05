using System.ComponentModel.DataAnnotations;

namespace Joben_DAL.Models.MISC
{
    public class CivilStatusModel : BaseModel
    {
        [Required(ErrorMessage = "This is a required field")]
        [MaxLength(30)]
        public required string CivilStatus { get; set; }
    }
}
