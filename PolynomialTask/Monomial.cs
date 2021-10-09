using System;
using System.Collections.Generic;
using System.Text;

namespace PolynomialTask
{
    public class Monomial
    {
        public double Coefficient { get; set; }
        public int Degree { get; set; }

        public Monomial(double coefficient, int degree)
        {
            Coefficient = coefficient;
            Degree = degree;
        }

    }
}
