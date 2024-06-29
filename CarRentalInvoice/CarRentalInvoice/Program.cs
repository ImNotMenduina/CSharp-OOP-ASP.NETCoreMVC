using CarRentalInvoice.Entities;
using System;
using System.Globalization;

namespace CarRentalInvoice
{
    internal class Program
    {
        //camada de domínio e serviços;
        static void main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}