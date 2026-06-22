using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MAY_260526
{
    class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public int Quantity;

        public double GetTotal()
        {
            return Price * Quantity;
        }
    }
    internal class Q1_shoppingcart
    {
        // create a shopping cart for multiple products. Show total cost of the shopping cart.
        public static void Run()
        {
            Console.Write("Enter number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Product[] cart = new Product[n];

            for(int i = 0; i < n; i++)
            {
                cart[i] = new Product();

                Console.WriteLine($"\nProduct {i + 1}");

                Console.Write("ID: ");
                cart[i].Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                cart[i].Name = Console.ReadLine();

                Console.Write("Price: ");
                cart[i].Price=Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantity: ");
                cart[i].Quantity = Convert.ToInt32(Console.ReadLine());
            }

            double grandTotal = 0;

            Console.WriteLine("\nShopping Cart");
            Console.WriteLine("-----------------------------");

            foreach (Product p in cart)
            {
                double total = p.GetTotal();

                Console.WriteLine(
                    $"ID:{p.Id} Name:{p.Name} Price:{p.Price} Qty:{p.Quantity} Total:{total}");

                grandTotal+= total;
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Grand Total = " + grandTotal);
        }
    }
}
