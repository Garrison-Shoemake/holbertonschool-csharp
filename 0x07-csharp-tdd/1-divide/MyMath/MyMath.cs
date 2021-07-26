using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            int i = 0;
            int j = 0;
            try
            {
                if (num == 0)
                {
                    System.Console.WriteLine("Num cannot be 0");
                    return null;
                }
                while (i < matrix.Length)
                {
                    while (j < matrix.Length)
                    {
                        matrix[i,j] /= num;
                        j++;
                    }
                    i++;
                }
                return matrix;
            }
            catch
            {
                return null;
            }
        }
    }
}
