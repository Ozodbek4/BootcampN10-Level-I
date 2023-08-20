using N25Home1.Interfaces;
using N25Home1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Services
{
    internal class OrderService : IOrderService
    {
        public void Order(int id, DebitCard card)
        {
            throw new NotImplementedException();
        }

        public void Order(List<IProduct> filterModel, DebitCard card)
        {
            throw new NotImplementedException();
        }
    }
}
