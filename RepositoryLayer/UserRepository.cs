using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;
using System.Linq;

namespace Repository
{
    public class UserRepository : IUser
    {
        private readonly ProductContext _context;

        public UserRepository()
        {
            _context = new ProductContext();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetUser(string usernameOrEmail)
        {
            
            return await _context.Set<User>().FirstOrDefaultAsync(u => u.UserName == usernameOrEmail||u.Email == usernameOrEmail);
        }
        public async Task<bool> CreateUserAsync(User user)
        {
            if (await _context.Users.AnyAsync(u => u.UserName == user.UserName))
            {
                // Username already exists
                return false;
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true; // User creation was successful
        }
    }
}
