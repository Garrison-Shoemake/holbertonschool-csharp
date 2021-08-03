using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] ret = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            ret[i] = (vector[i] * scalar);
        }
        return ret;
    }
}

