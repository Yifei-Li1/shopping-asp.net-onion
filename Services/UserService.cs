using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Domain;

namespace Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetUser(username);
        }
        public async Task<bool> createUser(string username, string password)
        {
            User newUser = new User();
            newUser.UserName = username;
            newUser.Password = password;
            return await _userRepository.CreateUserAsync(newUser);
        }
    }
}
