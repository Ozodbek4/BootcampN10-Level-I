using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28Home1.Interfaces
{
    internal interface IEvent
    {
        int Id { get; set; }
        string Name { get; set; }
        DateOnly Date { get; set; }
    }
}
