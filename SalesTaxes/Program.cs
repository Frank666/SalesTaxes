using System;
using System.Collections.Generic;
using SalesTaxes.Entities;

namespace SalesTaxes
{
    class Program
    {
        private static General.TaxProvider taxProvider = new General.TaxProvider();
        private static Business.Taxes.Total _total;

        static void Main(string[] args)
        {
            _total = new Business.Taxes.Total(new List<Entities.AbstractClasses.TaxesCalculator>
            {
                new Business.Taxes.Calculator(taxProvider),
                new Business.Taxes.ImportProducts(taxProvider)
            });

            FirstScenario();
            SecondScenario();
            ThirdScenario();
            Console.WriteLine("c'ya!");
        }

        private static void FirstScenario()
        {
            var cart = new Business.ShoppingCart.ShoppingCart();
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Book, "1 book"), false, 12.49m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Book, "1 book"), false, 12.49m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Music, "1 Music CD"), false, 14.99m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Food, "1 Chocolate Bar"), false, 0.85m));
            Console.WriteLine(cart.PrintResult());
        }

        private static void SecondScenario()
        {
            var cart = new Business.ShoppingCart.ShoppingCart();
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Book, "1 imported box of chocolate"), true, 10.00m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Perfume, "1 imported bottle of perfume"), true, 47.50m));
            Console.WriteLine(cart.PrintResult());
        }
        private static void ThirdScenario()
        {
            var cart = new Business.ShoppingCart.ShoppingCart();            
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Perfume, "1 imported bottle of perfume"), true, 27.99m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Perfume, "1 bottle of perfume"), false, 18.99m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Medical, "1 packet of headhache pills"), false, 9.75m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Food, "1 imported box of chocolate"), true, 11.25m));
            cart.AddItem(new Item(_total, new Product(Entities.Enums.ProductType.Food, "1 imported box of chocolate"), true, 11.25m));
            Console.WriteLine(cart.PrintResult());
        }
    }
}
