using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab3
{
    public static class Bai2
    {
        public static void bai2()
        {
            string username = "user123";
            string password = "mypassword";
            DateTime time = DateTime.Now;

            using (StringWriter stringWriter = new StringWriter())
            {
                stringWriter.WriteLine($"Tài khoản: {username}");
                stringWriter.WriteLine($"Mật khẩu: {password}");
                stringWriter.WriteLine($"Thời gian lưu: {time}");

                string data = stringWriter.ToString();

                using (StringReader stringReader = new StringReader(data))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
