using N24HomeTask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    internal class Register
    {
        private IUserService _iUserService;
        private IUserCredentialsService _iUserCredentialsService;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public Register(IUserService iUserService, IUserCredentialsService iUserCredentialsService)
        {
            _iUserService = iUserService;
            _iUserCredentialsService = iUserCredentialsService;
        }
    }
}
