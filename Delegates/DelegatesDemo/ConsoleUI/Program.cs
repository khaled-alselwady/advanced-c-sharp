using DemoLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static clsShoppingCartModel _cart = new clsShoppingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoDate();

            Console.WriteLine($"The total for the cart1 is {_cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");

            Console.WriteLine();

            decimal total = _cart.GenerateTotal(
                (subTotal) => Console.WriteLine($"The subtotal for the cart2 is {subTotal:C2}"),
                (products, subTotal) =>
                {
                    if (products.Count > 3)
                        return subTotal * 0.5M;
                    else
                        return subTotal;
                },
                (message) => Console.WriteLine($"Cart2 Alert: {message}")
                );

            Console.WriteLine($"The total for the cart2 is {total:C2}");

            Console.ReadKey();
        }

        private static void AlertUser(string message)
          => Console.WriteLine(message);

        private static void SubTotalAlert(decimal subTotal)
            => Console.WriteLine($"The subtotal for the cart1 is {subTotal:C2}");

        private static decimal CalculateLeveledDiscount(List<clsProductModel> products, decimal subTotal)
        {
            if (subTotal > 100) return subTotal * 0.08M;
            else if (subTotal > 50) return subTotal * 0.85M;
            else if (subTotal > 10) return subTotal * 0.95M;
            else return subTotal;
        }

        private static void PopulateCartWithDemoDate()
        {
            _cart.Items.Add(new clsProductModel { ItemName = "Creel", Price = 3.36M });
            _cart.Items.Add(new clsProductModel { ItemName = "Milk", Price = 2.95M });
            _cart.Items.Add(new clsProductModel { ItemName = "Strawberries", Price = 7.51M });
            _cart.Items.Add(new clsProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
