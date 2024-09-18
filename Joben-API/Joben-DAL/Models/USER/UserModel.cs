using Joben_DAL.Models.USER.MISC;

namespace Joben_DAL.Models.USER
{
    public class UserModel : BaseModel
    {
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public int GenderID { get; set; }

        public int CivilStatusID { get; set; }

        public int PositionID { get; set; }

        public virtual required GenderModel Gender { get; set; }

        public virtual required CivilStatusModel CivilStatus { get; set; }

        public virtual required PositionModel Position { get; set; }

        public virtual ICollection<RatingModel> Ratings { get; set; } = new List<RatingModel>();

        public virtual ICollection<AddressModel> Address { get; set; } = new List<AddressModel>();
    }
}
