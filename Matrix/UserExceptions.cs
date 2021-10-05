using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTask
{
    class MatrixException : Exception
    {
        public MatrixException() : base()
        {
        }

        public MatrixException(string message) : base(message)
        {

        }
    }
}
