
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27Task2.Model
{
    internal class User
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string emailAddress, string password)
        {
            Id = Guid.NewGuid();
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
