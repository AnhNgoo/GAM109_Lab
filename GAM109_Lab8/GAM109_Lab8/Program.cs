using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace GAM109_Lab8
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Đặt mã hóa đầu ra để hỗ trợ tiếng Việt
            // Gọi bài 1
            Bai1.bai1();
            // Gọi bài 2
            Bai2.bai2();
            Console.WriteLine("\n=== KẾT THÚC CHƯƠNG TRÌNH ===");
        }
    }
}