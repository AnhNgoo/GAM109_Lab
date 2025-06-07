using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab6
{
    public static class Bai2
    {
        public static void bai2()
        {
            Console.WriteLine("=== BÀI 2: JOIN OPERATORS ===");

            // Dữ liệu mẫu
            List<Shop> listShop = new List<Shop>
            {
                new Shop(1, "HCM", "Quận 12"),
                new Shop(2, "Hà Nội", "Quận Nam Từ Liêm"),
                new Shop(3, "Đà Nẵng", "Quận Hải Châu")
            };

            List<Phone> listPhone = new List<Phone>
            {
                new Phone(1, 1, "IP 15", 100, "độc lạ bình dương"),
                new Phone(2, 2, "IP 16", 1000, "độc lạ bình dương"),
                new Phone(3, 3, "IP 17", 10000, "độc lạ bình dương"),
                new Phone(4, 1, "IP 18", 100000, "độc lạ bình dương")
            };

            // a/ Join Query - ShopName và PhoneName
            Console.WriteLine("a/ Join Query Results:");
            var result = listShop.Join(listPhone,
            shop => shop.id,
            phone => phone.shop_id,
            (shop, phone) => new
            {
                ShopName = shop.name,
                PhoneName = phone.name
            });

            foreach (var item in result)
            {
                Console.WriteLine($"ShopName: {item.ShopName}, PhoneName: {item.PhoneName}");
            }

            // b/ Group Join
            Console.WriteLine("\nb/ Group Join Results:");
            var resultb = listShop.GroupJoin(listPhone,
                            shop => shop.id,
                            phone => phone.shop_id,
                            (shop, phones) => new { Shop = shop, Phones = phones })
                            .SelectMany(
                                x => x.Phones.DefaultIfEmpty(),
                                (shop, phone) => new
                                {
                                    ShopName = shop.Shop.name,
                                    PhoneName = phone?.name ?? "No Phone",
                                    PhonePrice = phone?.price.ToString() ?? "N/A"
                                });

            foreach (var item in resultb)
            {
                Console.WriteLine($"ShopName: {item.ShopName}");
                Console.WriteLine($"phoneName: {item.PhoneName}");
                Console.WriteLine($"phonePrice: {item.PhonePrice}");
                Console.WriteLine();
            }
        }
    }
}
