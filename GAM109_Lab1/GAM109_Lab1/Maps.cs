using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab1
{
    internal class Maps
    {
        public string ID;
        public string Name;
        public static string _inGame = "Liên Minh Huyền Thoại";

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public Maps()
        {

        }

        public string ShowData()
        {
            return "ID: " + ID + "| Name: " + Name + "| inGame: " + _inGame;
        }
    }
}
