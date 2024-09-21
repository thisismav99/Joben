using Joben_DAL.Models.RATING;

namespace Joben_BLL.IServices.RATING
{
    public interface IRatingService
    {
        Task<bool> AddRating(RatingModel ratingModel);
    }
}
