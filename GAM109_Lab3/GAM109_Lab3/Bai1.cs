using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab3
{
    public static class Bai1
    {
        public static void bai1()
        {
            string path = "..//..//data.txt";
            string username = "admin123";
            string password = "password456";

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.WriteLine($"Username: {username}");
                    writer.WriteLine($"Password: {password}");
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    Console.WriteLine("\nNội dung đọc từ file:");
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }  
        }
    }
}
