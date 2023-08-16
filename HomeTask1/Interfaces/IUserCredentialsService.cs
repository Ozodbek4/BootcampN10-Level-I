using N24HomeTask1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Interfaces
{
    internal interface IUserCredentialsService
    {

        public UserCredentials Add(int userId, string password);
        public UserCredentials GetByUserId(int userId);
    }
}
