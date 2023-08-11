using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Task1.Servises
{
    internal class University<TStudent, TId, TGrade> where TStudent : Student<TId, TGrade>
    {
        public List<TStudent> Students = new List<TStudent>();
        public List<Course> Courses = new List<Course>();

        public void EnrollStudent(TStudent student, Course course)
        {
            Students.Add(student);
            Courses.Add(course);
        }

        //public override string ToString()
        //{
        //    return "";
        //}
    }
}
