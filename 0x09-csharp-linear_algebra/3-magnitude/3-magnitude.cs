using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return -1;
        double tmp = 0.0;
        foreach(double v in vector)
        {
            tmp += v * v;
        }
        return (Math.Sqrt(tmp));
    }
}