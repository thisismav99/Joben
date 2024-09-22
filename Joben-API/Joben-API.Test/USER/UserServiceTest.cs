using FakeItEasy;
using FluentAssertions;
using Joben_BLL.Services.USER;
using Joben_DAL.Models.USER;
using Joben_DAL.Repositories.GenericRepository;
using Joben_DAL.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Joben_API.Test.USER
{
    public class UserServiceTest
    {
        #region Variables
        private readonly UserService _userService;
        private readonly IRepository<UserModel> _userRepository;
        private readonly IRepository<AddressModel> _addressRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserService> _logger;
        #endregion

        #region Constructor
        public UserServiceTest()
        {
            // Dependecies
            _userRepository = A.Fake<IRepository<UserModel>>();
            _addressRepository = A.Fake<IRepository<AddressModel>>();
            _unitOfWork = A.Fake<IUnitOfWork>();
            _logger = A.Fake<ILogger<UserService>>();

            // SUT
            _userService = new UserService(_userRepository, _addressRepository, _unitOfWork, _logger);
        }
        #endregion

        #region Methods
        [Fact]
        public async void UserService_AddUser_ReturnTrue()
        {
            // Arrange
            var userModel = new UserModel()
            {
                ID = 1,
                FirstName = "Mave Rick",
                MiddleName = "Cabonegro",
                LastName = "Paz",
                Email = "x@gmail.com",
                PhoneNumber = "09XXXXXXXX8",
                GenderID = 1,
                CivilStatusID = 1,
                PositionID = 1,
                IsActive = true,
                UpdatedOn = null,
                UpdatedBy = null,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "SYSTEM"
            };

            var addressModel = new AddressModel()
            {
                ID = 1,
                Street = "Blk 10 Lot 32 Banawe Street",
                Barangay = "Barangay 140",
                City = "Caloocan",
                Region = "NCR",
                PostalCode = "1400",
                Country = "Philippines",
                IsActive = true,
                UpdatedOn = null,
                UpdatedBy = null,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "SYSTEM"
            };

            A.CallTo(() => _userRepository.Add(userModel)).Returns(userModel);
            A.CallTo(() => _addressRepository.Add(addressModel)).Returns(addressModel);

            // Act
            var result = await _userService.AddUser(userModel, addressModel);

            // Assert
            result.Should().BeTrue();
            result.Should().NotBe(false);
        }

        [Fact]
        public async void UserService_DeleteUser_ReturnTrue()
        {
            // Arrange
            var userID = 1;

            A.CallTo(() => _userRepository.Delete(userID));

            // Act
            var result = await _userService.DeleteUser(userID);

            // Assert
            result.Should().BeTrue();
            result.Should().NotBe(false);
        }

        [Fact]
        public async void UserService_UpdateUser_ReturnTrue()
        {
            // Arrange
            var userModel = new UserModel()
            {
                ID = 1,
                FirstName = "Mave Rick",
                MiddleName = "Cabonegro",
                LastName = "Paz",
                Email = "x@gmail.com",
                PhoneNumber = "09XXXXXXXX8",
                GenderID = 1,
                CivilStatusID = 1,
                PositionID = 7,
                IsActive = true,
                UpdatedOn = DateTime.UtcNow,
                UpdatedBy = "Mav",
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "SYSTEM"
            };

            A.CallTo(() => _userRepository.Update(userModel)).Returns(userModel);

            // Act
            var result = await _userService.UpdateUser(userModel);

            // Assert
            result.Should().BeTrue();
            result.Should().NotBe(false);
        }

        [Fact]
        public async void UserService_GetUser_ReturnUserModel()
        {
            // Arrange
            var userID = 1;
            var userModel = new UserModel()
            {
                ID = 1,
                FirstName = "Mave Rick",
                MiddleName = "Cabonegro",
                LastName = "Paz",
                Email = "x@gmail.com",
                PhoneNumber = "09XXXXXXXX8",
                GenderID = 1,
                CivilStatusID = 1,
                PositionID = 7,
                IsActive = true,
                UpdatedOn = null,
                UpdatedBy = null,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "SYSTEM"
            };

            A.CallTo(() => _userRepository.Get(userID)).Returns(userModel);

            // Act
            var result = await _userService.GetUser(userID);

            // Assert
            result.Should().BeOfType<UserModel>();
            result.Should().BeSameAs(userModel);
        }

        [Fact]
        public async void UserService_GetAllUsers_ReturnListUserModel()
        {
            // Arrange
            var listUserModel = new List<UserModel>()
            {
                new UserModel()
                {
                    ID = 1,
                    FirstName = "Mave Rick",
                    MiddleName = "Cabonegro",
                    LastName = "Paz",
                    Email = "x@gmail.com",
                    PhoneNumber = "09XXXXXXXX8",
                    GenderID = 1,
                    CivilStatusID = 1,
                    PositionID = 7,
                    IsActive = true,
                    UpdatedOn = null,
                    UpdatedBy = null,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SYSTEM"
                },
                new UserModel()
                {
                    ID = 2,
                    FirstName = "Jasmin",
                    MiddleName = "Cabonegro",
                    LastName = "Paz",
                    Email = "j@gmail.com",
                    PhoneNumber = "09XXXXXXXX0",
                    GenderID = 1,
                    CivilStatusID = 1,
                    PositionID = 2,
                    IsActive = true,
                    UpdatedOn = null,
                    UpdatedBy = null,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SYSTEM"
                },
            };

            A.CallTo(() => _userRepository.GetAll()).Returns(listUserModel);

            // Act
            var result = await _userService.GetAllUsers();

            // Assert
            result.Should().BeOfType<List<UserModel>>();
            result.Should().BeSameAs(listUserModel);
            result.Should().HaveCount(2);
        }
        #endregion
    }
}
