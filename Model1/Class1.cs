using System;
using System.Data.Entity;

namespace Model1
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public int CountRooms { get; set; }
        public TypeOfHotel Type { set; get; }
    }

    public class HotelDB : DbContext
    {
        HotelDB()
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
    }
    public enum TypeOfHotel
    {
        Hotel,
        Hostel,
        Motel,
        Cottage
    }
}
