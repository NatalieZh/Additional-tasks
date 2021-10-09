using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace PolynomialTask
{
    public class Polynomial
    {
        private int _polynomialDegree;

        public List<Monomial> Monomials;
        public Dictionary<int, Monomial> KeyValuePairs;
        public int PolynomialDegree
        {
            get { return _polynomialDegree; }
        }
        public Polynomial()
        {
            Monomials = new List<Monomial>();
        }
        public Polynomial(double[] coefficients, int[] degrees)
        {
            
            if (coefficients.Length == degrees.Length && coefficients.Length > 0)
            {
                if (CheckDegreesArray(degrees))
                {
                    Monomials = new List<Monomial>();
                    for (int i = 0; i < coefficients.Length; i++)
                    {
                        Monomials.Add(new Monomial(coefficients[i], degrees[i]));
                    }

                }
                else
                {
                    throw new PolynomialArgumetException("Array with degrees should have unique values.");                
                }
            }
            else
            {
                throw new ArgumentException("Number of coeficients and dergees is not equal or arrays are empty.");
            }

        }

        #region Private methods

        private bool CheckDegreesArray(int[] degrees)
        {
            IEnumerable<IGrouping<int, int>> groups = degrees.GroupBy(v => v);
            return groups.Count() == degrees.Length;
        }

        private int GetPolynomialDegree()
        {
            int result = 0;
            int maxDegree = int.MinValue;
            if (Monomials != null)
            {
                foreach (Monomial m in Monomials)
                {
                    if (m.Degree > maxDegree)
                    {
                        maxDegree = m.Degree;
                    }
                }
            }

            return result;
        }

        #endregion
    }
}
