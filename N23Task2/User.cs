using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23Task2
{
    internal class User
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        private bool IsEmailVerified { get; set; }
        private bool IsPhoneVerified { get; set; }


        public User(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
