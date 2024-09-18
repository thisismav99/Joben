namespace Joben_DAL.Models.USER.MISC
{
    public class PositionModel : BaseModel
    {
        public required string Position { get; set; }

        public virtual ICollection<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
