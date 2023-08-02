using N17Home1.Abstract;
using N17Home1.Sealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace N17Home1.Normal
{
    internal class CarRentalManagement
    {
        List<CarRental> Cars = new List<CarRental>();
        private int _count = 0;


        public void Add(Bmw car) 
        {
            _count++;
            car.Id = _count;
            Cars.Add( new CarRental() 
            {
                IsRented  = car.IsRented,
                RentStartTime  = car.RentStartTime,
                Balance = car.Balance,
                BrandName = car.BrandName,
                Id = car.Id,
                ModelName = car.ModelName,
                RentedPriceHour = car.RentedPriceHour
            });
        }
        public void Add(Audi car)
        {
            _count++;
            car.Id = _count;
            Cars.Add(new CarRental()
            {
                IsRented = car.IsRented,
                RentStartTime = car.RentStartTime,
                Balance = car.Balance,
                BrandName = car.BrandName,
                Id = car.Id,
                ModelName = car.ModelName,
                RentedPriceHour = car.RentedPriceHour
            });
        }
        public object Rent(string brandName)
        {
            foreach (var car in Cars)
            {
                if (car.ModelName == brandName)
                {
                    car.RentStartTime = DateTime.Now;
                    car.IsRented = true;
                    return car;
                }
            }
            return null;
        }

        public void Return(Bmw car)
        {
            foreach (var item in Cars)
            {
                if (item.Id == car.Id && item.IsRented)
                {
                    item.IsRented = false;
                    var a =(DateTime.Now - car.RentStartTime).Seconds / 5;
                    Random random = new Random();
                    int b = random.Next(0, 5);
                    a = (int)(a + b);
                    Console.WriteLine($"{item.ModelName} - {a} soat");
                    item.Balance = a * 30;
                }
            }
        }
        public void Return(Audi car)
        {
            foreach (var item in Cars)
            {
                if (item.Id == car.Id && item.IsRented)
                {
                    item.IsRented = false;
                    var a = (DateTime.Now - car.RentStartTime).Seconds / 5;
                    Console.WriteLine($"{item.ModelName} - {a} soat");
                    item.Balance = a * 20;
                }
            }
        }

        public void CalculateBalance()
        {
            var summaBalance = 0;
            foreach(var item in Cars)
            {
                if (item.Balance != 0)
                {
                    summaBalance += item.Balance;
                }
            }
            Console.WriteLine($"Ummumiy balans: ${summaBalance}");
        }
    }
}
