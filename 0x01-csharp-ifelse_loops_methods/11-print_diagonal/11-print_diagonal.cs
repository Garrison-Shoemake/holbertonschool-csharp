using System;



class Line
{
    public static void PrintDiagonal(int length)
    {
        int i = 0;
        int j = 0;

        if (length > 0)
        {
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                if (length > i)
                {
                    Console.WriteLine("");
                }
            }
        }  
        Console.WriteLine("");
    }
}

