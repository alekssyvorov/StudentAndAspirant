using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndAspirant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Ivan", "Ivanov", "P25", 4.0);
            Aspirant asp = new Aspirant("Anna", "Aleks", "W15", 4.0, true);
            Student st1 = new Aspirant("Oleg", "Olegov", "R34", 5.0, true);


            List<Student> students = new List<Student>();

            students.Add(st);
            students.Add(asp);
            students.Add(st1);
            foreach (var item in students)
            {
                Console.WriteLine($"Lastname {item.LastName} Ball {item.AverageMark} {item.getScholarship()}");
            }


            Console.ReadLine();
        }
    }
}
