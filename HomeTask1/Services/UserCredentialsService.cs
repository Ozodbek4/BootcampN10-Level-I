using N24HomeTask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    internal class UserCredentialsService : IUserCredentialsService
    {
        private List<UserCredentials> _usersCredentials = new List<UserCredentials>();
        public UserCredentials Add(int userId, string password)
        {
            Regex regex = new Regex("^(?=.*\\d)(?=.*[A-Z]).{9,}$");
            if (regex.IsMatch(password))
            {
                if(_usersCredentials ==  null || _usersCredentials.Count == 0)
                {
                    _usersCredentials.Add(new UserCredentials(1,password, userId));
                }
                else
                {
                    var userCredentialId = _usersCredentials.MaxBy(x => x.Id).Id + 1;
                    _usersCredentials.Add(new UserCredentials(1, password, userId));
                }
                return _usersCredentials[_usersCredentials.Count - 1];
            }
            else
            {
                throw new ArgumentException("Notog'ri password");
            }
        }
        public UserCredentials GetByUserId(int userId)  
        {
            var credential = _usersCredentials.Find(need => need.UserId == userId);
            return credential;
        }
    }
}
