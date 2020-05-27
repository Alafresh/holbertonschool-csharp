using System;

/// <summary>Class that has vectors functions</summary>
class VectorMath
{
    /// <summary>calculates and returns the length of a given vector.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return -1;
        double tmp = 0.0;
        foreach(double v in vector)
        {
            tmp += v * v;
        }
        return Math.Round(Math.Sqrt(tmp), 2);
    }
}