using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndAspirant
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string lastName, string firstName, string group, double averageMark)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Group = group;
            this.AverageMark = averageMark;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Group { get; private set; }
        public double AverageMark { get; set; }

        public virtual double getScholarship()
        {
            double money;
            if (AverageMark == 5.0)
                money = 2000;
            else money = 1900;
            return money;
        }
    }
}
