using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var teachers = new List<Teacher>();
            students.Add(new Student("John", "Smith", 1234));
            students.Add(new Student("Kevin", "James", 4321));
            students.Add(new Student("Adam", "Richards", 9876));
            students.Add(new Student("Mike", "Hype", 4765));
            students.Add(new Student("Jack", "Hill", 2947));
            teachers.Add(new Teacher("Lily", "Sass", "5263", "Level 5"));
            teachers.Add(new Teacher("Mandy", "Lass", "1029", "Level 10"));
            teachers.Add(new Teacher("Emma", "Watson", "9571", "Level 7"));
            teachers.Add(new Teacher("Jill", "Sally", "2401", "Level 2"));
            teachers.Add(new Teacher("Hilda", "James", "5263", "Level 1"));
            Console.WriteLine("--- Student Info ---");
            foreach(Student x in students)
            {
                Console.WriteLine(x.GetStdtDeets());
            }
            Console.WriteLine("\n--- Teacher Info ---");
            foreach(Teacher y in teachers)
            {
                Console.WriteLine(y.GetTeachDeets());
            }
        }
    }
}
