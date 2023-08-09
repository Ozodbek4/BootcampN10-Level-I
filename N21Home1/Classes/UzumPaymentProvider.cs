using N21Home1.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Classes
{
    internal class UzumPaymentProvider : IPaymentProvider
    {
        public string TransferInterest { get; init; }
        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
        {

        }
    }
}
