using CarRentalInvoice.Entities;
using System;

namespace CarRentalInvoice.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //This is wrong cause RentalServices only works for BrazilTazService.
        //private BrazilTaxService _brazilTextService = new BrazilTaxService();

        private ITaxService _taxService;

        //dependency inversion
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) 
        {
            PricePerHour = pricePerHour; PricePerDay = pricePerDay; ; _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
