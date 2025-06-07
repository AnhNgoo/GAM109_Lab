using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab5
{
    public static class Bai1
    {
        public static void bai1(List<UserAccount> userAccounts)
        {
            Console.WriteLine("a/ Danh sách UserAccount:");
            foreach (var user in userAccounts)
            {
                Console.WriteLine($"  {user}");
            }

            Console.WriteLine("\nb/ Sắp xếp theo Rank giảm dần:");
            var sortedByRank = userAccounts.OrderByDescending(u => u.Rank);
            foreach (var user in sortedByRank)
            {
                Console.WriteLine($"  {user}");
            }

            Console.WriteLine("\nc/ Sắp xếp theo Name và Skin giảm dần:");
            var sortedByNameAndSkin = userAccounts.OrderByDescending(u => u.Name)
                                                .ThenByDescending(u => u.Skin);
            foreach (var user in sortedByNameAndSkin)
            {
                Console.WriteLine($"  {user}");
            }

            Console.WriteLine("\nd/ Danh sách người có Name bắt đầu bằng 'B':");
            var usersStartWithB = userAccounts.Where(u => u.Name.StartsWith("B"));
            foreach (var user in usersStartWithB)
            {
                Console.WriteLine($"  {user}");
            }
        }
    }
}
