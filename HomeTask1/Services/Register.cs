using N24HomeTask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    internal class RegisterService
    {
        private IUserService _iUserService;
        private IUserCredentialsService _iUserCredentialsService;
        public RegisterService(IUserService iUserService, IUserCredentialsService iUserCredentialsService)
        {
            _iUserService = iUserService;
            _iUserCredentialsService = iUserCredentialsService;
        }
        public void Register(string firstName, string lastName, string emailAddress, string password)
        {

        }
    }
}
