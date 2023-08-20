using N25Home1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Interfaces
{
    internal interface IPaymentService
    {
        bool Checkout(double amount, DebitCard debitCar);
    }
}
