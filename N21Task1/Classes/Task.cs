using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Task1.Classes
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }
        public List<string> Comments { get; set; }
    }
}
