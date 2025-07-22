using Models;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class UserService
    {
        private List<User> _registeredUsers = new();
        public User CurrentUser { get; private set; }

        public bool RegisterUser(User newUser)
        {
            if (_registeredUsers.Any(u => u.Username == newUser.Username))
                return false;

            _registeredUsers.Add(newUser);
            CurrentUser = newUser;
            return true;
        }

        public bool Login(string username, string password)
        {
            var user = _registeredUsers.FirstOrDefault(u =>
                u.Username == username && u.Password == password);

            if (user != null)
            {
                CurrentUser = user;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
