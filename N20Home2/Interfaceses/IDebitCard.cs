using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Interfaceses
{
    internal interface IDebitCard
    {
        string CardNumber { get; set; }
        string BankName { get; init; }
        double Balance { get; set; }
    }
}
