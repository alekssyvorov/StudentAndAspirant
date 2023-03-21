using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasNumbers
{
    internal class MasIntNumber
    {
        public MasIntNumber()  {}
        public MasIntNumber(double number)
        {
            this.Number = number;
        }
        public double Number { get; }

        public List<int> Func(double number)
        {
            List<int> result = new List<int>();
            string[] temp = number.ToString().Split(',');
            int resNumber = int.Parse(temp[0] + temp[1]);
            while (resNumber > 0)
            {
                int tempA = resNumber % 10;
                result.Add(tempA);
                resNumber = (int)resNumber / 10;
            }
            result.Reverse();
            return result;
        }
    }
}
