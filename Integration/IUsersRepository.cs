using Integration.Entity;

namespace Integration
{
    public interface IUsersRepository
    {
        Task<Users?> GetUsersByIdAsync(int p_id);

        Task<List<Users>> GetAllUsersAsync();

        Task<bool> GetUserByEmailAsync(string p_email);

        Task CreateUserAsync(Users p_user);

        Task DeleteUserAsync(string p_email);
    }
}
