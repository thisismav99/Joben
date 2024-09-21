using Joben_BLL.IServices.USER;
using Joben_DAL.Models.RATING;
using Joben_DAL.Models.USER;
using Joben_DAL.Repositories.GenericRepository;
using Joben_DAL.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Joben_BLL.Services.USER
{
    public class UserService : IUserService
    {
        #region Variables
        private readonly IRepository<UserModel> _userRepository;
        private readonly IRepository<AddressModel> _addressRepository;
        private readonly IRepository<RatingModel> _ratingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserService> _logger;
        #endregion

        #region Constructor
        public UserService(IRepository<UserModel> userRepository,
                           IRepository<AddressModel> addressRepository,
                           IRepository<RatingModel> ratingRepository,
                           IUnitOfWork unitOfWork,
                           ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _ratingRepository = ratingRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        #endregion

        #region Method
        public async Task<bool> AddUser(UserModel userModel, AddressModel addressModel)
        {
            try
            {
                await _unitOfWork.BeginTransaction();
                
                await _userRepository.Add(userModel);
                await _unitOfWork.SaveChanges();

                await _addressRepository.Add(addressModel);
                await _unitOfWork.SaveChanges();

                await _unitOfWork.CommitTransaction();

                return true;
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollbackTransaction();

                _logger.LogError(ex, ex.Message);

                return false;
            }
        }

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var user = await _userRepository.Get(id);

                if (user is not null)
                {
                    await _ratingRepository.Delete(user.Ratings.FirstOrDefault()!.ID);
                    await _unitOfWork.SaveChanges();

                    await _addressRepository.Delete(user.Address.FirstOrDefault()!.ID);
                    await _unitOfWork.SaveChanges();

                    await _userRepository.Delete(user.ID);
                    await _unitOfWork.SaveChanges();

                    await _unitOfWork.CommitTransaction();

                    return true;
                }

                _logger.LogWarning("Something unusual happened");

                return false;
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollbackTransaction();

                _logger.LogError(ex, ex.Message);

                return false;
            }
        }

        public async Task<List<UserModel>?> GetAllUsers()
        {
            return await _userRepository.GetAll();
        }

        public async Task<UserModel?> GetUser(int id)
        {
            return await _userRepository.Get(id);
        }

        public async Task<bool> UpdateUser(UserModel userModel, AddressModel addressModel)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                _userRepository.Update(userModel);
                await _unitOfWork.SaveChanges();

                _addressRepository.Update(addressModel);
                await _unitOfWork.SaveChanges();

                await _unitOfWork.CommitTransaction();

                return true;
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollbackTransaction();

                _logger.LogError(ex, ex.Message);

                return false;
            }
        }
        #endregion
    }
}
