using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab5
{
    public class UserAccount
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Skin { get; set; }
        public double WinRate { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Rank: {Rank}, Skin: {Skin}, WinRate: {WinRate}%, Type: {Type}";
        }
    }
}
