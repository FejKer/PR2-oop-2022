using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    internal class Fraction
    {
        int numerator;
        int denominator;
        bool isProper;
        double number;

        public Fraction(double number)
        {
            this.number = number;
            convert();
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            isProper = checkProper();
        }
        private void convert()
        {
            double dnumerator;
            double ddenominator;
            string temp = number.ToString();
            int length = temp.Length - 2;
            dnumerator = number;
            ddenominator = 1.0;
            dnumerator *= Math.Pow(10, length);
            ddenominator *= Math.Pow(10, length);
            numerator = Convert.ToInt32(dnumerator);
            denominator = Convert.ToInt32(ddenominator);
            int d = biggestDivider();
            numerator = numerator / d;
            denominator = denominator / d;
            shorten();
        }
        private bool checkProper()
        {
            if(numerator > denominator)
            {
                return false;
            }
            return true;
        }
        public int biggestDivider()
        {
            int a = numerator;
            int b = denominator;
            while (b != 0)
            {
                int tmp = a;
                a = b;
                b = tmp % b;
            }
            return a;
        }
        public void shorten()
        {
            int temp = biggestDivider();
            numerator = numerator / temp;
            denominator = denominator / temp;
        }
        public String print()
        {
            if(denominator == 1)
            {
                return numerator.ToString();
            } else
            {
                return numerator.ToString() + " / " + denominator.ToString();
            }
        }
        public void invert()
        {
            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }
        public double toDec()
        {
            return (double)numerator / denominator;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
            f.shorten();
            return f;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.numerator * f2.numerator, f1.denominator * f2.denominator);
            f.shorten();
            return f;
        }
    }
}
