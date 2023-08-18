
using N27Task2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27Task2.Services
{
    internal class UserService
    {
        private List<User> _users = new List<User>();
        

        public UserService(string? emailAddress = null, string? password = null)
        {
            EnsureAdminExists(emailAddress, password);
        }
        
        public void Add(string emailAddress, string password)
        {
            if (emailAddress == null || password == null || emailAddress == "" || password == "")
            {
                return;
            }
            _users.Add(new User(emailAddress, password));
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        private void EnsureAdminExists(string emailAddress, string password)
        {
            if (emailAddress == null || password == null || emailAddress == "" || password == "")
            {
                return;
            }
            _users.Add(new User(emailAddress, password) { IsAdmin = true});
        }
    }
}
