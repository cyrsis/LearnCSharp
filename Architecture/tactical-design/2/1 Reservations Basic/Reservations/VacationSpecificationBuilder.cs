using System;
using System.Collections.Generic;

namespace Reservations
{
    public class VacationSpecificationBuilder
    {

        private IList<IVacationPart> parts = new List<IVacationPart>();

        private IHotelService hotelService;
        private IHotelSelector hotelSelector;
        private IAirplaneService airplaneService;
        
        private DateTime arrivalDate;
        private int totalNights;

        private string livingTown;
        private string destinationTown;

        public VacationSpecificationBuilder(IHotelService hotelService,
                                            IHotelSelector hotelSelector,
                                            IAirplaneService airplaneService,
                                            DateTime arrivalDate, int totalNights,
                                            string livingTown, string destinationTown)
        {
            
            this.hotelService = hotelService;
            this.hotelSelector = hotelSelector;
            this.airplaneService = airplaneService;
            
            this.arrivalDate = arrivalDate;
            this.totalNights = totalNights;

            this.livingTown = livingTown;
            this.destinationTown = destinationTown;

        }

        public void SelectHotel(string hotelName)
        {
            HotelInfo hotel = this.hotelSelector.SelectHotel(this.destinationTown, hotelName);
            IVacationPart part = 
                this.hotelService.MakeBooking(hotel, this.arrivalDate, this.DepartureDate);
            this.parts.Add(part);
        }

        public void SelectAirplane(string companyName)
        {
            
            IVacationPart part =
                airplaneService.SelectFlight(companyName, this.livingTown, this.destinationTown, this.arrivalDate);
            this.parts.Add(part);

            part =
                airplaneService.SelectFlight(companyName, this.destinationTown, this.livingTown, this.DepartureDate);
            this.parts.Add(part);

        }

        private DateTime DepartureDate
        {
            get
            {
                return this.arrivalDate.AddDays(this.totalNights);
            }
        }

        public VacationSpecification BuildVacation()
        {
            foreach (IVacationPart part in parts)
                part.Reserve();
            return new VacationSpecification(parts);
        }

    }
}
