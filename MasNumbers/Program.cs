using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            MasIntNumber m = new MasIntNumber();
            Console.WriteLine();
            foreach (var item in m.Func(num))
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
