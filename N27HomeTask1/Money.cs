using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26HomeTask1
{
    internal class Money
    {
        public Money() { }
        public Money(decimal amount, Currency currency, MoneyType type)
        {
            Amount = amount;
            Currency = currency;
            Type = type;
        }

        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public MoneyType Type { get; set; }



        public static Money operator +(Money moneyA, Money moneyB)
        {
            if (moneyA.Type == moneyB.Type)
            {
                ConvertCurrency(moneyA, moneyB);
                return new Money(moneyA.Amount + moneyB.Amount, moneyA.Currency, moneyA.Type);
            }
            ConvertCurrency(moneyA, moneyB);
            return new Money(MathModule(moneyA.Amount, moneyB.Amount) ? moneyA.Amount - moneyB.Amount : moneyB.Amount - moneyA.Amount,
                moneyA.Currency, MathModule(moneyA.Amount, moneyB.Amount) ? MoneyType.InBalance : MoneyType.Loan);
        }

        private static bool MathModule(decimal amountA, decimal amountB)
        {
            if (amountA >= amountB)
            {
                return true;
            }
            return false;
        }

        private static Currency ConvertCurrency(Money moneyA, Money moneyB)
        {
            switch (moneyA.Currency)
            {
                case Currency.UZS:
                    switch (moneyB.Currency)
                    {
                        case Currency.UZS:
                            return moneyB.Currency;
                        case Currency.USD:
                            moneyB.Amount = moneyB.Amount * 12100;
                            moneyB.Currency = moneyA.Currency;
                            return moneyA.Currency;
                        case Currency.RUB:
                            moneyB.Amount = moneyB.Amount * 200;
                            moneyB.Currency = moneyA.Currency;
                            return moneyA.Currency;
                    }
                    break;
                case Currency.USD:
                    switch (moneyB.Currency)
                    {
                        case Currency.USD:
                            return moneyB.Currency;
                        case Currency.UZS:
                            moneyB.Amount = moneyB.Amount / 12100;
                            moneyB.Currency = moneyA.Currency;
                            return moneyA.Currency;
                        case Currency.RUB:
                            moneyB.Amount = moneyB.Amount / 99;
                            moneyB.Currency = moneyA.Currency;
                            return moneyA.Currency;
                    }
                    break;
                case Currency.RUB:
                    switch (moneyB.Currency)
                    {
                        case Currency.RUB:
                            return moneyB.Currency;
                        case Currency.UZS:
                            moneyB.Amount = moneyB.Amount / 200;
                            moneyB.Currency = moneyA.Currency;
                            return moneyA.Currency;
                        case Currency.USD:
                            moneyB.Amount = moneyB.Amount * 99;
                            moneyB.Currency = moneyA.Currency;
                            return moneyA.Currency;
                    }
                    break;
            }
            throw new Exception("Currency ni convert qilishdagi xatolik");
        }
    }
}
