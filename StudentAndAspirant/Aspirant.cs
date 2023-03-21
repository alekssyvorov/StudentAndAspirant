using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndAspirant
{
    internal class Aspirant : Student
    {
        public Aspirant() : base() 
        { 
        }
       
        public Aspirant(string lastName, string firstName, string group, double averageMark, bool scientificWork) : base(lastName, firstName, group, averageMark)
        {
            this.ScientificWork = scientificWork;
        }
        public bool ScientificWork { get; set; }
        public override double getScholarship()
        {
            base.getScholarship();
            double money;
            if (AverageMark == 5.0)
                money = 2500;
            else money = 2200;
            return money;
        }
    }
}
