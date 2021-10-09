using System;
using System.Collections.Generic;
using System.Text;

namespace PolynomialTask
{
    public class PolynomialException : Exception
    {
        public PolynomialException()
        { }

        public PolynomialException(string message)
            : base(message)
        { }

        public PolynomialException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }

    public class PolynomialArgumetException : Exception
    {
        public PolynomialArgumetException()
        { }

        public PolynomialArgumetException(string message)
            : base(message)
        { }

        public PolynomialArgumetException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}

