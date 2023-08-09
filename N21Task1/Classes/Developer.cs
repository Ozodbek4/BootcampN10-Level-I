using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Task1.Classes
{
    internal class Developer
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public List<Project> AssignedProjects = new List<Project>();
        public List<string> Comments = new List<string>();
    }
}
