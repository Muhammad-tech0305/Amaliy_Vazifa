using System;

class Program
{
    static Bokschi[] boskchilar = 
    {
        new Bokschi("John", "Doe", 25, 75.5f),
        new Bokschi("Jane", "Doe", 30, 65.2f),
        new Bokschi("Bob", "Smith", 35, 80.8f),
        new Bokschi("Alice", "Johnson", 28, 55.3f),
        new Bokschi("Charlie", "Brown", 32, 70.1f),
    };

    static void Main(string[] args)
    {
        Console.WriteLine(" ------- BOKSCHILAR HAQIDA MA'LUMOT -------");
        Console.WriteLine(" ");

        Console.WriteLine("Yengil (50 kg gacha) vazndagi bokschilar ro'yxati:");
        foreach (Bokschi bokschi in boskchilar)
        {
            if (bokschi.Weight <= 50)
            {
                Console.WriteLine($"{bokschi.Name} {bokschi.Surname}, {bokschi.Age} yoshda, {bokschi.Weight} kg, {bokschi.Id} id");
            }
            else
            {
                Console.WriteLine("-------");
            }
        }
        Console.WriteLine(" ");

        Console.WriteLine("O'rta (50 - 76 kg) vazndagi bokschilar ro'yxati:");
        foreach (Bokschi bokschi in boskchilar)
        {
            if (bokschi.Weight > 50 && bokschi.Weight <= 76)
            {
                Console.WriteLine($"{bokschi.Name} {bokschi.Surname}, {bokschi.Age} yoshda, {bokschi.Weight} kg, {bokschi.Id} id");
            }
            else
            {
                Console.WriteLine("-------");
            }
        }
        Console.WriteLine(" ");

        Console.WriteLine("Og'ir (76 kg dan) vazndagi bokschilar ro'yxati:");
        foreach (Bokschi bokschi in boskchilar)
        {
            if (bokschi.Weight > 76)
            {
                Console.WriteLine($"{bokschi.Name} {bokschi.Surname}, {bokschi.Age} yoshda, {bokschi.Weight} kg, {bokschi.Id} id");
            }
            else
            {
                Console.WriteLine("-------");
            }
        }
    }
}

class Bokschi
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public float Weight { get; set; }

    public Bokschi(string ismi, string familyasi, int yoshi, float vazni)
    {
        Id = Guid.NewGuid();
        Name = ismi;
        Surname = familyasi;
        Age = yoshi;
        Weight = vazni;
    }
}