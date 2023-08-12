using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23Home2
{
    internal class User
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public User(string fistName, string lastName, string emailAddress)
        {
            FistName = fistName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }
    }
}
