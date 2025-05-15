using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab1
{
    internal static class UserData
    {
        public static string ID;
        public static string UserName;
        public static int Gold;
        public static int Point;

        static UserData()
        {
            ID = "2025";
            UserName = "AnhNgoo";
            Gold = 500;
            Point = 1000;
        }
    }
}
