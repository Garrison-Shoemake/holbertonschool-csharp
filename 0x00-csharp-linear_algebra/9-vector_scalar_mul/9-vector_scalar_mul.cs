using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] ret = new double[vector.Length];
        if (vector.Length < 2 || vector.Length > 3)
        {
            return ret = new double[1]{-1};
        }
        for (int i = 0; i < vector.Length; i++)
        {
            ret[i] = (vector[i] * scalar);
        }
        return ret;
    }
}

