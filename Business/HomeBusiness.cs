using Integration;
using Integration.Entity;
using System.ComponentModel.DataAnnotations;

namespace Business
{
    public class HomeBusiness(IUsersRepository userRepository)
    {
        private readonly IUsersRepository _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));

        public async Task<Users?> GetUsersByIdAsync(int p_id)
        {
            return await _userRepository.GetUsersByIdAsync(p_id);
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task CreateUserAsync(Users p_user)
        {
            string m_email = p_user.Email?.Trim() ?? string.Empty;

            bool m_userExist = await _userRepository.GetUserByEmailAsync(m_email);

            if (m_userExist)
                throw new ValidationException("User already registered.");

            await _userRepository.CreateUserAsync(p_user);
        }

        public async Task DeleteUserAsync(string p_email)
        {
            bool m_userExist = await _userRepository.GetUserByEmailAsync(p_email);

            if (!m_userExist)
                throw new KeyNotFoundException("User not found.");

            await _userRepository.DeleteUserAsync(p_email);            
        }
    }
}