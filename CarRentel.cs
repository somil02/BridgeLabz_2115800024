using System;

class CarRental
{
	private string customerName;
    private string carModel;
    private int rentalDays;
    private const double dailyRate = 500.00;
	
	public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }
	public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }
	public int RentalDays
    {
        get { return rentalDays; }
        set { rentalDays = value; }
    }
	public CarRental(){}
	public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }
	public void CalculateTotalCost()
    {
        double totalcost = rentalDays * dailyRate;
		Console.WriteLine("Total Cost: "+totalcost);
    }
	public void DisplayRentalDetails()
    {
        Console.WriteLine("Customer Name: "+customerName);
        Console.WriteLine("Car Model: "+carModel);
        Console.WriteLine("Rental Days: "+rentalDays);
    }
}
class Program
{
	static void Main(string[] args)
	{
		CarRental rental1 = new CarRental();
        rental1.CustomerName = "Rohit";
        rental1.CarModel = "Fortuner";
        rental1.RentalDays = 3;
		
        CarRental rental2 = new CarRental("Amit", "jeep", 5);
		
        rental1.DisplayRentalDetails();
		rental1.CalculateTotalCost();
		Console.WriteLine();
        rental2.DisplayRentalDetails();
		rental2.CalculateTotalCost();
	}
}