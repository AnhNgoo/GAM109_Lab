using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab7
{
    internal class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public Brand(int id, string brandName)
        {
            Id = id;
            BrandName = brandName;
        }
    }
}