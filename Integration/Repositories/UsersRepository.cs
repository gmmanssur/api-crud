using Integration.Entity;
using Microsoft.EntityFrameworkCore;

namespace Integration.Repositories
{
    public class UsersRepository(HomeIntegration context) : IUsersRepository
    {
        private readonly HomeIntegration _context = context;

        public async Task<Users?> GetUsersByIdAsync(int p_id)
        {
            return await _context.Users.FindAsync(p_id);
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<bool> GetUserByEmailAsync(string p_email)
        {
            return await _context.Users.AnyAsync(u => u.Email == p_email);
        }

        public async Task CreateUserAsync(Users p_user)
        {
            _context.Users.Add(p_user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(string p_email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == p_email);

            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateUserAsync(Users p_user)
        {
            _context.Users.Update(p_user);
            await _context.SaveChangesAsync();
        }
    }
}
