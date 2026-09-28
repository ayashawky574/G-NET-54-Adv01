using OnlineStore.Models;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
       {
        new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
        new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
        new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
        new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
        new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
        new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
        new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
        new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
        new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
        new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
         };
            #region Smart Product Search
            //Console.WriteLine("-----Electronics-----");
            ProductServices productServices = new();
            //List<Product> Electronics = productServices.SearchProducts( catalog , productServices.ElectronicProducts );
            //foreach (var product in Electronics)
            //{
            //    productServices.PrintProduct(product);
            //}
            //Console.WriteLine();
            //Console.WriteLine("---- Cheap Product ----");
            //List<Product> CheapProducts = productServices.SearchProducts( catalog , productServices.CheapProducts);
            //foreach (var product in CheapProducts)
            //{
            //    productServices.PrintProduct(product);
            //}
            //Console.WriteLine();
            //Console.WriteLine("---- In Stock ----");
            //List<Product> StockProducts = productServices.SearchProducts( catalog , productServices.StockProducts);
            //foreach (var product in StockProducts)
            //{
            //    productServices.PrintProduct(product);
            //}

            //Console.WriteLine();
            //Console.WriteLine("---- Clothing Under $100 ----");
            //List<Product> ClothingProduct = productServices.SearchProducts(catalog, productServices.ClothingProduct);
            //foreach (var product in ClothingProduct)
            //{
            //   productServices.PrintProduct(product);
            //}
            #endregion

            #region Custom Report Generator
            //3.1  Print Reports 
            //Console.WriteLine("---- Short Report ----");
            //productServices.PrintReport(catalog, productServices.ShortReport);
            //Console.WriteLine();
            //Console.WriteLine("---- Detailed Report ----");
            //productServices.PrintReport(catalog, productServices.DetailedReport);

            //------------------------------------------------------------------------------
            //3.2.Transform Products
            //Console.WriteLine("----- Summary List ----");
            //List<string> products = productServices.TransformProducts(catalog, productServices.Summary);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();
            //Console.WriteLine("---- Products Label ----");
            //List<string> productslabel = productServices.TransformProducts(catalog, productServices.Label);
            //foreach (var product in productslabel)
            //{
            //    Console.WriteLine(product);
            //}

            //3.3.Filter Products
            //Console.WriteLine("----- low Stock Alert ----");
            //List<Product> products = productServices.FilterProduct(catalog, productServices.LowStockAlert);
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            //}
            #endregion
        }
    }
}
