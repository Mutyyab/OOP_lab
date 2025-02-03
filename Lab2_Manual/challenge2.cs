using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manual_2
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string category;
        public string brandName;
        public string country;

        public Product() 
        {
            id = 0;
            name = string.Empty;
            price = 0;
            category = string.Empty;
            brandName = string.Empty;
            country = string.Empty;
        
        }
        public Product(int ID, string n, int p, string c, string bN, string cntry)
        {
            id = ID;
            name = n;
            price = p;
            category = c;
            brandName = bN;
            country = cntry;
        }

        public Product AddProduct()
        {
            Product p;
            Console.WriteLine("Enter product id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name: ");
            string  name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product category: ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter product brand name: ");
            string brand_name = Console.ReadLine();
            Console.WriteLine("Enter product country: ");
            string country = Console.ReadLine();
            p = new Product(id,name,price,category,brand_name,country);
            return p;
        }

        public void ShowProduct()
        {
            Console.WriteLine("Product id" + id);
            Console.WriteLine("Product Name" + name);
            Console.WriteLine("Product price" + price);
            Console.WriteLine("Product category" + category);
            Console.WriteLine("Product brand name" + brandName);
            Console.WriteLine("Product country" + country);
        }
    }
}
