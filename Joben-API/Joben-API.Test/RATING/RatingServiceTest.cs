using FakeItEasy;
using FluentAssertions;
using Joben_BLL.Services.RATING;
using Joben_DAL.Models.RATING;
using Joben_DAL.Repositories.GenericRepository;
using Joben_DAL.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Joben_API.Test.RATING
{
    public class RatingServiceTest
    {
        #region Variables
        private readonly RatingService _ratingService;
        private readonly IRepository<RatingModel> _ratingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<RatingService> _logger;
        #endregion

        #region Constructor
        public RatingServiceTest()
        {
            _ratingRepository = A.Fake<IRepository<RatingModel>>();
            _unitOfWork = A.Fake<IUnitOfWork>();
            _logger = A.Fake<ILogger<RatingService>>();

            _ratingService = new RatingService(_ratingRepository, _unitOfWork, _logger);
        }
        #endregion

        #region Methods
        [Fact]
        public async void RatingService_AddRating_ReturnTrue()
        {
            // Arrange
            var ratingModel = new RatingModel()
            {
                ID = 1,
                Rating = 5,
                Remark = "Wow amazing service!",
                UserID = 1,
                IsActive = true,
                UpdatedOn = null,
                UpdatedBy = null,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "SYSTEM"
            };

            A.CallTo(() => _ratingRepository.Add(ratingModel)).Returns(ratingModel);

            // Act
            var result = await _ratingService.AddRating(ratingModel);

            // Assert
            result.Should().BeTrue();
            result.Should().NotBe(false);
        }
        #endregion
    }
}
