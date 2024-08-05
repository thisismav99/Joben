using Joben_DAL.Models.MISC;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joben_DAL.Models.USER
{
    public class UserModel : BaseModel
    {
        [Required(ErrorMessage = "This is a required field")]
        [MaxLength(100)]
        public required string FirstName { get; set; }

        [MaxLength(100)]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [MaxLength(100)]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int GenderID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int CivilStatusID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int UserTypeID { get; set; }

        [ForeignKey("GenderID")]
        public virtual required GenderModel Gender { get; set; }

        [ForeignKey("CivilStatusID")]
        public virtual required CivilStatusModel CivilStatus { get; set; }

        [ForeignKey("UserTypeID")]
        public virtual required UserTypeModel UserType { get; set; }
    }
}
