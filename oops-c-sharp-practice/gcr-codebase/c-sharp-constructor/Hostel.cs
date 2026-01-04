using System;

class BookingInfo
{
    public string guest;
    public string roomCategory;
    public int stayNights;

    // default constructor
    public BookingInfo()
    {
        guest = "Not Assigned";
        roomCategory = "Standard";
        stayNights = 1;
    }

    // parameterized constructor
    public BookingInfo(string guestName, string roomType, int nights)
    {
        guest = guestName;
        roomCategory = roomType;
        stayNights = nights;
    }

    // copy constructor
    public BookingInfo(BookingInfo otherBooking)
    {
        guest = otherBooking.guest;
        roomCategory = otherBooking.roomCategory;
        stayNights = otherBooking.stayNights;
    }

    // method to display booking details
    public void showBooking()
    {
        Console.WriteLine("Guest Name  : " + guest);
        Console.WriteLine("Room Type   : " + roomCategory);
        Console.WriteLine("No. of Nights: " + stayNights);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // using parameterized constructor
        BookingInfo booking1 = new BookingInfo("Ana", "Deluxe", 2);

        // using copy constructor
        BookingInfo booking2 = new BookingInfo(booking1);

        // display copied booking info
        booking2.showBooking();
    }
}
