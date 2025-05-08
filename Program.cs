using System;
using System.Collections.Generic;

namespace Vazifa
{
    public enum Baholar
    {
        Nol = 0,
        Bir = 1,
        Ikki = 2,
        Uch = 3,
        Tort = 4,
        Besh = 5
    }

    class Program
    {
        static void Main()
        {
            List<Oquvchi> oquvchilar = new List<Oquvchi>
            {
                new Oquvchi("O'quvchi 1", "I", 5, Baholar.Besh),
                new Oquvchi("O'quvchi 2", "II", 6, Baholar.Tort),
                new Oquvchi("O'quvchi 3", "III", 7, Baholar.Tort),
                new Oquvchi("O'quvchi 4", "IV", 8, Baholar.Tort),
                new Oquvchi("O'quvchi 5", "V", 9, Baholar.Uch),
                new Oquvchi("O'quvchi 6", "VI", 7, Baholar.Uch),
            };

            Console.Write("Necha baho olgan o'quvchilarni ko'rmoqchisiz? >>> ");
            int bahoInt = int.Parse(Console.ReadLine());

            Console.WriteLine($"\'{bahoInt}\' baho olgan oq'uvchilar: ");
            foreach (Oquvchi oquvchi in oquvchilar)
            {
                if ((int) oquvchi.Baho == bahoInt)
                {
                    Console.WriteLine($"Ismi: {oquvchi.Ism} {oquvchi.Familya}; ID'si: {oquvchi.Id}; Sinfi: {oquvchi.Sinf}; Bahosi: {(int) oquvchi.Baho}.");
                }
            }
        }
    }

    class Oquvchi
    {
        public Guid Id {get; set;}
        public string Ism {get; set;}
        public string Familya {get; set;}
        public int Sinf {get; set;}
        public Baholar Baho {get; set;}
        
        public Oquvchi (string ismi, string familyasi, int sinfi, Baholar bahosi)
        {
            Id = Guid.NewGuid();
            Ism = ismi;
            Familya = familyasi;
            Sinf = sinfi;
            Baho = bahosi;
        }
    }
}