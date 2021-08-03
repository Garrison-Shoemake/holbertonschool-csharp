using System;


class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double sum = 0;

        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3) || (vector1.Length != vector2.Length))
        {
            return -1;
        }
        for (int i = 0; i < vector1.Length; i++)
        {
            sum += vector1[i] * vector2[i];
        }
        return sum;
    }
}

