using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class DoIt
    {

    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class ProductCatalog
    {
        public List<Product> Products { get; set; }

        public ProductCatalog()
        {
            Products = new List<Product>();

            Products.Add(new Product { ID = 12345, Name = "Widget", Price = 8.99m });
            Products.Add(new Product { ID = 12346, Name = "Fidget", Price = 6.99m });
            Products.Add(new Product { ID = 12347, Name = "Midget", Price = 4.99m });
        }

        public Product Lookup(int ProductID)
        {
            var ProductReturn = new Product();
            ProductReturn = null;

            foreach (var product in this.Products)
            {
                if (product.ID == ProductID)
                {
                    ProductReturn = product;
                }
            }
            return ProductReturn;
        }
    }

    public class Program
    {


        public static void Main(string[] args)
        {
            var foundProduct = new Product();
            var productCatalog = new ProductCatalog();
            int intLookupID = 0;

            Console.WriteLine("What ProductID should I look for?");
            var LookUpID = Console.ReadLine();
            intLookupID = int.Parse(LookUpID);
            foundProduct = productCatalog.Lookup(intLookupID);

            if (foundProduct != null)
            {
                Console.WriteLine(foundProduct.Name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Couldn't find it");
                Console.ReadLine();
            }
        }
    }
}
