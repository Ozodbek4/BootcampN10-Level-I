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
        public double TransferInterest { get; init; }
        public PaymePaymentProvider()
        {
            TransferInterest = 1;
        }
        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
        {
            if (IsValidCard(sourceCard.CardNumber) && IsValidCard(destinationCard.CardNumber))
            {
                Console.WriteLine("Karta nomer kiritishda xatolik");
                return;
            }
            if (IsEnoughAmount(sourceCard.Balance, amount) == false)
            {
                Console.WriteLine("Pul yetarli emas");
                return;
            }
            sourceCard.Balance -= amount - amount * TransferInterest / 100;
            destinationCard.Balance += amount;

        }
        private bool IsValidCard(string cardNumber)
        {
            return cardNumber.All(char.IsDigit) && cardNumber.Length == 16;
        }

        private bool IsEnoughAmount (double cardBalance, double amount)
        {
            return cardBalance >= amount;
        }
    }
}
