using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Task1.Servises
{
    internal class Course
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public Course(string title)
        {
            Title = title;
        }
    }
}
