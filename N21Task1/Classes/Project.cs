using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Task1.Classes
{
    internal class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks = new List<Task>();

        public void Add(Task task)
        {

        }
    }
}
