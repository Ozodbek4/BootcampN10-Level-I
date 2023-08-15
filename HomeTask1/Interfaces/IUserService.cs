using N24HomeTask1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Interfaces
{
    internal interface IUserService
    {
        public List<User> Get(int pageSize, int pageToken);
        public List<User> Search(string searchKeyword, int pageSize, int pageToken);
        public List<User> Filter(UserFilterModel userFilterModel);
        public User Add(string firstname, string lastname, string emailAddress);
        public User Update(User userUser, User updateUser);
        public void Delete(int id); 
    }
}
