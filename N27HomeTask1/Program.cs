using N26HomeTask1;

List<Money> moneyList = new List<Money>
{
    new Money { Amount = 100.00m, Type = MoneyType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 50.00m, Type = MoneyType.InBalance, Currency = Currency.USD },
    new Money { Amount = 200.00m, Type = MoneyType.Loan, Currency = Currency.RUB },
    new Money { Amount = 75.00m, Type = MoneyType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 150.00m, Type = MoneyType.Loan, Currency = Currency.USD },
    new Money { Amount = 25.00m, Type = MoneyType.InBalance, Currency = Currency.RUB },
    new Money { Amount = 50.00m, Type = MoneyType.InBalance, Currency = Currency.USD },
    new Money { Amount = 10.00m, Type = MoneyType.Loan, Currency = Currency.UZS },
    new Money { Amount = 5.00m, Type = MoneyType.Loan, Currency = Currency.RUB },
    new Money { Amount = 100.00m, Type = MoneyType.InBalance, Currency = Currency.UZS }
};

for (int i = 0; i < moneyList.Count - 1; i++)
{
    for (int j = i; j < moneyList.Count; j++)
    {
        var obj1 = moneyList[i] + moneyList[j];
        Console.WriteLine($"{obj1.Amount} - {obj1.Currency} - {obj1.Type}\n");

    }
}

