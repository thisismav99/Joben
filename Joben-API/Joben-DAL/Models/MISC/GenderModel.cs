using System.ComponentModel.DataAnnotations;

namespace Joben_DAL.Models.MISC
{
    public class GenderModel : BaseModel
    {
        [Required(ErrorMessage = "This is a required field")]
        [MaxLength(30)]
        public required string Gender { get; set; }
    }
}
