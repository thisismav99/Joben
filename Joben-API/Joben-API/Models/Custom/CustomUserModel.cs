namespace Joben_API.Models.Custom
{
    public class CustomUserModel : BaseCustomModel
    {
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public int GenderID { get; set; }

        public int CivilStatusID { get; set; }

        public int PositionID { get; set; }
    }
}
