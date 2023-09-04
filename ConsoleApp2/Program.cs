using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Student;


namespace ConsoleApp1
{
    public class StudentMain
    {
        public static void Main()
        {
            Random random = new Random();

            string[] names = { "John", "Mary", "Mari", "Hans", "Marika" };

            for (int i = 0; i < 5; i++) // Создадим 5 студентов с новыми случайными данными
            {
                string name = names[random.Next(names.Length)]; // Случайное имя из массива
                int randomDays = random.Next(-20, -1);
                int randomMinutes = random.Next(-60, 0); // Генерация случайных минут от -60 до 0
                DateTime time = DateTime.Now.AddMinutes(randomMinutes).AddDays(randomDays);

                Student student = CreateRandomStudent(name, time, random);
                student.msg();
            }
        }

        public static Student CreateRandomStudent(string name, DateTime time, Random random)
        {
            string content = "Random Message";
            int likes = random.Next(0, 100);

            Student student = new Student(content, name, time);
            for (int i = 0; i < likes; i++)
            {
                student.AddLike();
            }

            return student;
        }
    }
}

