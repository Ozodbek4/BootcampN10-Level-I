using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25Home1.Models
{
    internal class DebitCard
    {
        public string CardNumber { get; set; }
        public double Balance { get; set; }

        public DebitCard(string cardNumber, double balace)
        {
            CardNumber = cardNumber;
            Balance = balace;
        }
    }
}
