using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatrixTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            Matrix matrix = new Matrix(2,3);

            double[] arr = new double[6] { 1, 2, 2, 3, 1, 1 };
            double[] arr1 = new double[6] { 4, 2, 3, 1, 1,5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Math.Round(Math.Pow(10, random.Next(1,4)) * random.NextDouble(), 2);
            //}

            Matrix matrix1 = new Matrix(2, 3, arr);
            Matrix matrix2 = new Matrix(3, 2, arr1);
            Matrix matrix3 = matrix1.Multiply(matrix2);
            //matrix3 = matrix1.Deduct(matrix2);
            //matrix3 = matrix1.Add(matrix2);
            //matrix3 = matrix1 + matrix2;
            //matrix3 = matrix1 - matrix2;
            matrix3 = matrix1 * matrix2;
            Matrix matrix4 = (Matrix)matrix1.Clone();

        }
    }
}
