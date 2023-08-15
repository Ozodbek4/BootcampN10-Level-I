using N24HomeTask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    internal class UserCredentials : IUserCredentialsService
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public void Add(int userId, string password)
        {

        }
        public void GetByUserId(int userId)
        {

        }
    }
}
