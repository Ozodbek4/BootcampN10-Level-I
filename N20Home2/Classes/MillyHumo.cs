using N21Home1.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21Home1.Classes
{
    internal class MillyHumo : IDebitCard
    {
        public string CardNumber { get; set; }
        public string BankName { get; init; }
        public double Balance { get; set; }
    }
}
