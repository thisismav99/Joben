using Joben_API.Models.Custom;

namespace Joben_API.Models.ViewModels
{
    public class UserViewModel
    {
        public required CustomUserModel User { get; set; }

        public required CustomAddressModel Address { get; set; }
    }
}
