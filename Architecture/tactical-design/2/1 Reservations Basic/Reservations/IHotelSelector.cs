namespace Reservations
{
    public interface IHotelSelector
    {
        HotelInfo SelectHotel(string town, string hotelName);
    }
}
