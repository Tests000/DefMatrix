using System;
using System.Collections.Generic;
using System.Text;

namespace NMatrix
{
    class Matrix
    {
        double[,] matrix;
        int size;
        public Matrix(int a)
        {
            size = a;
            string[] Array;
            matrix = new double[a, a];
            for (int i = 0; i < a; i++)
            {
                Array = Console.ReadLine().Split(' ');
                for (int j = 0; j < a; j++)
                    matrix[i, j] = Int32.Parse(Array[j]);
            }
        }

        public double N()
        {
            double res = 1;
            double cof;
            double rescof = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    cof = matrix[i, i] / matrix[j, i];
                    for (int k = i; k < size; k++)
                    {
                        matrix[j, k] = matrix[i, k] - matrix[j, k] * cof;
                    }
                    rescof *= -cof;
                }
            }
            Print();
            for (int i = 0; i < size; i++)
            {
                res *= matrix[i, i];
            }
            return res/rescof;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j].ToString() + ' ');
                Console.WriteLine();
            }
        }
    }
}
