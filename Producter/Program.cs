using System;
using System.Collections;
using System.Collections.Generic;

namespace GuestsShouldLeave
{
    public class Gui
    {
        public static void mainGui()
        {
            //product list
            List<Product> products = new List<Product>();
            var myProducts = products;
            //the customers basket
            Queue<Product> basket = new Queue<Product>();

            Product milk = (new Product(020921, "Milk", 10));
            Product meatOks = (new Product(090921, "Meat Oks", 30));
            Product meatPork = (new Product(90921, "Meat Pork", 28));
            Product bananas = (new Product(20921, "bananas", 12));
            Product apples = (new Product(200921, "Apples", 24));
            Product Peanuts = (new Product(150921, "Peanuts", 8));

            products.Add(milk);
            products.Add(meatOks);
            products.Add(meatPork);
            products.Add(bananas);
            products.Add(apples);
            products.Add(Peanuts);

            foreach (Product p in products)
            {
                p.Print();
            }
            Console.WriteLine("");

            bool Continue = true;
            while (Continue)
            {
                string store = Console.ReadLine();
                switch (store)
                {
                    case "1":
                        products.RemoveAt(0);                        
                        basket.Enqueue(milk);
                        Console.WriteLine("\n---------------------------------------"+
                            "\nyou added (Milk) to your basket!");
                        break;

                    case "2":
                        products.RemoveAt(1);
                        basket.Enqueue(meatOks);
                        Console.WriteLine("\n---------------------------------------"+
                            "\nyou added (meat oks) to your basket!");
                        break;

                    case "3":
                        products.RemoveAt(2);
                        basket.Enqueue(meatPork);
                        Console.WriteLine("\n---------------------------------------"+
                            "\nyou added (meat pork) to your basket!");
                        break;

                    case "4":
                        products.RemoveAt(3);
                        basket.Enqueue(bananas);
                        Console.WriteLine("\n---------------------------------------"+
                            "\nyou added (bananas) to your basket!");
                        break;

                    case "5":
                        products.RemoveAt(4);
                        basket.Enqueue(apples);
                        Console.WriteLine("\n---------------------------------------"+
                            "\nyou added (apples) to your basket!");
                        break;

                    case "6":
                        products.RemoveAt(5);
                        basket.Enqueue(Peanuts);
                        Console.WriteLine("\n---------------------------------------"+
                            "\nyou added (peanuts) to your basket!");
                        break;

                    case "e":
                    default:
                        Continue = false;
                        break;
                }
            }
            //Console.WriteLine("\nAmount of products in storage {0}", products.Count);

            /*foreach (Product product in products)
            {
                product.Print();
            }*/

            //sry for temp variables
            int priceMax = 0;
            int priceMin = 100;

            //a loop to find price max and min price
            /*foreach (Product product in products)
            {
                if (product.Price > priceMax)
                {
                    priceMax = product.Price;
                }
                if (product.Price < priceMin)
                {
                    priceMin = product.Price;
                }
            }*/

            //prints max and min price
            Console.WriteLine($"\nThe most expensive product is: {priceMax}");
            Console.WriteLine($"\nThe cheapest product is: {priceMin}");

            //find and item in my queue
            //Product soldFirst = products.Dequeue();
            //Console.WriteLine($"\nSold first: {soldFirst.Name} ");
        }

        



    }
    class Program
    {
        static void Main(string[] args)
        {
            Gui.mainGui();
        }
    }
}
