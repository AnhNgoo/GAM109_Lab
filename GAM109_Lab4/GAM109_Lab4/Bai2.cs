using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab4
{
    public static class Bai2
    {
        public class UserData
        {
            public string Name { get; set; }
            public int Level { get; set; }

            public UserData(string name, int level)
            {
                Name = name;
                Level = level;
            }
        }

        public static void bai2()
        {
            List<UserData> userList = new List<UserData>
            {
                new UserData("Alice", 25),
                new UserData("Bob", 30),
                new UserData("Charlie", 20),
                new UserData("Diana", 35),
                new UserData("Eve", 28)
            };

            Console.WriteLine("Danh sách user ban đầu:");
            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("\na/ Thông tin Name và Level (sử dụng Select):");
            var nameAndLevel = userList.Select(u => new { u.Name, u.Level });
            foreach (var item in nameAndLevel)
            {
                Console.WriteLine($"Name: {item.Name}, Level: {item.Level}");
            }

            Console.WriteLine("\nb/ Danh sách sắp xếp theo Level giảm dần:");
            var sortedUsers = userList.OrderByDescending(u => u.Level);
            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
            }

        }
    }
}
