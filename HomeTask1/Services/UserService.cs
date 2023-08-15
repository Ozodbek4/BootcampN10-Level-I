using N24HomeTask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    internal class UserService : IUserService
    {
        protected List<User> _users = new List<User>()
        {
            new User(1, "Ozodebk", "Anvarjonov", "anvarjonovozodbek416@gmail.com"),
            new User(2, "John", "Doe", "john.doe@example.com"),
            new User(3, "Jane", "Smith", "jane.smith@example.com"),
            new User(4, "Alice", "Johnson", "alice.johnson@example.com"),
            new User(5, "Bob", "Williams", "bob.williams@example.com"),
            new User(6, "Emily", "Davis", "emily.davis@example.com"),
            new User(7, "Daniel", "Brown", "daniel.brown@example.com"),
            new User(8, "Olivia", "Wilson", "olivia.wilson@example.com"),
            new User(9, "James", "Anderson", "james.anderson@example.com"),
            new User(10, "Sophia", "Garcia", "sophia.garcia@example.com"),
            new User(11, "Ethan", "Martinez", "ethan.martinez@example.com"),
            new User(12, "Ava", "Rodriguez", "ava.rodriguez@example.com"),
            new User(13, "Liam", "Lopez", "liam.lopez@example.com"),
            new User(14, "Isabella", "Perez", "isabella.perez@example.com"),
            new User(15, "Noah", "Gonzalez", "noah.gonzalez@example.com"),
            new User(16, "Mia", "Hernandez", "mia.hernandez@example.com"),
            new User(17, "Sophia", "Flores", "sophia.flores@example.com"),
            new User(18, "William", "Gomez", "william.gomez@example.com"),
            new User(19, "Ava", "Rivera", "ava.rivera@example.com"),
            new User(20, "James", "Reyes", "james.reyes@example.com"),
            new User(21, "Oliver", "Morgan", "oliver.morgan@example.com"),
            new User(22, "Emma", "Nguyen", "emma.nguyen@example.com"),
            new User(23, "Benjamin", "Lee", "benjamin.lee@example.com"),
            new User(24, "Amelia", "Turner", "amelia.turner@example.com"),
            new User(25, "Lucas", "Harris", "lucas.harris@example.com"),
            new User(26, "Aria", "Clark", "aria.clark@example.com"),
            new User(27, "Henry", "Lewis", "henry.lewis@example.com"),
            new User(28, "Elizabeth", "Walker", "elizabeth.walker@example.com"),
            new User(29, "Sebastian", "Hall", "sebastian.hall@example.com"),
            new User(30, "Sofia", "Young", "sofia.young@example.com"),
            new User(31, "Michael", "Gonzalez", "michael.gonzalez@example.com"),
            new User(32, "Ava", "Hall", "ava.hall@example.com"),
            new User(33, "William", "Hernandez", "william.hernandez@example.com"),
            new User(34, "Olivia", "Smith", "olivia.smith@example.com"),
            new User(35, "Emma", "Johnson", "emma.johnson@example.com"),
            new User(36, "Noah", "Davis", "noah.davis@example.com"),
            new User(37, "Sophia", "Martinez", "sophia.martinez@example.com"),
            new User(38, "Liam", "Wilson", "liam.wilson@example.com"),
            new User(39, "Isabella", "Brown", "isabella.brown@example.com"),
            new User(40, "James", "Jones", "james.jones@example.com"),
            new User(41, "Ethan", "Taylor", "ethan.taylor@example.com"),
            new User(42, "Ava", "Lewis", "ava.lewis@example.com"),
            new User(43, "Mia", "Moore", "mia.moore@example.com"),
            new User(44, "Oliver", "Anderson", "oliver.anderson@example.com"),
            new User(45, "Sophia", "Thomas", "sophia.thomas@example.com"),
            new User(46, "William", "White", "william.white@example.com"),
            new User(47, "Emma", "Martin", "emma.martin@example.com"),
            new User(48, "Liam", "Jackson", "liam.jackson@example.com"),
            new User(49, "Isabella", "Harris", "isabella.harris@example.com"),
            new User(50, "Noah", "Nelson", "noah.nelson@example.com"),
            new User(51, "Ava", "Perez", "ava.perez@example.com"),
            new User(52, "James", "Thompson", "james.thompson@example.com"),
            new User(53, "Sophia", "Garcia", "sophia.garcia@example.com"),
            new User(54, "Olivia", "Davis", "olivia.davis@example.com"),
            new User(55, "William", "Martinez", "william.martinez@example.com"),
            new User(56, "Emma", "Lopez", "emma.lopez@example.com"),
            new User(57, "Liam", "Wilson", "liam.wilson@example.com"),
            new User(58, "Isabella", "Hernandez", "isabella.hernandez@example.com"),
            new User(59, "Noah", "Smith", "noah.smith@example.com"),
            new User(60, "Ava", "Johnson", "ava.johnson@example.com"),
            new User(61, "James", "Brown", "james.brown@example.com"),
            new User(62, "Sophia", "Taylor", "sophia.taylor@example.com"),
            new User(63, "Olivia", "Lewis", "olivia.lewis@example.com"),
            new User(64, "William", "Moore", "william.moore@example.com"),
            new User(65, "Emma", "Anderson", "emma.anderson@example.com"),
            new User(66, "Liam", "Thomas", "liam.thomas@example.com"),
            new User(67, "Isabella", "White", "isabella.white@example.com"),
            new User(68, "Noah", "Martin", "noah.martin@example.com"),
            new User(69, "Ava", "Jackson", "ava.jackson@example.com"),
            new User(70, "James", "Harris", "james.harris@example.com"),
            new User(71, "Sophia", "Nelson", "sophia.nelson@example.com"),
            new User(72, "Olivia", "Perez", "olivia.perez@example.com"),
            new User(73, "William", "Thompson", "william.thompson@example.com"),
            new User(74, "Emma", "Garcia", "emma.garcia@example.com"),
            new User(75, "Liam", "Davis", "liam.davis@example.com"),
            new User(76, "Isabella", "Martinez", "isabella.martinez@example.com"),
            new User(77, "Noah", "Lopez", "noah.lopez@example.com"),
            new User(78, "Ava", "Wilson", "ava.wilson@example.com"),
            new User(79, "James", "Hernandez", "james.hernandez@example.com"),
            new User(80, "Sophia", "Smith", "sophia.smith@example.com"),
            new User(81, "Olivia", "Johnson", "olivia.johnson@example.com"),
            new User(82, "William", "Brown", "william.brown@example.com"),
            new User(83, "Emma", "Taylor", "emma.taylor@example.com"),
            new User(84, "Liam", "Lewis", "liam.lewis@example.com"),
            new User(85, "Isabella", "Moore", "isabella.moore@example.com"),
            new User(86, "Noah", "Anderson", "noah.anderson@example.com"),
            new User(87, "Ava", "Thomas", "ava.thomas@example.com"),
            new User(88, "James", "White", "james.white@example.com"),
            new User(89, "Sophia", "Martin", "sophia.martin@example.com"),
            new User(90, "Olivia", "Jackson", "olivia.jackson@example.com"),
            new User(91, "William", "Harris", "william.harris@example.com"),
            new User(92, "Emma", "Nelson", "emma.nelson@example.com"),
            new User(93, "Liam", "Perez", "liam.perez@example.com"),
            new User(94, "Isabella", "Thompson", "isabella.thompson@example.com"),
            new User(95, "Noah", "Garcia", "noah.garcia@example.com"),
            new User(96, "Ava", "Davis", "ava.davis@example.com"),
            new User(97, "James", "Martinez", "james.martinez@example.com"),
            new User(98, "Sophia", "Lopez", "sophia.lopez@example.com"),
            new User(99, "Olivia", "Wilson", "olivia.wilson@example.com"),
            new User(100, "William", "Hernandez", "william.hernandez@example.com"),
        };
        public List<User> Get(int pageSize, int pageToken) 
        {
            int totalPages = _users.Count / pageSize;
            return _users.Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
        }
        public List<User> Search(string searchKeyword, int pageSize, int pageToken)
        {
            var result = Get(pageSize, pageToken);
            var needResult = result.Where(searchResult => searchResult.FirstName.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase) 
                    || searchResult.LastName.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase) || searchResult.EmailAddress.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return needResult;
        }
        public List<User> Filter(UserFilterModel userFilterModel)
        {
            var filterUserList = _users.Where(x => !x.IsDeleted);
            var filteredUsers = filterUserList.Where(filter =>
            {
                return (userFilterModel.FirstName is null || userFilterModel.FirstName == filter.FirstName)
                    && (userFilterModel.LastName is null || userFilterModel.LastName == filter.LastName);
            }).ToList();
            return filteredUsers;
        }
        public User Add(string firstname, string lastname, string emailAddress)
        {
            var a = _users.Find(a => a.EmailAddress == emailAddress);
            if (_users.Contains(a))
            {
                throw new Exception("Mavjud email");
            }
            else
            {
                var newId = _users.MaxBy(id => id).Id + 1;
                _users.Add(new User(newId, firstname, lastname, emailAddress));
            }
            return new User(_users.Count() + 1, firstname, lastname, emailAddress);
        }
        public User Update(User lastUser, User updateUser)
        {
            if (_users.Contains(lastUser))
            {
                _users[_users.IndexOf(lastUser)].FirstName = updateUser.FirstName;
                _users[_users.IndexOf(lastUser)].LastName = updateUser.LastName;
                _users[_users.IndexOf(lastUser)].EmailAddress = updateUser.EmailAddress;
                _users[_users.IndexOf(lastUser)].IsDeleted = updateUser.IsDeleted;
                return _users[_users.IndexOf(lastUser)];
            }
            else
            {
                throw new NotImplementedException("Mavjud bo'lgan user");
            }
        }
        public void Delete(int id)
        {
            if (_users.Any(delId => id == delId.Id))
            {
                _users.Find(a =>  a.Id == id).IsDeleted = true;
            }
            else
            {
                throw new Exception("Mavjud Id");
            }
        }
    }
}
