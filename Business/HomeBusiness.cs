using Integration;
using Integration.Entity;

namespace Business
{
    public class HomeBusiness
    {
        private readonly IUsersRepository _userRepository;

        public HomeBusiness() { }

        public HomeBusiness(IUsersRepository clienteRepository)
        {
            _userRepository = clienteRepository;
        }

        public async Task<Users?> GetUsersByIdAsync(int p_id)
        {
            return await _userRepository.GetUsersByIdAsync(p_id);
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
    }
}