using System;
using System.Text;
class Car
{
    internal string CarName {get; set;}
    internal string Model {get; set;}
    internal decimal Price {get; set;}
    internal Car(string name, string model, decimal price = 0m)
    {
        CarName = name;
        Model = model;
        Price = price;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // cars data base
        Car[] Cars =
        {
            new Car("Kia", "Picanto", 50000m),
            new Car("Honda", "Civic", 60000m),
            new Car("Toyota", "Corolla", 70000m)
        };

        Console.WriteLine("Ikkita narx kiriting ($): ");
        Console.Write("Birinchi narx: ");
        decimal price1 = decimal.Parse(Console.ReadLine());
        Console.Write("Ikkinchi narx: ");
        decimal price2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"{price1} va {price2} narxli oraliqdagi mashinalar: ");
        foreach (Car car in Cars)
        {
            if (car.Price >= price1 && car.Price <= price2)
            {
               Console.WriteLine($"Nomi: {car.CarName} {car.Model}, Narxi: {car.Price}$");
            }
            else 
            {
                Console.WriteLine("-------");
            }
        }
    }
}