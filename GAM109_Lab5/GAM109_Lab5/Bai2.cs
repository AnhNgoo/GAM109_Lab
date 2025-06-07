using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab5
{
    public static class Bai2
    {
        public static void bai2(List<UserAccount> userAccounts)
        {
            Console.WriteLine("a/ Danh sách người có WinRate > 50:");
            var highWinRateUsers = userAccounts.Where(u => u.WinRate > 50);
            foreach (var user in highWinRateUsers)
            {
                Console.WriteLine($"  {user}");
            }

            Console.WriteLine("\nb/ Người có WinRate cao nhất:");
            var highestWinRateUser = userAccounts.OrderByDescending(u => u.WinRate).First();
            Console.WriteLine($"  {highestWinRateUser}");

            Console.WriteLine("\nc/ Tổng số tài khoản UserAccount:");
            int totalAccounts = userAccounts.Count();
            Console.WriteLine($"  Tổng số: {totalAccounts} tài khoản");
        }
    }
}
