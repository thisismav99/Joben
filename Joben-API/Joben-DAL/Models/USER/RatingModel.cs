using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joben_DAL.Models.USER
{
    public class RatingModel : BaseModel
    {
        [Required(ErrorMessage = "This is a required field")]
        public int Rating { get; set; }

        [MaxLength(2000)]
        public string? Remark { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int RaterID { get; set; }

        [ForeignKey("UserID")]
        public virtual required UserModel User { get; set; }

        [ForeignKey("RaterID")]
        public virtual required UserModel Rater { get; set; }
    }
}
