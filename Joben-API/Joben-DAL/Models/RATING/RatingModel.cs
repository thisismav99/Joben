using Joben_DAL.Models.USER;

namespace Joben_DAL.Models.RATING
{
    public class RatingModel : BaseModel
    {
        public int Rating { get; set; }

        public string? Remark { get; set; }

        public int UserID { get; set; }

        public virtual UserModel? User { get; set; }
    }
}
