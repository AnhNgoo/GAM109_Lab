using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài 1
            Console.WriteLine($"ID: {UserData.ID}");
            Console.WriteLine($"UserName: {UserData.UserName}");
            Console.WriteLine($"Gold: {UserData.Gold}");
            Console.WriteLine($"Point: {UserData.Point} \n");

            //Bài 2
            var map1 = new Maps("102008", "AnhKG");
            Console.WriteLine(map1.ShowData());

            var map2 = new Maps()
            {
                ID = "11844",
                Name = "GodPunish"
            };

            Console.WriteLine(map2.ShowData() + "\n");

            //Bài 3
            Calculator c1 = new Calculator();

            c1.DisplayResult();
        }
    }
}
