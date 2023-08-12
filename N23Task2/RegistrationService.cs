using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23Task2
{
    internal class RegistrationService: User
    {
        private Dictionary<string, string> _collection = new Dictionary<string, string>();
        public RegistrationService(string emailAddress, string password)
            :base(emailAddress, password)
        {
            _collection.Add(emailAddress, password);
        }
        public void Add(string emailAddress, string password)
        {
            if (_collection.Any(email => email.Key == emailAddress))
            {
                Console.WriteLine("Bu email dasturda allaqachon mavjud");
            }
            else
            {
                _collection.Add(emailAddress, password);
            }
        }
    }
}
