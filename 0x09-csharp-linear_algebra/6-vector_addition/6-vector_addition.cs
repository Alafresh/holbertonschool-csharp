using System;

/// <summary>Class that has vectors functions</summary>
class VectorMath
{
    /// <summary>adds two vectors and returns the resulting vector. </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] errVector = {-1};
        if ((vector1.Length < 2 || vector1.Length > 3) && (vector2.Length < 2 || vector2.Length > 3))
            return errVector;
        else if (vector1.Length != vector2.Length)
            return errVector;
        else
        {
            double[] newVector = new double[vector2.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                newVector[i] = vector1[i] + vector2[i];
            }
            return newVector;
        }
    }
}