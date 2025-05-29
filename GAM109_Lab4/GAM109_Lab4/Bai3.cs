using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GAM109_Lab4
{
    public static class Bai3
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        public static void bai3()
        {
            List<Student> students = new List<Student>
            {
                new Student("An", 10),
                new Student("Bình", 15),
                new Student("Cường", 18),
                new Student("Dung", 22),
                new Student("Em", 16),
                new Student("Phong", 19),
                new Student("Giang", 11),
                new Student("Hải", 25)
            };

            Console.WriteLine("Danh sách sinh viên ban đầu:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\na/ Students có Age > 12 và Age < 20 (LINQ Query Syntax):");
            var queryResult = from s in students
                              where s.Age > 12 && s.Age < 20
                              select s;

            foreach (var student in queryResult)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\nb/ Students có Age > 12 và Age < 20 (LINQ Method Syntax):");
            var methodResult = students.Where(s => s.Age > 12 && s.Age < 20);

            foreach (var student in methodResult)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
