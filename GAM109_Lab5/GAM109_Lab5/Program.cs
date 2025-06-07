using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<UserAccount> userAccounts = CreateUserAccounts();

            Console.WriteLine("=== LAB 5 - LINQ PRACTICE ===\n");

            // BÀI 1
            Console.WriteLine("=== BÀI 1 ===");
            Bai1.bai1(userAccounts);

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // BÀI 2
            Console.WriteLine("=== BÀI 2 ===");
            Bai2.bai2(userAccounts);

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // BÀI 3
            Console.WriteLine("=== BÀI 3 ===");
            Bai3.bai3(userAccounts);

            Console.WriteLine("\n" + new string('=', 50) + "\n");
        }

        public static List<UserAccount> CreateUserAccounts()
        {
            return new List<UserAccount>
        {
            new UserAccount { Name = "Alice", Rank = 1200, Skin = "Dragon", WinRate = 75.5, Type = "Premium" },
            new UserAccount { Name = "Bob", Rank = 980, Skin = "Knight", WinRate = 45.2, Type = "Basic" },
            new UserAccount { Name = "Charlie", Rank = 1450, Skin = "Wizard", WinRate = 82.1, Type = "Premium" },
            new UserAccount { Name = "David", Rank = 800, Skin = "Archer", WinRate = 38.9, Type = "Basic" },
            new UserAccount { Name = "Eva", Rank = 1100, Skin = "Mage", WinRate = 67.8, Type = "Premium" },
            new UserAccount { Name = "Frank", Rank = 1300, Skin = "Warrior", WinRate = 55.3, Type = "Basic" },
            new UserAccount { Name = "Grace", Rank = 950, Skin = "Assassin", WinRate = 72.4, Type = "Premium" },
            new UserAccount { Name = "Henry", Rank = 1150, Skin = "Paladin", WinRate = 49.7, Type = "Basic" },
            new UserAccount { Name = "Bella", Rank = 1350, Skin = "Sorceress", WinRate = 88.2, Type = "Premium" },
            new UserAccount { Name = "Brian", Rank = 750, Skin = "Rogue", WinRate = 35.1, Type = "Basic" }
        };
        }
    }
}
