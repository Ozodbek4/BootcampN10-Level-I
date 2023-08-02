using N17Home1;
using N17Home1.Normal;
using N17Home1.Sealed;

CarRentalManagement obj = new CarRentalManagement();
Bmw bmw1 = new Bmw("M5");
Bmw bmw2 = new Bmw("X7");
Bmw bmw3 = new Bmw("I7");

Audi audi1 = new Audi("Q7");
Audi audi2 = new Audi("Q5");
Audi audi3 = new Audi("Audi e-Tron");

CarRentalManagement CarsManager =  new CarRentalManagement();
CarsManager.Add(bmw1);
CarsManager.Add(bmw2);
CarsManager.Add(bmw3);
CarsManager.Add(audi1);
CarsManager.Add(audi2);
CarsManager.Add(audi3);

object q7 = CarsManager.Rent("Q8");
if (q7 == null)
{
    Console.WriteLine("Uzr, hozir Q8 turidagi mashinani ijarasi mavjud emas");
}
object Tr = CarsManager.Rent("Audi e-Tron");
if (Tr == null)
{
    Console.WriteLine("Uzr, hozir Q7 turidagi mashinani ijarasi mavjud emas");
}
object m5 = CarsManager.Rent("M5");
if (m5 == null)
{
    Console.WriteLine("Uzr, hozir Q7 turidagi mashinani ijarasi mavjud emas");
}
object i7 = CarsManager.Rent("I7");
if (i7 == null)
{
    Console.WriteLine("Uzr, hozir Q7 turidagi mashinani ijarasi mavjud emas");
}

CarsManager.Return(audi1);
CarsManager.Return(audi2);
CarsManager.Return(audi3);
CarsManager.Return(bmw1);
CarsManager.Return(bmw2);
CarsManager.Return(bmw3);
CarsManager.CalculateBalance();