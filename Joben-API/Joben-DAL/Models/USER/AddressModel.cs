namespace Joben_DAL.Models.USER
{
    public class AddressModel : BaseModel
    {
        public required string Street { get; set; }

        public required string Barangay { get; set; }

        public required string City { get; set; }

        public required string Region { get; set; }

        public string? PostalCode { get; set; }

        public required string Country { get; set; }

        public int UserID { get; set; }

        public virtual required UserModel User { get; set; }
    }
}
