using System;


    class MatrixMath
    {
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            double[,] wrong = new double[,]{{-1}};
            double[,] ret = new double[matrix1.GetLength(0),matrix1.GetLength(1)];
            if (matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3)
            {
                return wrong;
            }
            if (matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3)
            {
                return wrong;
            }
            if (matrix1.GetLength(0) != matrix2.GetLength(0))
            {
                return wrong;
            }
            if (matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                return wrong;
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    ret[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            return ret;
        }
    }

