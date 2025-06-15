using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab7
{
    public static class Bai2
    {
        private static readonly int[] daySo = [1, 2, 3, 4, 5, 6, 7, 8];
        private static readonly string[] Cities = ["ha noi", "ho chi minh", "cao bang",
                                                   "lao cai", "thanh hoa", "nghe an", "can tho",
                                                   "soc trang", "ha tien", "ha nam", "ha tay", "ha nam ninh"];
        private static readonly List<Product> listProduct = new List<Product>()
        {
            new Product(1, "Laptop", 1500, "High quality"),
            new Product(2, "Phone", 800, "Budget"),
            new Product(3, "Tablet", 600, "Portable"),
            new Product(4, "Monitor", 300, "Standard"),
            new Product(5, "Keyboard", 100, "Compact")
        };

        private static readonly List<Brand> listBrand = new List<Brand>()
        {
            new Brand(1, "Apple"),
            new Brand(3, "Samsung"),
            new Brand(5, "Dell")
        };
        public static void _Bai2()
        {
            Console.WriteLine("\n-----Bai 2-----");
            Caua();
            Caub();
            Cauc();
            Caud();
            Caue();
        }

        private static void Caue()
        {
            Console.WriteLine("\nCau e: ");
            listProduct
                .Join(listBrand,
                product => product.BrandId,
                brand => brand.Id,
                (product, brand) => new
                {
                    Id = product.BrandId,
                    ProductName = product.Name,
                    brand.BrandName,
                    product.Price,
                    product.Description
                })
                .ToList()
               .ForEach(x => Console.WriteLine($"ID: {x.Id}\tProduct Name: {x.ProductName}\tBrand Name: {x.BrandName}\tPrice: {x.Price}\tDescription: {x.Description}"));
        }

        private static void Caud()
        {
            Console.WriteLine("\nCau d: Cac thanh pho co do dai ten lon hon 6, bat dau bang h, sap xep theo thu tu tang dan");
            Cities
                .Where(city => city.Length > 6 && city.StartsWith("h"))
                .OrderBy(city => city)
                .ToList()
                .ForEach(city => Console.WriteLine(city));
        }

        private static void Cauc()
        {
            Console.WriteLine("\nCau c: Tich chia het cho 3");
            var product = daySo
                               .Where(x => x % 3 == 0)
                               .Aggregate(1, (a, b) => a * b);
            Console.WriteLine("Product = " + product);
        }

        private static void Caub()
        {
            Console.WriteLine("\nCau b: Tinh tich luy ke");
            var product = daySo
                .Aggregate(1, (a, b) => a * b);
            Console.WriteLine("Product = " + product);
        }

        private static void Caua()
        {
            Console.WriteLine("\nCau a: Tinh tong luy ke");
            var sum = daySo
                  .Aggregate(0, (a, b) => a + b * b);
            Console.WriteLine("Sum = " + sum);
        }
    }
}
