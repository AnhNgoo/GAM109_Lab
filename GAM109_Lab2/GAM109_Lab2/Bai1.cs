using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab2
{
    internal class Bai1
    {
        dynamic x = 10;
        public void bai1a()
        {
            Console.WriteLine("x: " + x);
        }

        public void bai1b()
        {
            GetDetail(10);
            GetDetail("game");
            GetDetail(true);
            GetDetail(9.5);
        }

        public void bai1c()
        {
            userData UD = new userData("2025", "Hide on Bush", 50);
            UD.GetInfo();
        }

        public void GetDetail(dynamic value)
        {
            Console.WriteLine("value: " + value);
        }
    }
}
