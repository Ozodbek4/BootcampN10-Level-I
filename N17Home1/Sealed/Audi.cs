using N17Home1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17Home1.Sealed
{
    internal sealed class Audi : CarRental
    {
        public string ModelName { get; set; }
        public int RentedPriceHour { get; set; }
        public Audi(string CarModel)
        {
            base.BrandName = "Audi";
            ModelName = CarModel;
        }
    }
}
