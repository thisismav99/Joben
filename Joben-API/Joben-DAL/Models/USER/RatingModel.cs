namespace Joben_DAL.Models.USER
{
    public class RatingModel : BaseModel
    {
        public int Rating { get; set; }

        public string? Remark { get; set; }

        public int UserID { get; set; }

        public virtual required UserModel User { get; set; }
    }
}
