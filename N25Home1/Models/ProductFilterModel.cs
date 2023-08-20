using N25Home1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Models
{
    internal class ProductFilterModel
    {
        public List<IProduct> Inventory = new List<IProduct>();

        public void Add(IProduct product) { }

        public List<string> GetFilterData(string filter)
        {
            return null;
        }
    }
}
