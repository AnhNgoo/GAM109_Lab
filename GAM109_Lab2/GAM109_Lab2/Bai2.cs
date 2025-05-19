using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab2
{
    internal class Bai2
    {
        public void bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = "faker",
                isplaying = false,
                bag = new
                {
                skins = 0,
                cups = 0,
                }
                
            };

            Console.WriteLine("\nid: " + userInfp.id);
            Console.WriteLine("name: "+ userInfp.name);
            Console.WriteLine("isplaying: "+ userInfp.isplaying);
            Console.WriteLine("bag skins: "+ userInfp.bag.skins);
            Console.WriteLine("bag cups: "+ userInfp.bag.cups);
        }

        public void bai2b()
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("\nsum: "+ sum);
                Console.WriteLine("sub: "+ sub);
            };

            AnonymousMethod(5);
        }
    }
}
