using System;
using Models;
using System.Linq;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ProductsList.GetAllProducts();

            //Search products by category // return all products from given category
            List<Product> itEquipment = SearchProduct(Category.ItEquipment, products);
            List<Product> lapTop = SearchProduct(Category.LapTop, products);
            List<Product> pc = SearchProduct(Category.PC, products);
            List<Product> tv = SearchProduct(Category.TV, products);

            //Filter products by price range(from min to max) // return all products that fall in the given price range
            FilterProducPrice(100000, products);

            //Find products by part of name // get all products that consist the part in their names
            SearchByPartOfName("gaming", products);

            //Get only products ids // return only the ids of the products
            GetProductId("Keyboard", products);

            //Get product price // get the price of the product - give the id as parameter
            GetProductPrice(20, products);

            //Get cheapest product // return the cheapest product
            GetCheapestProduct(products);

            //Get most expensive product // return the most expensive one
            GetMostExpensiveProduct(products);

            //Add product // create method to add product to the list of products
            Product product1 = new Product() { Name = "Fuego", Price = 6000, Category = Category.TV };
            Product product2 = new Product() { Name = "HP Pavilion", Price = 41990, Category = Category.LapTop };
            AddProduct(product1, products);
            AddProduct(product2, products);
            //Remove product // and a method to remove it - use id as parameter
            RemoveProduct(22, products);

        }
        public static void RemoveProduct(int id, List<Product> list)
        {
           Product removeProduct = list.FirstOrDefault(x => x.Id == id);
           list.Remove(removeProduct);
        }

        public static void AddProduct(Product product, List<Product> list)
        {
            list.Add(product);
        }

        public static Product GetMostExpensiveProduct(List<Product> list)
        {
            int max = list.Max(x => x.Price);
            return list.FirstOrDefault(x => x.Price == max);
        }

        public static Product GetCheapestProduct(List<Product> list)
        {
            int min = list.Min(x => x.Price);
            return list.FirstOrDefault(x => x.Price == min);
        }

        public static int GetProductPrice(int id, List<Product> list)
        {
            return list.Where(x => x.Id == id).Select(x => x.Price).FirstOrDefault();
        }

        public static int GetProductId(string product, List<Product> list)
        {
            return list.Where(x => x.Name == product).Select(x => x.Id).FirstOrDefault();
        }

        public static List<Product> SearchByPartOfName(string product, List<Product> list)
        {
            return list.Where(x => x.Name.ToLower().Contains(product.ToLower())).ToList();
        }

        public static List<Product> FilterProducPrice(int price, List<Product> list)
        {
           return list.Where(x => x.Price <= price).OrderBy(x => x.Price).ToList();
        }

        public static List<Product> SearchProduct(Category category, List<Product> list)
        {
           return list.Where(x => x.Category == category).ToList();
        }
       
    }
}
