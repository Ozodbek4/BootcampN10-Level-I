﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Interfaceses
{
    internal interface IPaymentProvider
    {
        double TransferInterest { get; init; }
        void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount);
    }
}
