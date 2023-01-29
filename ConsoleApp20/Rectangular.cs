using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Rectangular : Triangle
    {
        private double a;
        private double b;

        public double A 
        {
            get { return a; }
            set { if (value > 0) a = value; }
        }
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }

        public Rectangular (double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Area()
        {
            return (A * B) / 2;
        }

        public override double Perimeter()
        {
            return A + B + Math.Sqrt(A * A + B * B);
        }
    }
}
