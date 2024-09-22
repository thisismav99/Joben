namespace Joben_API.Models.Custom
{
    public class CustomAddressModel : BaseCustomModel
    {
        public required string Street { get; set; }

        public required string Barangay { get; set; }

        public required string City { get; set; }

        public required string Region { get; set; }

        public string? PostalCode { get; set; }

        public required string Country { get; set; }
    }
}
