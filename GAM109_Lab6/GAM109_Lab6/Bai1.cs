using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab6
{
    public static class Bai1
    {
        public static void bai1()
        {
            Console.WriteLine("=== BÀI 1: ELEMENT OPERATORS ===");

            // Dữ liệu đầu vào (giả định dựa trên yêu cầu)
            List<int> listInt = new List<int> { 1, 2, 3, 4, 6, 8, 10, 15, 20, 25, 150, 250, 300 };
            List<string> listStr = new List<string> { "Apple", "Banana", "Tiger", "Cat", "Dog", "Table" };

            // a/ Tìm số chẵn đầu tiên và lớn hơn 5 trong listInt
            var firstEvenGreaterThan5 = listInt.FirstOrDefault(x => x % 2 == 0 && x > 5);
            Console.WriteLine($"a/ Số chẵn đầu tiên lớn hơn 5: {firstEvenGreaterThan5}");

            // b/ Tìm phần tử cuối cùng trong listInt có giá trị > 200
            var lastGreaterThan200 = listInt.LastOrDefault(x => x > 200);
            Console.WriteLine($"b/ Phần tử cuối cùng > 200: {lastGreaterThan200}");

            // c/ Tìm phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự "T"
            var firstStartsWithT = listStr.FirstOrDefault(x => x.StartsWith("T"));
            Console.WriteLine($"c/ Phần tử đầu tiên bắt đầu bằng 'T': {firstStartsWithT}");

            // d/ Tính tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt
            var sumOddIndexEvenNumbers = listInt
                .Where((value, index) => index % 2 == 1 && value % 2 == 0)
                .Sum();
            Console.WriteLine($"d/ Tổng các số ở vị trí lẻ và chia hết cho 2: {sumOddIndexEvenNumbers}");

            Console.WriteLine();
        }
    }
}
