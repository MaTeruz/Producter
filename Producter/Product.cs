using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestsShouldLeave
{
    public class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int ExpireDate { get; set; }

        public Product(int ExpireDate_, string Name_, int price_)
        {
            Price = price_;
            Name = Name_;
            ExpireDate = ExpireDate_;

        }
        public void Print()
        {
            Console.WriteLine("Name: " + Name);            
            Console.WriteLine("Price: " + Price);
            Console.WriteLine($"Type {ExpireDate}, to select");
        }
        public void PrintPro(string q)
        {
            Console.WriteLine(q);
        }
        public void basketcount()
        {
            
        }
    }
}
