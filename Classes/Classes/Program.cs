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
            //Person person = new Person();
            Teacher[] teacher = new Teacher[5];
            teacher[0] = new Teacher();
            teacher = teacher[0].RandomTeacher(5);
            //for (int i = 0; i < teacher.Length; i++)
            //{
            //    teacher[i] = new Teacher();
            //    teacher = teacher[i].RandomTeacher(5);
            //}
            

            //teacher[0].name = "Teacher1Name";
            //teacher[0].surname = "Teacher1Surname";
            //teacher[0].email = "Teacher1Email";
            //teacher[0].age = 56;
            //teacher[0].gender = "Man";
            //teacher[0].salary = 150000;
            //teacher[0].specialty = "C#";

            //    name = "Teacher1Name",
            //    surname = "Teacher1Surname",
            //    email = "Teacher1Email",
            //    age = 56,
            //    gender = "Man",
            //    salary = 150000,
            //    specialty = "C#"
            //};
            //Teacher teacher2 = new Teacher
            //{
            //    name = "Teacher2Name",
            //    surname = "Teacher2Surname",
            //    email = "Teacher2Email",
            //    age = 60,
            //    gender = "Woman",
            //    salary = 170000,
            //    specialty = "JavaScript"
            //};
            //Print(teacher1);
            for (int i = 0; i < teacher.Length; i++)
            {
                Print(teacher[i]);
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
                Console.WriteLine($"Salary: {t.salary}");
                Console.WriteLine($"Specialty: {t.specialty}");


        }
        
    }
}
