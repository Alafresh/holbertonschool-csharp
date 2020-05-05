using System;

namespace MyMath
{
    /// <summary>Class Matrix that have methods to manipulate a matrix</summary>
    public class Matrix
    {
        /// <summary>divides a matrix by x num a return a new mtrix</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            int[,] newMatrix = matrix;
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return newMatrix;
        }
    }
}
