using Joben_API.Models.Custom;
using Joben_API.Utilities;
using Joben_BLL.IServices.RATING;
using Microsoft.AspNetCore.Mvc;

namespace Joben_API.Controllers.RATING
{
    [Route("api/joben/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        #region Variables
        private readonly IRatingService _ratingService;
        private readonly ILogger<RatingController> _logger;
        #endregion

        #region Constructor
        public RatingController(IRatingService ratingService,
                                ILogger<RatingController> logger)
        {
            _ratingService = ratingService;
            _logger = logger;
        }
        #endregion

        #region Methods
        [HttpPost("rating")]
        public async Task<IActionResult> AddRating([FromBody]CustomRatingModel customRatingModel)
        {
            try
            {
                var convertedRating = APIParameterConverter.ConvertRatingModel(customRatingModel);

                var addRating = await _ratingService.AddRating(convertedRating);

                return Ok(addRating);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        #endregion
    }
}
