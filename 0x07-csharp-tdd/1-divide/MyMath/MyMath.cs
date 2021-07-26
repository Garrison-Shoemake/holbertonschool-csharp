using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Divides a matrix element by a number</summary>
    public class Matrix
    {
        ///<summary>Method using a matrix and a number to divide by</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {

            try
            {
                if (num == 0)
                {
                    System.Console.WriteLine("Num cannot be 0");
                    return null;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i,j] /= num;
                    }
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
