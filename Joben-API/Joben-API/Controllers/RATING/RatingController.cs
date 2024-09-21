using Joben_BLL.IServices.RATING;
using Joben_DAL.Models.RATING;
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
        public async Task<IActionResult> AddRating([FromBody]RatingModel ratingModel)
        {
            try
            {
                var addRating = await _ratingService.AddRating(ratingModel);

                if (addRating)
                    return Ok(addRating);
                else 
                    return BadRequest();
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
