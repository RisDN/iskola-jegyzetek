using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevlista_form
{
    internal class Product
    {

        private static List<Product> products = new List<Product>();

        private int amount;

        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount
        {
            get => amount;
            set
            {
                if (value > 5)
                {
                    throw new Exception("Product amount must be 5 or below! Given: " + value);
                }
                amount = value;
            }
        }


        public Product(string name, int price, int amount) {
            Name = name;
            Price = price;
            Amount = amount;

            products.Add(this);
        }

        public static List<Product> GetProducts()
        {
            return new List<Product>(products);
        }
        public static int GetProductsCount()
        {
            return products.Count;
        }

        public static Product GetMostExpensive()
        {
            Product product = products[0];
            foreach (Product item in products)
            {
                if(item.Price > product.Price)
                {
                    product = item;
                }
            }

            return product;
        }

        public static int GetTotalAmount()
        {
            int sum = 0;
            foreach (Product item in products)
            {
                sum += item.Amount * item.Price;
            }
            return sum;
        }

    }
}
