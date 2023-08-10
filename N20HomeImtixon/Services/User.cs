using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20HomeImtixon.Services
{
    internal class User
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public bool IsActived { get; set; }

        //public User(string UserFirstName, string UserLastName, string UserEmail, string UserName)
        //{
        //    this.UserFirstName = UserFirstName;
        //    this.UserLastName = UserLastName;
        //    this.UserEmail = UserEmail;
        //    this.UserName = UserName;
        //    this.IsActived = false;
        //}
    }
}
