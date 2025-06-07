using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab5
{
    public static class Bai3
    {
        public static void bai3(List<UserAccount> userAccounts)
        {
            Console.WriteLine("Sử dụng ToLookup() để nhóm theo Type:");

            var lookupByType = userAccounts.ToLookup(u => u.Type);

            foreach (var group in lookupByType)
            {
                Console.WriteLine($"\nType: {group.Key} (Count: {group.Count()})");
                foreach (var user in group)
                {
                    Console.WriteLine($"  {user}");
                }
            }
        }
    }
}
