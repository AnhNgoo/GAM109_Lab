using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab4
{
    public static class Bai1
    {
        public static void bai1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 15, 16, 18, 20 };
            Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", numbers));

            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

            Console.WriteLine("Các số chẵn:");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
