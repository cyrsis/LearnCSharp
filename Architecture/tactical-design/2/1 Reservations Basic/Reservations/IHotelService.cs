using System;

namespace Reservations
{
    public interface IHotelService
    {
        IVacationPart MakeBooking(HotelInfo hotel, DateTime checkin, DateTime checkout);
    }
}
