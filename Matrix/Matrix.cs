using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTask
{
    public class Matrix : ICloneable
    {
        #region Private variables

        private double[,] _value;
        private int _rows, _columns;

        #endregion

        #region Properties
        public int Rows
        {
            get => _rows;
        }

        public int Columns
        {
            get => _columns;
        }
        public double[,] Value
        {
            get{ return _value; }
            //set { _value = value; }
        }

        public double this[int i, int j]
        {
            get => _value[i, j];
            set => _value[i, j] = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create empty matrix.
        /// </summary>
        /// <param name="rows">Number of rows</param>
        /// <param name="columns">Number of columns</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when number of rows and columns less then 1</exception>
        public Matrix(int rows, int columns)
        {
            FillInitialValues(rows, columns);
        }

        /// <summary>
        /// Create matrix from one-dimential array.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="array">One-dimentional array. Values from array are used to fullfill matrix: matrix[0,0] = array[0], matrix[0,1] = array[1] and so on. Matrix will be filled row by row. </param>
        public Matrix(int rows, int columns, double[] array)
        {
            FillInitialValues(rows, columns);
            //fill from array
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    _value[i, j] = array[k];
                    k++;
                    if (k >= array.Length)
                    {
                        break;
                    }
                }
                if (k >= array.Length)
                {
                    break;
                }

            }
        }

        /// <summary>
        /// Create matrix from two-dimential array.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="array">Two-dimentional array. Values from array are used to fullfill matrix. If boundaries of array and matrix are not equal ArgumentOutOfRangeException exception is thrown</param>
        public Matrix(int rows, int columns, double[,] array)
        {
            if (Rows == array.GetUpperBound(0) && Columns == array.GetUpperBound(1))
            {
                FillInitialValues(rows, columns);
                //fill from array
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        _value[i, j] = array[i,j];
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Not possible to create matrix from array. Boundaries of array and matrix are not equa.");
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowNumber">Number of returned row</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when number of returned row is negative</exception>
        public double[] GetRow(int rowNumber)
        {
            if (rowNumber < 0) 
            {
                throw new ArgumentOutOfRangeException("Number of returned row is negative or or greater the number of rows in the matrix");
            }
            double[] temp = new double[Columns];

            for (int i = 0; i < Columns; i++)
            {
                temp[i] = this[rowNumber, i];
            }
            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowNumber">Number of returned row started from 0</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when number of returned row is negative</exception>
        public double[] GetColumn(int columnNumber)
        {
            if (columnNumber < 0 || columnNumber >= Columns)
            {
                throw new ArgumentOutOfRangeException("Number of returned colunm is negative or greater the number of columns in the matrix");
            }
            double[] temp = new double[Rows];

            for (int i = 0; i < Rows; i++)
            {
                temp[i] = this[i, columnNumber];
            }
            return temp;
        }

        /// <summary>
        /// Returns result of 2 added matrixes
        /// </summary>
        /// <param name="matrix">Added matrix</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when added matrix is not the same dimension as current.</exception>
        public Matrix Add(Matrix matrix)
        {
            Matrix temp = new Matrix(Rows, Columns);

            if (Rows != matrix.Rows || Columns != matrix.Columns)
            {
                throw new ArgumentException("Parameter 'matrix' should has the same dimension as current one.");
            }
            try
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        temp[i, j] = this[i, j] + matrix[i, j];
                    }
                }
            }
            catch
            {
                throw new MatrixException("Matrixs can't be added!");
            }
            return temp;
        }

        /// <summary>
        /// Returns result of 2 deducted matrixes
        /// </summary>
        /// <param name="matrix">Deducted matrix</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when deducted matrix is not the same dimension as current.</exception>
        public Matrix Deduct(Matrix matrix)
        {
            Matrix temp = new Matrix(Rows, Columns);

            if (Rows != matrix.Rows || Columns != matrix.Columns)
            {
                throw new ArgumentException("Parameter 'matrix' should has the same dimension as current one.");
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    temp[i, j] = this[i, j] - matrix[i, j];
                }
            }
            return temp;
        }

        /// <summary>
        /// Returns result of 2 multiplied matrixes
        /// </summary>
        /// <param name="matrix">Multiplied matrix</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when number of columns in parameter 'matrix' is not equal to number of rows in current one.</exception>
        public Matrix Multiply(Matrix matrix)
        {
            if (Rows != matrix.Columns)
            {
                throw new ArgumentException("Number of columns in parameter 'matrix' should be equal to number of rows in current one.");
            }
            Matrix temp = new Matrix(Rows, matrix.Columns);
            try
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < matrix.Columns; j++)
                    {
                        double[] r = GetRow(i);
                        double[] c = matrix.GetColumn(j);
                        for (int k = 0; k < r.Length; k++)
                        {
                            temp[i, j] += r[k] * c[k];
                        }
                    }
                }
            }
            catch
            {
                throw new MatrixException("Matrixs can't be multiplied!");
            }
            return temp;
        }

        #endregion

        #region Overloaded operators
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.Add(matrix2);
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.Deduct(matrix2);
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.Multiply(matrix2);
        }

        #endregion

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            Matrix temp;
            if (obj is Matrix)
            {
               temp = (Matrix)obj;
            }
            else 
            {
               return false;
            }
            return Rows == temp.Rows && Columns == temp.Columns && CompareValues(temp);
        }

        #region Private functions

        private void FillInitialValues(int rows, int columns)
        {
            if (rows > 0 && columns > 0)
            {
                _rows = rows;
                _columns = columns;
                _value = new double[rows, columns];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Not possible to create matrix with number of columns or rows les then 1.");
            }
        }

        private bool CompareValues(Matrix matrix)
        {
            bool result = true;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (this[i, j] != matrix[i, j])
                    {
                        return false;
                    }
                }
            }
            return result;
        }

        #endregion


    }
}
