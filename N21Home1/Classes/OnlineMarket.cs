using N21Home1.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Classes
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        public OnlineMarket(IPaymentProvider provider)
        {
            _provider = provider;
        }

        public void Add(Product product)
        {

        }

        public void Buy(string name, int number, IDebitCard card)
        {

        }


    }
}
