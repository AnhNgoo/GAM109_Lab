using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab6
{
    public static class Bai3
    {
        public static void bai3()
        {
            Console.WriteLine("=== BÀI 3: SET OPERATIONS ===");

            // Dữ liệu đầu vào (giả định)
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int> { 4, 5, 6, 7, 8, 9 };

            // a/ Union - xuất ra màn hình theo giá trị giảm dần
            Console.WriteLine("a/ Union (Giảm dần):");
            var unionResult = list1.Union(list2).OrderByDescending(x => x);
            Console.WriteLine(string.Join(", ", unionResult));

            // b/ Intersect - phần tử chung
            Console.WriteLine("\nb/ Intersect (Phần tử chung):");
            var intersectResult = list1.Intersect(list2);
            Console.WriteLine(string.Join(", ", intersectResult));

            // c/ Concat - nối 2 danh sách, sắp xếp tăng dần
            Console.WriteLine("\nc/ Concat (Tăng dần):");
            var concatResult = list1.Concat(list2).OrderBy(x => x);
            Console.WriteLine(string.Join(", ", concatResult));

            // d/ Except - phần tử trong list1 nhưng không có trong list2
            Console.WriteLine("\nd/ Except (List1 - List2):");
            var exceptResult = list1.Except(list2);
            Console.WriteLine(string.Join(", ", exceptResult));

            Console.WriteLine("\n--- Except (List2 - List1) ---");
            var exceptResult2 = list2.Except(list1);
            Console.WriteLine(string.Join(", ", exceptResult2));

            Console.WriteLine();
        }
    }
}
