using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab2
{
    internal class Bai3
    {
        public void bai3()
        {
            List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

            userData user = new userData();
            user.id = "11844";
            user.username = "QuocAnh";
            user.Scores = new List<float>();

            foreach (float score in ldata)
            {
                user.Scores.Add(score);
            }

            Console.WriteLine("\nStudent ID: " + user.id);
            Console.WriteLine("Name: " + user.username);
            Console.WriteLine("Scores:");
            foreach (float score in user.Scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
