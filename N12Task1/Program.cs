Car obj1 = new Car();
Car obj2 = new Car();
Car obj3 = new Car();
Car obj4 = new Car();
Car obj5 = new Car();
Car obj6 = new Car();
Car obj7 = new Car();
Car obj8 = new Car();
Car obj9 = new Car();
Car obj10 = new Car();
obj1.model = "Accord"; obj1.marka = "Honda";
obj2.model = "Camry"; obj2.marka = "Toyota";
obj3.model = "Civic"; obj3.marka = "Honda";
obj4.model = "Accord"; obj4.marka = "Honda";
obj5.model = "Elantra"; obj5.marka = "Hyundai";
obj6.model = "Accord"; obj6.marka = "Honda";
obj7.model = "Sonata"; obj7.marka = "Hyundai";
obj8.model = "Elantra"; obj8.marka = "Hyundai";
obj9.model = "Fusion"; obj9.marka = "Ford";
obj10.model = "Malibu"; obj10.marka = "Chevrolet";
List<Car> list = new List<Car>();
list.Add(obj1);
list.Add(obj2);
list.Add(obj3);
list.Add(obj4);
list.Add(obj5);
list.Add(obj6);
list.Add(obj7);
list.Add(obj8);
list.Add(obj9);
list.Add(obj10);

for (int i = 0; i < list.Count - 1; i++)
{
    int count = 0;
    for (int j = i; j < list.Count; j++)
    {
        if (list[i].model == list[j].model && list[i].marka == list[j].marka)
        {
            count++;
        }
    }
    if (count > 1)
    {
        Console.WriteLine($"{list[i].model} {list[i].marka} - {count}");
    }
}
public class Car
{
    public string marka;
    public string model;
}