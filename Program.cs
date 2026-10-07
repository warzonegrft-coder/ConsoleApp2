using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichev_ЛБ2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём три объекта класса Student
            Student s1 = new Student();
            s1.fio = "Иванов";
            s1.ocenka1 = 3;
            s1.ocenka2 = 5;

            Student s2 = new Student();
            s2.fio = "Петров";
            s2.ocenka1 = 4;
            s2.ocenka2 = 4;

            Student s3 = new Student();
            s3.fio = "Сидоров";
            s3.ocenka1 = 5;
            s3.ocenka2 = 3;

            // Выводим данные каждого студента
            Console.WriteLine("=== Студент 1 ===");
            s1.Show();
            Console.WriteLine($"Средняя оценка = {s1.SredOcenka()}\n");

            Console.WriteLine("=== Студент 2 ===");
            s2.Show();
            Console.WriteLine($"Средняя оценка = {s2.SredOcenka()}\n");

            Console.WriteLine("=== Студент 3 ===");
            s3.Show();
            Console.WriteLine($"Средняя оценка = {s3.SredOcenka()}\n");

            Console.ReadKey();
        }
    }

    class Student
    {
        public string fio;
        public int ocenka1;
        public int ocenka2;

        public void Show()
        {
            Console.WriteLine($"Студент: {fio}");
            Console.WriteLine($"Оценка 1 = {ocenka1}, Оценка 2 = {ocenka2}");
        }

        public float SredOcenka()
        {
            return (ocenka1 + ocenka2) / 2f;
        }
    }
}