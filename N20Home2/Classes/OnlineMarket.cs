using N21Home1.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Classes
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        private readonly IDebitCard _marketCard;
        private Dictionary<Product, int> _productsAndCount = new Dictionary<Product, int>();
        public OnlineMarket(IPaymentProvider provider, IDebitCard marketCard)
        {
            _provider = provider;
            _marketCard = marketCard;
        }

        public void Add(Product product, int count)
        {
            _productsAndCount.Add(product, count);
        }

        public void Buy(string name, int number, IDebitCard card)
        {
            if(IsEnoughtProductCount(out double pro, name, number))
            {
                _provider.Transfer(card, _marketCard, pro);
            }
        }

        private bool IsEnoughtProductCount(out double pro ,string name, int countUserOffer)
        {
            foreach(var product in _productsAndCount)
            {
                if (product.Key.Name == name)
                {
                    if (product.Value >= countUserOffer)
                    {
                        _productsAndCount[product.Key] -= countUserOffer;
                        pro = product.Key.Price * countUserOffer;
                        return true;
                    }
                    else
                    {
                        pro = 0;
                        Console.WriteLine("Do'konda bunday mahsulot yetali emas");
                        return false;
                    }
                }
            }
            pro = 0;
            Console.WriteLine("Do'konda bunday mahsulot mavjud emas");
            return false;
        }

        public void DisplayBalance(IDebitCard card)
        {
            Console.WriteLine($"{card.Balance}");
        }


    }
}
