using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Interfaceses
{
    internal interface IPaymentProvider
    {
        string  TransferInterest { get; init; }
        void Transfer(string sourceCard, string destinationCard, double amount);
    }
}
