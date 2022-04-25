using System;
using CarRental_NoInterface.Entities;

namespace CarRental_NoInterface.Services {
    class RentalService {

        // declaração das propriedades
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // solução não tão boa, terá melhoria no modelo com interface
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        // construtor que recebe as propriedades
        public RentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) {
            // subtração entre o dia final pelo de inicio
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            // declaração do pagamento básico que começa zerado
            double basicPayment;

            // caso a duração de horas seja menor que 12, calcula o preço por hora
            // senão calcula o preço por dia
            if (duration.TotalHours <= 12.0) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            // a taxa recebe o valor do pagamento básico
            double tax = _brazilTaxService.Tax(basicPayment);

            // atribui os valores ao Invoice
            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}
