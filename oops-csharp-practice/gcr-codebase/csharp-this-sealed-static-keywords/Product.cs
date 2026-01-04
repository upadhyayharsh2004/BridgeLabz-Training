using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.scenario_based
{
    class Product
    {
        // static: shared by all products
        static double Discount = 0;

        // instance variables
        string ProductName;
        double Price;
        int Quantity;

        // readonly: unique product ID
        public readonly int ProductID;

        // constructor using 'this'
        public Product(string ProductName, double Price, int Quantity, int ProductID)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
            this.ProductID = ProductID;
        }

        // static method to update discount
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        // instance method
        public void DisplayProduct()
        {
            double total = Price * Quantity;
            double discountAmount = total * Discount / 100;
            double finalPrice = total - discountAmount;

            Console.WriteLine("\n--- PRODUCT DETAILS ---");
            Console.WriteLine("Product Name   : " + ProductName);
            Console.WriteLine("Product ID     : " + ProductID);
            Console.WriteLine("Price          : " + Price);
            Console.WriteLine("Quantity       : " + Quantity);
            Console.WriteLine("Discount (%)   : " + Discount);
            Console.WriteLine("Final Price    : " + finalPrice);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Discount Percentage: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Product.UpdateDiscount(d);

            Console.Write("Enter number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nEnter details for Product " + i);

                Console.Write("Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Product p = new Product(name, price, qty, id);

                // is operator check
                if (p is Product)
                {
                    p.DisplayProduct();
                }
            }
        }
    }
}
