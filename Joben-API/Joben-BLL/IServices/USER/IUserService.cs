using Joben_DAL.Models.USER;

namespace Joben_BLL.IServices.USER
{
    public interface IUserService
    {
        Task<bool> AddUser(UserModel userModel, AddressModel addressModel);
        Task<bool> DeleteUser(int id);
        Task<bool> UpdateUser(UserModel userModel, AddressModel addressModel);
        Task<UserModel?> GetUser(int id);
        Task<List<UserModel>?> GetAllUsers();
    }
}
