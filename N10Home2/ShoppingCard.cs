using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N10Home2
{
    internal class ShoppingCard
    {
        public int Id {get; set; }
        public int Count { get; set; }

        public void Add(int i, int j) { 
            if (Id == i)
                Count += j;
            else
            {
                Id = i;
                Count = j;
            }
        }
        public bool Remove(int i, int j) {
            if (Id != i)
                return false;
            else
            {
                Count -= j;
                return true;
            }
        }
    }
}
