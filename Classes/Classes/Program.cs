using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Teacher[] teacher = new Teacher[5];
            person = new Teacher();
            teacher = person.RandomTeacher(5);
            Student[] student = new Student[5];
            person = new Student();
            student = person.RandomStudent(5);
            //Print
            for (int i = 0; i < teacher.Length; i++)
            {
                Print(teacher[i]);
                Print(student[i]);
            }
        }
        static void Print(Person person)
        {
            Type type = person.GetType();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"*************** { type.Name} ***************");
            Console.ResetColor();
            Console.WriteLine($"Name: {person.name}");
            Console.WriteLine($"Surname: {person.surname}");
            Console.WriteLine($"Email: {person.email}");
            Console.WriteLine($"age: {person.age}");
            Console.WriteLine($"Gender: {person.gender}");
            Teacher t = person as Teacher;
            if (t != null)
            {
                Console.WriteLine($"Salary: {t.salary}");
                Console.WriteLine($"Specialty: {t.specialty}");
            }
        }
        
    }
}
