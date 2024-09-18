namespace Joben_DAL.Models.USER.MISC
{
    public class CivilStatusModel : BaseModel
    {
        public required string CivilStatus { get; set; }

        public virtual ICollection<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
