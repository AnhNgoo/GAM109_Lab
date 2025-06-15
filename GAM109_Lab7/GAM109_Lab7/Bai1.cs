using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab7
{
    public static class Bai1
    {
        private static readonly List<int> nums = [1, 3, 4, 5, 8, 9];
        private static readonly string str = "chao mung den voi binh nguyen vo tan";
        private static readonly string str1 = "CHAO mung DEN Voi binh nguyen vo tan";

        public static void _Bai1()
        {
            Console.WriteLine("Bai1");
            Caua();
            Caub();
            Cauc();
        }

        private static void Caua()
        {
            Console.WriteLine("\nCau a: Binh phuong cac so lon hon 4");
            nums
                 .Where(x => x > 4)
                 .Select(x => Math.Pow(x, 2))
                 .ToList()
                 .ForEach(x => Console.WriteLine(x));
        }
        private static void Caub()
        {
            Console.WriteLine("\nCau b: Xuat lan luot so lan xuat hien cua tung chu");
            str
                .Where(Char.IsLetter)
                .GroupBy(str => str)
                .ToList()
                .ForEach(str => Console.WriteLine($"Ki tu: {str.Key}| So lan xuat hien: {str.Count()}"));
        }
        private static void Cauc()
        {
            Console.WriteLine("\nCau c: Xuat nhung chuoi duoc viet hoa toan bo");
            string[] words = str1.Split(' ');
            words
                .Where(word => word.Equals(word.ToUpper()))
                .ToList()
                .ForEach(word => Console.WriteLine(word));
        }
    }
}
