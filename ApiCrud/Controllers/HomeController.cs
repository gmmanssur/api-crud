using Business;
using Integration.Entity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly HomeBusiness _homeBusiness;

        public HomeController(HomeBusiness p_homeBusiness)
        {
            _homeBusiness = p_homeBusiness;
        }

        /// <summary>
        /// Get user by Id
        /// </summary>
        /// <param name="p_id">User Id</param>
        [HttpGet("Users/{p_id}")]
        public async Task<IActionResult> GetUserById(string p_id)
        {
            try
            {
                if (!int.TryParse(p_id, out int m_id))
                    throw new ValidationException("Invalid Id.");

                var m_user = await _homeBusiness.GetUsersByIdAsync(m_id);

                if (m_user == null)
                    return NotFound("User not found.");

                return Ok(m_user);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet("Users")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var m_users = await _homeBusiness.GetAllUsersAsync();
                return Ok(m_users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="p_user"></param>
        /// <returns></returns>
        [HttpPost("Users")]
        public async Task<IActionResult> CreateUser([FromBody] Users p_user)
        {
            try
            {
                if (p_user == null)
                    return BadRequest("User data is null.");

                await _homeBusiness.CreateUserAsync(p_user);

                return Ok("User created successfully.");
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="p_email"></param>
        /// <returns></returns>
        [HttpDelete("Users/{p_email}")]
        public async Task<IActionResult> DeleteUser(string p_email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(p_email))
                    return BadRequest("Unable to delete user.");

                await _homeBusiness.DeleteUserAsync(p_email);

                return Ok("User removed successfully.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("Users")]
        public async Task<IActionResult> UpdateUser([FromBody] Users p_user)
        {
            try
            {
                if (p_user == null)
                    return BadRequest("User data is null.");

                await _homeBusiness.UpdateUserAsync(p_user);

                return Ok("User updated successfully.");
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
