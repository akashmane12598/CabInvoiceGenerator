using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideType rideType;
        private RideRepository rideRepository;

        private readonly double MIMINUM_FARE_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MINIMUM_FARE;

        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            this.rideRepository = new RideRepository();

            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.MIMINUM_FARE_PER_KM = 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                }
                else if (rideType.Equals(RideType.PREMIUM))
                {
                    this.MIMINUM_FARE_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE,"Invalid Ride Type");
            }
        }
    }
}
