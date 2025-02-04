using System;

class HotelBooking
{
	private string guestName;
	private string roomType;
	private int nights;
	
	public string GuestName
	{
		get { return guestName; } //getter
        set { guestName = value; } //setter
	}
	public string RoomType
	{
		get { return roomType; }
        set { roomType = value; }
	}
	 public int Nights
    {
        get { return nights; }
        set { nights = value; }
    }
	public HotelBooking() { }
	 public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }
	 public HotelBooking(HotelBooking booking)
    {
        this.guestName = booking.guestName;
        this.roomType = booking.roomType;
        this.nights = booking.nights;
    }
	public void DisplayBookingDetails()
    {
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Number of Nights: " + nights);
        Console.WriteLine();
    }
}
class Program
{
	public static void Main(string[] args){
		HotelBooking booking1 = new HotelBooking(); // default constructor
		booking1.GuestName = "ram";
        booking1.RoomType = "Normal";
        booking1.Nights = 3;
		HotelBooking booking2 = new HotelBooking("raju" , "Deluxe" , 2); // parameterized constructor
		HotelBooking booking3 = new HotelBooking(booking2); //copy constructor
		booking1.DisplayBookingDetails();
        booking2.DisplayBookingDetails();
        booking3.DisplayBookingDetails();
		
	}
}