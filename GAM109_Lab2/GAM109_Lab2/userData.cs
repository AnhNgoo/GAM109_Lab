using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab2
{
    internal class userData
    {
        public string id;
        public string username;
        public int level;
        public List<float> Scores;

        public userData()
        {

        }

        public userData(string id, string username, int level)
        {
            this.id = id;
            this.username = username;
            this.level = level;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID: " + id + " |username: " + username + " |level: " + level);
        }
    }
}
