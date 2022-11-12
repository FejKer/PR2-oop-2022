using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(1.6);
            Fraction f1 = new Fraction(2, 5);
            Fraction f2 = new Fraction(2, 10);

            //Console.WriteLine(f.print());
            Fraction ff = f1 + f2;
            Console.WriteLine(ff.print());
        }
    }
}
