using System;

public class Product
{
   public static double Discount = 0.0 ;
   public readonly int ProductID ;
   public string ProductName { get; private set; }
   public double Price { get; private set; }
   public int Quantity { get; private set; }

   public static void UpdateDiscount(double newDiscount)
   {
       if (newDiscount >= 0.0 && newDiscount <= 100.0)
       {
           Discount = newDiscount;
           Console.WriteLine($"Discount updated to {Discount}%");
       }
       else
       {
           Console.WriteLine("Invalid discount percentage. Please enter a value between 0 and 100.");
       }
   }
   public Product(int productId, string productName, double price, int quantity)
   {
       this.ProductID = productId;
       this.ProductName = productName;
       this.Price = price;
       this.Quantity = quantity;
   }

   public void DisplayDetails()
   {
       if (this is Product)
       {
           double discountedPrice = Price - (Price * Discount / 100);
           Console.WriteLine($"Product Details:\n" +
                             $"ID: {ProductID}\n" +
                             $"Name: {ProductName}\n" +
                             $"Original Price: {Price:C}\n" +
                             $"Discounted Price: {discountedPrice:C} (Discount: {Discount}%)\n" +
                             $"Quantity: {Quantity}");
       }
       else
       {
           Console.WriteLine("Provided object is not a Product instance.");
       }
   }
}

class Program
{
   public static void Main(string[] args) 
   {
       Product product1 = new Product(101, "Laptop", 45000, 10);
       Product product2 = new Product(102, "Mobile", 25000, 20);
       Product.UpdateDiscount(10);
       product1.DisplayDetails();
       Console.WriteLine();
       product2.DisplayDetails();
   }
}
