using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Task1.Servises
{
    internal class Student<TId, TGrade>
    {
        public TId Id { get; set; }
        public TGrade Grade { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }

        public Student(TId id, TGrade grade, string name)
        {
            Id = id;
            Grade = grade;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name} {Grade} {Id}";
        }
    }
}
