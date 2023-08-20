using N25Home1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Services
{
    internal class ProductService : IProductService
    {
        List<IProduct> Inventory = new List<IProduct>();
        public void Add(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void Get(IProduct filterModel)
        {
            throw new NotImplementedException();
        }

        public List<string> GetFilterData(string filter)
        {
            throw new NotImplementedException();
        }

        public void Order(int id)
        {
            throw new NotImplementedException();
        }

        public void Return(int id)
        {
            throw new NotImplementedException();
        }
    }
}
