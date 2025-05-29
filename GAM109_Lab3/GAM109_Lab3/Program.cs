using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1.bai1();
            Console.WriteLine("\n" + new string('=', 50) + "\n");

            Bai2.bai2();
            Console.WriteLine("\n" + new string('=', 50) + "\n");

            Bai3.bai3();
            Console.WriteLine("\n" + new string('=', 50) + "\n");
        }
    }
}
