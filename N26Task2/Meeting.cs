using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace N26Task2
{
    internal class Meeting
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }

        public Meeting(string name, TimeSpan duration)
        {
            Name = name;
            Duration = duration;
        }
        public static TimeSpan operator +(Meeting value, TimeSpan value2)
        {
            return value.Duration + value2;
        }
    }
}
