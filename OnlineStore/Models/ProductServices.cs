using OnlineStore.Delegate;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Models
{
    public class ProductServices
    {
        public void PrintProduct(Product product)
        {
            Console.WriteLine($"{product.Name} : ${product.Price}({product.Stock})");
        }
        public  List<Product> SearchProducts(List<Product> products, SearchFilter filter)
        {
            List<Product> list = new();
            foreach (Product p in products)
            {
                if (filter(p))
                    list.Add(p);
            }
            return list;
        }
        public bool ElectronicProducts(Product product) => product.Category == "Electronics";

        public  bool CheapProducts(Product product) => product.Price < 50;

        public  bool StockProducts(Product product) => product.Stock > 0;
        public  bool ClothingProduct(Product product) => product.Category == "Clothing" && product.Price < 50;


        public void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }
        public void ShortReport(Product product) => Console.WriteLine($"{product.Name} : {product.Price}");
        public void DetailedReport(Product product) => Console.WriteLine($" [{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock} \r\n");

    }
}
