using System;
using System.Globalization;
using CarRental_NoInterface.Entities;
using CarRental_NoInterface.Services;

namespace CarRental_NoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // leitura do modelo do carro
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();

            // leitura dos horários de entrada e saída do carro
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine();

            // leitura dos preços por hora e dia
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // instanciação do horário de pickup e return
            // instanciação de um novo vehicle que recebe o modelo
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            // instanciação do preço por hora e dia
            RentalService rentalService = new RentalService(hour, day);

            // gera o Invoice e o associa ao Rental
            rentalService.ProcessInvoice(carRental);

            // apresentação final dos valores
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
