using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab7
{
    internal class Product
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Product(int brandId, string name, int price, string description)
        {
            this.BrandId = brandId;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
    }
}