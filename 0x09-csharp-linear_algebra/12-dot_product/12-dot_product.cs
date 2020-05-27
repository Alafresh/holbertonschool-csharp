using System;

/// <summary>Class that has vectors functions</summary>
class VectorMath
{
    /// <summary>calculates dot product of either two 2D or two 3D vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
         if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3))
            return -1;
        else if (vector1.Length != vector2.Length)
            return -1;
        else
        {
            double[] product = new double[vector2.Length];
            for(int i = 0; i < vector2.Length; i++)
            {
                product[i] = vector1[i] * vector2[i];
            }
            double dot = 0;
            foreach(double v in product)
            {
                dot += v;
            }
            return dot;
        }
    }
}