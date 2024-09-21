using Joben_BLL.IServices.RATING;
using Joben_DAL.Models.RATING;
using Joben_DAL.Repositories.GenericRepository;
using Joben_DAL.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Joben_BLL.Services.RATING
{
    public class RatingService : IRatingService
    {
        #region Variables
        private readonly IRepository<RatingModel> _ratingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<RatingService> _logger;
        #endregion

        #region Constructor
        public RatingService(IRepository<RatingModel> ratingRepository,
                            IUnitOfWork unitOfWork,
                            ILogger<RatingService> logger)
        {
            _ratingRepository = ratingRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        #endregion

        #region Methods
        public async Task<bool> AddRating(RatingModel ratingModel)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                await _ratingRepository.Add(ratingModel);
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
