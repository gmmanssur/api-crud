using Integration.Entity;
using Microsoft.EntityFrameworkCore;

namespace Integration.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly HomeIntegration _context;

        public UsersRepository(HomeIntegration context)
        {
            _context = context;
        }

        public async Task<Users?> GetUsersByIdAsync(int p_id)
        {
            return await _context.Users.FindAsync(p_id);
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
