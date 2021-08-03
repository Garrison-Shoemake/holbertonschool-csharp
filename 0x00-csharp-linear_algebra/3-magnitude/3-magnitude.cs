using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        int i = 0;
        double sum = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        for (; i < vector.Length; i++)
        {
            sum += Math.Pow(vector[i], 2);    
        }
        return Math.Round(Math.Sqrt(sum), 2);
    }
}

