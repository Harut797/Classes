using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Classes
{
    class Teacher : Person
    {
        public int salary;
        public string specialty;
        public Teacher[] RandomTeacher(int count)
        {
            Random rnd = new Random();
            string[] gender = new string[2];
            gender[0] = "Man";
            gender[1] = "Woman";
            string[] specialty = new string[4];
            specialty[0] = "C#";
            specialty[1] = "JavaScript";
            specialty[2] = "PHP";
            specialty[3] = "C++";
            string[] name = new string[count];
            string[] surname = new string[count];
            string[] email = new string[count];
            for (int i = 0; i < count; i++)
            {
                name[i] = $"Teacher{i} Name";
                surname[i] = $"Teacher{i} Surname";
                email[i] = $"{name[i]}.{surname[i]}@gmail.com";
            }

            Teacher[] teacher = new Teacher[count];
            for (int i = 0; i < count; i++)
            {
                byte genderIndex = (byte)rnd.Next(0, 2);
                byte specialtyIndex = (byte)rnd.Next(0, 4);
                byte age = (byte)rnd.Next(25, 70);
                int salary = rnd.Next(100000, 800000);
                Thread.Sleep(30);
                teacher[i] = new Teacher();
                teacher[i].name = name[i];
                teacher[i].surname = surname[i];
                teacher[i].email = email[i];
                teacher[i].age = age;
                teacher[i].gender = gender[genderIndex];
                teacher[i].specialty = specialty[specialtyIndex];
                teacher[i].salary = salary;
            }
            return teacher;
        }
    }

}
