using N21Home1.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Classes
{
    internal class PaymePaymentProvider : IPaymentProvider
    {
        public string TransferInterest { get; init; }
        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
        {

        }
        private bool IsValidCard(IDebitCard card)
        {
            return card.CardNumber.All(char.IsDigit) && card.CardNumber.Length == 16;
        }
    }
}
