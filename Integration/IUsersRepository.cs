using Integration.Entity;

namespace Integration
{
    public interface IUsersRepository
    {
        Task<Users?> GetUsersByIdAsync(int p_id);

        Task<List<Users>> GetAllUsersAsync();
    }
}
