using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Services
{
    internal class ProductFilterDataModel
    {
        public IEnumerable<string> Collection { get; set; }

        public List<string> ProductTypes(string value)
        {
            return Collection.Select(item => item.GetType().FullName).Distinct().ToList();
        }
    }
}
