using System;

/// <summary>Class that has vectors functions</summary>
class VectorMath
{
    /// <summary>multiplies a vector and a scalar and returns the resulting vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] errVector = {-1};
        if (vector.Length < 2 || vector.Length > 3)
            return errVector;

        double[] result = new double[vector.Length];

        for(int i = 0; i < vector.Length; i++)
        {
            result[i] = scalar * vector[i]; 
        }
        return result;
    }
}