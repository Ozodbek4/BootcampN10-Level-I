using N25Home1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Models
{
    internal class Monitor : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrder { get; set; }
        public double Price { get; set; }

        public double DisplaySize { get; set; }
        public double RefreshRate { get; set; }
        public Monitor(double displaySize, double refreshRate)
        {
            DisplaySize = displaySize;
            RefreshRate = refreshRate;
        }
    }
}
