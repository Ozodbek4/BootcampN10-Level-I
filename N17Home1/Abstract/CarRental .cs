using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17Home1.Abstract
{
    internal class CarRental
    {
        public bool IsRented { get; set; }
        public DateTime RentStartTime { get; set; }
        public int Balance { get; set; }
        public string BrandName { get; set; }
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int RentedPriceHour { get; set; }
    }
}
