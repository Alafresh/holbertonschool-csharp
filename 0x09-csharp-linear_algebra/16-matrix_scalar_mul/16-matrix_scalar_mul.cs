using System;

/// <summary>Matrix functions</summary>
class MatrixMath
{
    /// <summary>multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] errMatrix = new double[,] { { -1 } };
        if (matrix.GetLength(0) < 2 || matrix.GetLength(1) > 3)
            return errMatrix;
        double[,] total = new double[matrix.GetLength(0) , matrix.GetLength(1)];
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                total[i, j] = matrix[i, j] * scalar;        
            }
        }
        return total;
    }
}