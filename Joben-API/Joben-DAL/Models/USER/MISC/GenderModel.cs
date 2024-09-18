namespace Joben_DAL.Models.USER.MISC
{
    public class GenderModel : BaseModel
    {
        public required string Gender { get; set; }

        public virtual ICollection<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
