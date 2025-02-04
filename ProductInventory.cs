using System;

class Product
{
    private string productName;
    private double price;

    private static int totalProducts = 0;

    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public Product()
    {
        totalProducts++;
    }
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: " +productName);
        Console.WriteLine("Price: "+price);
        Console.WriteLine();
    }
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: "+totalProducts);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 1200.00);
        Product product2 = new Product("Smartphone", 800.00);
        Product product3 = new Product();
        product3.ProductName = "Headphones";
        product3.Price = 150.00;
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();
        product3.DisplayProductDetails();
        Product.DisplayTotalProducts();
    }
}
