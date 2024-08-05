using System.ComponentModel.DataAnnotations;

namespace Joben_DAL.Models.MISC
{
    public class UserTypeModel : BaseModel
    {
        [Required(ErrorMessage = "This is a required field")]
        [MaxLength(100)]
        public required string UserType { get; set; }
    }
}
