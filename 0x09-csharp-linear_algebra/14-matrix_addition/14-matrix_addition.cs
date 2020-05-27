using System;

/// <summary>Matrix functions</summary>

class MatrixMath
{
    /// <summary>method that adds two matrices 2D or 3D and returns the resulting matrix.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] errMatrix = new double[,] { {-1} };
        if (matrix1.Length != matrix2.Length)
            return errMatrix;
        else if (matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3)
            return errMatrix;
        else
        {
            double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(0)];
            int dim1 = matrix1.GetLength(0);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i,j];
                }
            }
            return result;
        }
    }
}