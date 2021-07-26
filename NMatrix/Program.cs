using System;

namespace NMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Matrix(3);
            Console.WriteLine(matrix.N());
        }
    }
}
