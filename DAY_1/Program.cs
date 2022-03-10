using System;

namespace DAY_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addr = new Address();
            addr.City = "Минск";
            addr.Street = "Немига";
            addr.Number = 55;

            Address addr2 = new Address("Полоцк", "Октябрьская", 57);

            Console.WriteLine($"Адрес без конструктора:\nГород: {addr.City}, Улица: {addr.Street}, Номер: {addr.Number}.\n");
            Console.WriteLine($"Адрес с конструктором:\nГород: {addr2.City}, Улица: {addr2.Street}, Номер: {addr2.Number}.");

            Console.ReadKey();
        }
    }
}