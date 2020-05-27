using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        Console.WriteLine("matrix 2D 0 {0}",matrix.GetLength(0));
        Console.WriteLine("matrix 3D 0 {0}", matrix2.GetLength(0));
        Console.WriteLine("matrix 2D 1 {0}",matrix.GetLength(1));
        Console.WriteLine("matrix 3D 1 {0}",matrix2.GetLength(1));

        double[,] total = MatrixMath.Add(matrix1, matrix2);
        int dim1 = matrix1.GetLength(0);
            
        for (int i = 0; i < dim1; i++) 
            for (int j = 0; j < dim1; j++)
                Console.WriteLine(total[i, j]);
        
    }
}