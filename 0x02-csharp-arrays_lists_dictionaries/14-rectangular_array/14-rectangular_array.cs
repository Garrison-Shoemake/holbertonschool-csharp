﻿using System;

    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 5;
            int[,] matrix = new int[width,height];
            matrix[2,2] = 1;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    System.Console.Write(matrix[i,j]);
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }        
        }
    }

