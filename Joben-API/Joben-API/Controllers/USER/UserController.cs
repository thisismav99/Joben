using Joben_API.Models.ViewModels;
using Joben_BLL.IServices.USER;
using Microsoft.AspNetCore.Mvc;

namespace Joben_API.Controllers.USER
{
    [Route("api/joben/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Variables
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;
        #endregion

        #region Constructor
        public UserController(IUserService userService,
                              ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }
        #endregion

        #region Methods
        [HttpGet("user")]
        public async Task<IActionResult> GetUser([FromQuery]int id)
        {
            try
            {
                var user = await _userService.GetUser(id);

                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();

                return Ok(users);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("user")]
        public async Task<IActionResult> AddUser([FromBody] UserViewModel userViewModel)
        {
            try
            {
                var addUser = await _userService.AddUser(userViewModel.User, userViewModel.Address);

                if(addUser)
                    return Ok(addUser);
                else
                    return BadRequest();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("user")]
        public async Task<IActionResult> UpdateUser([FromBody] UserViewModel userViewModel)
        {
            try
            {
                var updateUser = await _userService.UpdateUser(userViewModel.User, userViewModel.Address);

                if(updateUser)
                    return Ok(updateUser);
                else
                    return BadRequest();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("user")]
        public async Task<IActionResult> DeleteUser([FromQuery]int id)
        {
            try
            {
                var deleteUser = await _userService.DeleteUser(id);

                if(deleteUser)
                    return Ok();
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
