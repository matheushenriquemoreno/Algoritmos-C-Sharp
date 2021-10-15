using System;
using solucao_interface.Entities;

namespace solucao_interface.Services
{
    class RetalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDAy { get; private set; }

        private ITaxService _taxService;

        public RetalService(double pricePerHour, double pricePerDAy, ITaxService service)
        {
            PricePerHour = pricePerHour;
            PricePerDAy = pricePerDAy;
            _taxService = service; // inversão de controle por meio de injeção de dependencia 
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPaymente = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPaymente = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPaymente = PricePerDAy * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPaymente);

            carRental.Invoice = new Invoic(basicPaymente, tax);
        }
    }
}
