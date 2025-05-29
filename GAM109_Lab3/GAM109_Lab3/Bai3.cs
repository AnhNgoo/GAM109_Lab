using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab3
{
    public static class Bai3
    {
        public static void bai3()
        {
            string dataDir = "data";
            string data2Dir = "data2";
            string dataFile = Path.Combine(dataDir, "data.txt");

            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
                Console.WriteLine("✓ Đã tạo thư mục 'data'");
            }

            string mssv = "SV001";
            string hoTen = "Nguyễn Văn A";

            using (StreamWriter writer = new StreamWriter(dataFile))
            {
                writer.WriteLine($"MSSV: {mssv}");
                writer.WriteLine($"Họ và tên: {hoTen}");
            }
            Console.WriteLine("✓ Đã tạo file data.txt với thông tin sinh viên");

            if (!Directory.Exists(data2Dir))
            {
                Directory.CreateDirectory(data2Dir);
                Console.WriteLine("✓ Đã tạo thư mục 'data2'");
            }

            FileInfo sourceFile = new FileInfo(dataFile);
            string destFile = Path.Combine(data2Dir, sourceFile.Name);

            sourceFile.CopyTo(destFile, true);
            Console.WriteLine("✓ Đã copy file từ 'data' sang 'data2'");

            Console.WriteLine("\nNội dung file trong thư mục data2:");
            using (StreamReader reader = new StreamReader(destFile))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
