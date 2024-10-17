using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Laptop", 40000);
            object boxedProduct = product;
            Product unboxedProduct = (Product)boxedProduct;
            Console.WriteLine("Id: " + unboxedProduct.Id);
            Console.WriteLine("Name: " + unboxedProduct.Name);
            Console.WriteLine("Price: " + unboxedProduct.Price);
            Console.ReadLine();
        }


    }
    public class Product
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
        
