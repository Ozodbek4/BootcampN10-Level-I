using N25Home1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Models
{
    internal class Chair : IProduct
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrder { get; set; }
        public double Price { get; set; }

        public string MaxWeight { get; set; }
        public string Material { get; set; }

        public Chair(string maxWeight, string material)
        {
            MaxWeight = maxWeight;
            Material = material;
        }
    }
}
