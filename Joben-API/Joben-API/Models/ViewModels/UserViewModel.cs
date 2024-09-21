using Joben_DAL.Models.USER;

namespace Joben_API.Models.ViewModels
{
    public class UserViewModel
    {
        public required UserModel User { get; set; }

        public required AddressModel Address { get; set; }
    }
}
